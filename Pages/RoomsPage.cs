using System.Globalization;

namespace SmartCampus;

public partial class RoomsPage : UserControl
{
    private static readonly CultureInfo Inv = CultureInfo.InvariantCulture;

    private ICampusRepository _repository = null!;
    private List<CampusRoom> _rooms = [];
    private List<(DateTime Date, TimeSpan Start, TimeSpan End)> _slots = [];
    private List<(string Room, DateTime Date, TimeSpan Start, TimeSpan End)> _blocks = [];
    private Action<string> _notify = _ => { };

    public RoomsPage()
    {
        InitializeComponent();
        Theme.Apply(this);
        dtpSlotDate.MinDate = DateTime.Today;
        dtpBlockDate.MinDate = DateTime.Today;
        dtpSlotStart.Value = DateTime.Today.AddHours(9);
        dtpSlotEnd.Value = DateTime.Today.AddHours(11);
    }

    public void Bind(
        ICampusRepository repository,
        List<CampusRoom> rooms,
        List<(DateTime Date, TimeSpan Start, TimeSpan End)> slots,
        List<(string Room, DateTime Date, TimeSpan Start, TimeSpan End)> blocks,
        Action<string> notify)
    {
        _repository = repository; _rooms = rooms; _slots = slots; _blocks = blocks; _notify = notify;
        RefreshTables();
    }

    private static string Fmt(TimeSpan t) => DateTime.Today.Add(t).ToString("hh:mm tt", Inv);
    private static string SlotText(TimeSpan start, TimeSpan end) => $"{Fmt(start)} - {Fmt(end)}";

    private void RefreshTables()
    {
        dgvRooms.Rows.Clear();
        foreach (var r in _rooms) dgvRooms.Rows.Add(r.Name, r.Building, r.Capacity, r.State);

        dgvSlots.Rows.Clear();
        foreach (var s in _slots) dgvSlots.Rows.Add(s.Date.ToString("dd/MM/yyyy", Inv), Fmt(s.Start), Fmt(s.End));

        dgvBlocks.Rows.Clear();
        foreach (var b in _blocks) dgvBlocks.Rows.Add(b.Room, b.Date.ToString("dd/MM/yyyy", Inv), SlotText(b.Start, b.End));

        var selectedRoom = cboRoom.SelectedItem?.ToString();
        cboRoom.Items.Clear();
        foreach (var r in _rooms) cboRoom.Items.Add(r.Name);
        if (selectedRoom is not null && cboRoom.Items.Contains(selectedRoom)) cboRoom.SelectedItem = selectedRoom;
        else if (cboRoom.Items.Count > 0) cboRoom.SelectedIndex = 0;

        var date = dtpBlockDate.Value.Date;
        var oldSlot = cboSlot.SelectedItem?.ToString();
        cboSlot.Items.Clear();
        foreach (var slot in _slots.Where(x => x.Date.Date == date)) cboSlot.Items.Add(SlotText(slot.Start, slot.End));
        if (oldSlot is not null && cboSlot.Items.Contains(oldSlot)) cboSlot.SelectedItem = oldSlot;
        else if (cboSlot.Items.Count > 0) cboSlot.SelectedIndex = 0;
    }

    private void btnOpenResources_Click(object? sender, EventArgs e)
    {
        using var window = new ResourcesForm(_repository, _rooms, _slots, _blocks);
        window.ShowDialog(FindForm());
        RefreshTables();
    }

    private void btnAddRoom_Click(object? sender, EventArgs e)
    {
        var name = txtRoomName.Text.Trim();
        var building = txtBuilding.Text.Trim();
        if (name.Length == 0 || building.Length == 0) { _notify("Enter the room name and building."); return; }
        if (_rooms.Any(r => r.Name.Equals(name, StringComparison.OrdinalIgnoreCase))) { _notify("A room with this name already exists."); return; }
        var room = new CampusRoom(name, building, (int)nudCapacity.Value, "Available");
        try
        {
            _repository.SaveRoom(room);
            _rooms.Add(room);
            txtRoomName.Clear(); txtBuilding.Clear();
            RefreshTables();
            _notify("Room added successfully.");
        }
        catch (Exception ex) { _notify("Could not save room: " + ex.Message); }
    }

    private void btnRemoveRoom_Click(object? sender, EventArgs e)
    {
        if (dgvRooms.CurrentRow is null) { _notify("Select a room to remove."); return; }
        var name = Convert.ToString(dgvRooms.CurrentRow.Cells[colRoomName.Index].Value) ?? "";
        try
        {
            _repository.DeleteRoom(name);
            _rooms.RemoveAll(r => r.Name == name);
            _blocks.RemoveAll(b => b.Room == name);
            RefreshTables();
            _notify("Selected room removed.");
        }
        catch (Exception ex) { _notify("Could not remove room: " + ex.Message); }
    }

    private void btnAddSlot_Click(object? sender, EventArgs e)
    {
        var date = dtpSlotDate.Value.Date;
        var start = dtpSlotStart.Value.TimeOfDay;
        var end = dtpSlotEnd.Value.TimeOfDay;
        if (end <= start) { _notify("End time must be later than start time."); return; }
        if (_slots.Any(s => s.Date.Date == date && start < s.End && end > s.Start)) { _notify("This time overlaps an existing slot."); return; }
        _slots.Add((date, start, end));
        _slots.Sort((a, b) => a.Date != b.Date ? a.Date.CompareTo(b.Date) : a.Start.CompareTo(b.Start));
        RefreshTables();
        _notify("Date and time slot added.");
    }

    private void dtpBlockDate_ValueChanged(object? sender, EventArgs e) => RefreshTables();

    private void btnMarkUnavailable_Click(object? sender, EventArgs e)
    {
        if (cboRoom.SelectedItem is null || cboSlot.SelectedItem is null) { _notify("Choose a room and an available time slot."); return; }
        var room = cboRoom.SelectedItem.ToString()!;
        var slotText = cboSlot.SelectedItem.ToString()!;
        var date = dtpBlockDate.Value.Date;
        var slot = _slots.First(s => s.Date.Date == date && SlotText(s.Start, s.End) == slotText);
        if (_blocks.Any(b => b.Room == room && b.Date.Date == date && b.Start == slot.Start && b.End == slot.End))
        { _notify("This room is already unavailable in that slot."); return; }
        _blocks.Add((room, date, slot.Start, slot.End));
        RefreshTables();
        _notify("Room marked as unavailable.");
    }
}
