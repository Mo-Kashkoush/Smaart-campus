namespace SmartCampus;

public partial class AttendancePage : UserControl
{
    public AttendancePage()
    {
        InitializeComponent();
        Theme.Apply(this);
        colStatus.DefaultCellStyle.Font = new Font("Segoe UI Semibold", 9.5F, FontStyle.Bold);
    }

    public void Bind(ICampusRepository repository)
    {
        dgvAttendance.Rows.Clear();
        foreach (var a in repository.GetAttendance()) dgvAttendance.Rows.Add(a.Student, a.Course, a.Time, a.Status);
    }
}
