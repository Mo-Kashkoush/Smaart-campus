using System.Globalization;

namespace SmartCampus;

public partial class ResourcesForm : Form
{
    private static readonly CultureInfo Inv = CultureInfo.InvariantCulture;

    private readonly ICampusRepository _repository;
    private readonly List<CampusRoom> _rooms;
    private readonly List<(DateTime Date, TimeSpan Start, TimeSpan End)> _slots;
    private readonly List<(string Room, DateTime Date, TimeSpan Start, TimeSpan End)> _blocks;

    private sealed record SlotItem(TimeSpan Start, TimeSpan End)
    {
        public override string ToString() => $"{Fmt(Start)} - {Fmt(End)}";
    }

    // Used by the Visual Studio designer.
    public ResourcesForm() : this(new DemoCampusRepository(), [], [], []) { }

    public ResourcesForm(
        ICampusRepository repository,
        List<CampusRoom> rooms,
        List<(DateTime Date, TimeSpan Start, TimeSpan End)> slots,
        List<(string Room, DateTime Date, TimeSpan Start, TimeSpan End)> blocks)
    {
        InitializeComponent();
        _repository = repository; _rooms = rooms; _slots = slots; _blocks = blocks;

        Theme.Apply(this);
        dtpSlotDate.MinDate = DateTime.Today;
        dtpSlotStart.Value = DateTime.Today.AddHours(9);
        dtpSlotEnd.Value = DateTime.Today.AddHours(11);
        RefreshAll();
    }

    private static string Fmt(TimeSpan t) => DateTime.Today.Add(t).ToString("hh:mm tt", Inv);

    private void Warn(string message) => MessageBox.Show(this, message, "Resources Management", MessageBoxButtons.OK, MessageBoxIcon.Information);

    // ---- Rooms ------------------------------------------------------------
    private void btnAddRoom_Click(object? sender, EventArgs e)
    {
        var name = txtRoomName.Text.Trim();
        if (name.Length == 0) { Warn("Enter the room name."); return; }
        if (_rooms.Any(r => r.Name.Equals(name, StringComparison.OrdinalIgnoreCase))) { Warn("A room with this name already exists."); return; }
        var room = new CampusRoom(name, "Main campus", (int)nudCapacity.Value, "Available");
        try { _repository.SaveRoom(room); _rooms.Add(room); txtRoomName.Clear(); RefreshAll(); }
        catch (Exception ex) { Warn("Could not save room: " + ex.Message); }
    }

    private void btnRemoveRoom_Click(object? sender, EventArgs e)
    {
        if (dgvRooms.CurrentRow is null) { Warn("Select a room to remove."); return; }
        var name = Convert.ToString(dgvRooms.CurrentRow.Cells[colRoomName.Index].Value) ?? "";
        try { _repository.DeleteRoom(name); _rooms.RemoveAll(r => r.Name == name); _blocks.RemoveAll(b => b.Room == name); RefreshAll(); }
        catch (Exception ex) { Warn("Could not remove room: " + ex.Message); }
    }

    // ---- Slots ------------------------------------------------------------
    private void btnAddSlot_Click(object? sender, EventArgs e)
    {
        var date = dtpSlotDate.Value.Date;
        var start = dtpSlotStart.Value.TimeOfDay;
        var end = dtpSlotEnd.Value.TimeOfDay;
        if (end <= start) { Warn("End time must be later than start time."); return; }
        if (_slots.Any(s => s.Date.Date == date && start < s.End && end > s.Start)) { Warn("This time overlaps an existing slot."); return; }
        _slots.Add((date, start, end));
        _slots.Sort((a, b) => a.Date != b.Date ? a.Date.CompareTo(b.Date) : a.Start.CompareTo(b.Start));
        RefreshAll();
    }

    // ---- Unavailability ---------------------------------------------------
    private void cboDate_Format(object? sender, ListControlConvertEventArgs e)
    {
        if (e.ListItem is DateTime d) e.Value = d.ToString("dd/MM/yyyy", Inv);
    }

    private void cboDate_SelectedIndexChanged(object? sender, EventArgs e) => RefreshSlotPicker();

    private void btnMark_Click(object? sender, EventArgs e)
    {
        if (cboRoom.SelectedItem is not string room || cboDate.SelectedItem is not DateTime date || cboSlot.SelectedItem is not SlotItem slot)
        { Warn("Choose a room, a date and a time slot first."); return; }
        if (_blocks.Any(b => b.Room == room && b.Date.Date == date.Date && b.Start == slot.Start && b.End == slot.End))
        { Warn("This room is already unavailable in that slot."); return; }
        _blocks.Add((room, date.Date, slot.Start, slot.End));
        RefreshAll();
    }

    // ---- Refresh ----------------------------------------------------------
    private void RefreshAll()
    {
        dgvRooms.Rows.Clear();
        foreach (var r in _rooms) dgvRooms.Rows.Add(r.Name, r.Capacity);

        dgvSlots.Rows.Clear();
        foreach (var s in _slots) dgvSlots.Rows.Add(s.Date.ToString("dd/MM/yyyy", Inv), Fmt(s.Start), Fmt(s.End));

        dgvBlocks.Rows.Clear();
        foreach (var b in _blocks) dgvBlocks.Rows.Add(b.Room, b.Date.ToString("dd/MM/yyyy", Inv), $"{Fmt(b.Start)} - {Fmt(b.End)}");

        var oldRoom = cboRoom.SelectedItem as string;
        cboRoom.Items.Clear();
        foreach (var r in _rooms) cboRoom.Items.Add(r.Name);
        if (oldRoom is not null && cboRoom.Items.Contains(oldRoom)) cboRoom.SelectedItem = oldRoom;
        else if (cboRoom.Items.Count > 0) cboRoom.SelectedIndex = 0;

        var oldDate = cboDate.SelectedItem as DateTime?;
        cboDate.Items.Clear();
        foreach (var d in _slots.Select(s => s.Date.Date).Distinct().OrderBy(d => d)) cboDate.Items.Add(d);
        if (oldDate is not null && cboDate.Items.Contains(oldDate.Value)) cboDate.SelectedItem = oldDate.Value;
        else if (cboDate.Items.Count > 0) cboDate.SelectedIndex = 0;

        RefreshSlotPicker();
    }

    private void RefreshSlotPicker()
    {
        var old = cboSlot.SelectedItem as SlotItem;
        cboSlot.Items.Clear();
        if (cboDate.SelectedItem is DateTime date)
            foreach (var s in _slots.Where(s => s.Date.Date == date.Date).OrderBy(s => s.Start)) cboSlot.Items.Add(new SlotItem(s.Start, s.End));
        if (old is not null && cboSlot.Items.Contains(old)) cboSlot.SelectedItem = old;
        else if (cboSlot.Items.Count > 0) cboSlot.SelectedIndex = 0;
    }
}
