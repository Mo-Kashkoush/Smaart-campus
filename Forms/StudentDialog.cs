namespace SmartCampus;

public partial class StudentDialog : Form
{
    private readonly Student? _existing;
    private readonly int _nextId;

    /// <summary>The student typed in by the user (set when Save is pressed).</summary>
    public Student? Result { get; private set; }

    public StudentDialog() : this(null, 0) { }

    public StudentDialog(Student? existing, int nextId)
    {
        InitializeComponent();
        _existing = existing;
        _nextId = nextId;
        Theme.Apply(this);

        Text = existing is null ? "Add student" : "Edit student";
        txtName.Text = existing?.Name ?? "";
        cboDepartment.Text = existing?.Department ?? "Computer Science";
        txtEmail.Text = existing?.Email ?? "";
        cboYear.Text = existing?.Year ?? "Year 1";
    }

    private void btnSave_Click(object? sender, EventArgs e)
    {
        errorProvider.Clear();
        var valid = true;
        if (string.IsNullOrWhiteSpace(txtName.Text)) { errorProvider.SetError(txtName, "Name is required."); valid = false; }
        if (!txtEmail.Text.Contains('@') || !txtEmail.Text.Contains('.')) { errorProvider.SetError(txtEmail, "Enter a valid email address."); valid = false; }
        if (!valid) return;

        Result = new Student
        {
            Id = _existing?.Id ?? _nextId,
            Name = txtName.Text.Trim(),
            Department = cboDepartment.Text.Trim(),
            Email = txtEmail.Text.Trim(),
            Year = cboYear.Text.Trim(),
            Status = _existing?.Status ?? "Active"
        };
        DialogResult = DialogResult.OK;
    }
}
