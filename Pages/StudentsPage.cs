namespace SmartCampus;

public partial class StudentsPage : UserControl
{
    private ICampusRepository _repository = null!;
    private Action<string> _notify = _ => { };

    public StudentsPage()
    {
        InitializeComponent();
        Theme.Apply(this);
    }

    public void Bind(ICampusRepository repository, Action<string> notify)
    {
        _repository = repository;
        _notify = notify;
        RefreshGrid();
    }

    private void RefreshGrid()
    {
        if (_repository is null) return;
        var search = txtSearch.Text;
        dgvStudents.Rows.Clear();
        foreach (var s in _repository.GetStudents().Where(s => string.Join(" ", s.Id, s.Name, s.Department, s.Email).Contains(search, StringComparison.OrdinalIgnoreCase)))
            dgvStudents.Rows.Add(s.Id, s.Name, s.Department, s.Email, s.Year, s.Status);
    }

    private void txtSearch_TextChanged(object? sender, EventArgs e) => RefreshGrid();

    private void btnAddStudent_Click(object? sender, EventArgs e) => OpenDialog(null);

    private void dgvStudents_CellDoubleClick(object? sender, DataGridViewCellEventArgs e)
    {
        if (e.RowIndex < 0 || e.ColumnIndex == colEdit.Index || e.ColumnIndex == colDelete.Index) return;
        var student = FindStudent(e.RowIndex);
        if (student is not null) OpenDialog(student);
    }

    private void dgvStudents_CellContentClick(object? sender, DataGridViewCellEventArgs e)
    {
        if (e.RowIndex < 0) return;
        if (e.ColumnIndex != colEdit.Index && e.ColumnIndex != colDelete.Index) return;
        var student = FindStudent(e.RowIndex);
        if (student is null) return;

        if (e.ColumnIndex == colEdit.Index) { OpenDialog(student); return; }

        var answer = MessageBox.Show(FindForm(), $"Delete {student.Name}?", "Delete student", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
        if (answer != DialogResult.Yes) return;
        try { _repository.Delete(student.Id); RefreshGrid(); _notify("Student record deleted."); }
        catch (Exception ex) { _notify("Could not delete: " + ex.Message); }
    }

    private Student? FindStudent(int rowIndex)
    {
        var id = Convert.ToInt32(dgvStudents.Rows[rowIndex].Cells[colId.Index].Value);
        return _repository.GetStudents().FirstOrDefault(x => x.Id == id);
    }

    private void OpenDialog(Student? existing)
    {
        var nextId = _repository.GetStudents().Select(s => s.Id).DefaultIfEmpty(24000).Max() + 1;
        using var dialog = new StudentDialog(existing, nextId);
        if (dialog.ShowDialog(FindForm()) != DialogResult.OK || dialog.Result is null) return;
        try
        {
            _repository.Save(dialog.Result);
            RefreshGrid();
            _notify(existing is null ? "Student added successfully." : "Student updated successfully.");
        }
        catch (Exception ex) { _notify("Could not save: " + ex.Message); }
    }
}
