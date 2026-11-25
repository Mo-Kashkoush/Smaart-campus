#nullable disable
namespace SmartCampus
{
    partial class DashboardPage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            //
            this.tlpRoot = new System.Windows.Forms.TableLayoutPanel();
            this.lblHeading = new System.Windows.Forms.Label();
            this.tlpStats = new System.Windows.Forms.TableLayoutPanel();
            this.cardStudents = new SmartCampus.CardPanel();
            this.lblStudentsTitle = new System.Windows.Forms.Label();
            this.lblStudentsValue = new System.Windows.Forms.Label();
            this.lblStudentsDelta = new System.Windows.Forms.Label();
            this.lblStudentsGlyph = new System.Windows.Forms.Label();
            this.cardOnCampus = new SmartCampus.CardPanel();
            this.lblOnCampusTitle = new System.Windows.Forms.Label();
            this.lblOnCampusValue = new System.Windows.Forms.Label();
            this.lblOnCampusDelta = new System.Windows.Forms.Label();
            this.lblOnCampusGlyph = new System.Windows.Forms.Label();
            this.cardAttendance = new SmartCampus.CardPanel();
            this.lblAttendanceTitle = new System.Windows.Forms.Label();
            this.lblAttendanceValue = new System.Windows.Forms.Label();
            this.lblAttendanceDelta = new System.Windows.Forms.Label();
            this.lblAttendanceGlyph = new System.Windows.Forms.Label();
            this.cardRooms = new SmartCampus.CardPanel();
            this.lblRoomsTitle = new System.Windows.Forms.Label();
            this.lblRoomsValue = new System.Windows.Forms.Label();
            this.lblRoomsDelta = new System.Windows.Forms.Label();
            this.lblRoomsGlyph = new System.Windows.Forms.Label();
            this.tlpMiddle = new System.Windows.Forms.TableLayoutPanel();
            this.cardChart = new SmartCampus.CardPanel();
            this.lblChartTitle = new System.Windows.Forms.Label();
            this.lblChartSub = new System.Windows.Forms.Label();
            this.chartWeekly = new SmartCampus.AttendanceChart();
            this.cardActivity = new SmartCampus.CardPanel();
            this.lblActivityTitle = new System.Windows.Forms.Label();
            this.lblActivityCaption = new System.Windows.Forms.Label();
            this.dotActivity1 = new System.Windows.Forms.Panel();
            this.lblActivityName1 = new System.Windows.Forms.Label();
            this.lblActivityDesc1 = new System.Windows.Forms.Label();
            this.lblActivityTime1 = new System.Windows.Forms.Label();
            this.dotActivity2 = new System.Windows.Forms.Panel();
            this.lblActivityName2 = new System.Windows.Forms.Label();
            this.lblActivityDesc2 = new System.Windows.Forms.Label();
            this.lblActivityTime2 = new System.Windows.Forms.Label();
            this.dotActivity3 = new System.Windows.Forms.Panel();
            this.lblActivityName3 = new System.Windows.Forms.Label();
            this.lblActivityDesc3 = new System.Windows.Forms.Label();
            this.lblActivityTime3 = new System.Windows.Forms.Label();
            this.dotActivity4 = new System.Windows.Forms.Panel();
            this.lblActivityName4 = new System.Windows.Forms.Label();
            this.lblActivityDesc4 = new System.Windows.Forms.Label();
            this.lblActivityTime4 = new System.Windows.Forms.Label();
            this.pnlTodayHeader = new System.Windows.Forms.Panel();
            this.lblToday = new System.Windows.Forms.Label();
            this.lblLive = new System.Windows.Forms.Label();
            this.dgvToday = new System.Windows.Forms.DataGridView();
            this.colTodayStudent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTodayCourse = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTodayTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTodayStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tmrCounters = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvToday)).BeginInit();
            this.tlpRoot.SuspendLayout();
            this.tlpStats.SuspendLayout();
            this.cardStudents.SuspendLayout();
            this.cardOnCampus.SuspendLayout();
            this.cardAttendance.SuspendLayout();
            this.cardRooms.SuspendLayout();
            this.tlpMiddle.SuspendLayout();
            this.cardChart.SuspendLayout();
            this.cardActivity.SuspendLayout();
            this.dotActivity1.SuspendLayout();
            this.dotActivity2.SuspendLayout();
            this.dotActivity3.SuspendLayout();
            this.dotActivity4.SuspendLayout();
            this.pnlTodayHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpRoot
            // 
            this.tlpRoot.ColumnCount = 1;
            this.tlpRoot.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpRoot.RowCount = 5;
            this.tlpRoot.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 56F));
            this.tlpRoot.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 140F));
            this.tlpRoot.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 316F));
            this.tlpRoot.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 48F));
            this.tlpRoot.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpRoot.Controls.Add(this.lblHeading, 0, 0);
            this.tlpRoot.Controls.Add(this.tlpStats, 0, 1);
            this.tlpRoot.Controls.Add(this.tlpMiddle, 0, 2);
            this.tlpRoot.Controls.Add(this.pnlTodayHeader, 0, 3);
            this.tlpRoot.Controls.Add(this.dgvToday, 0, 4);
            this.tlpRoot.Name = "tlpRoot";
            this.tlpRoot.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpRoot.Location = new System.Drawing.Point(0, 0);
            this.tlpRoot.Size = new System.Drawing.Size(1340, 780);
            // 
            // lblHeading
            // 
            this.lblHeading.Name = "lblHeading";
            this.lblHeading.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblHeading.Font = new System.Drawing.Font("Segoe UI Semibold", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblHeading.ForeColor = System.Drawing.Color.FromArgb(20, 20, 20);
            this.lblHeading.Margin = new System.Windows.Forms.Padding(0, 0, 0, 0);
            this.lblHeading.Text = "Dashboard";
            this.lblHeading.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tlpStats
            // 
            this.tlpStats.ColumnCount = 4;
            this.tlpStats.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpStats.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpStats.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpStats.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpStats.RowCount = 1;
            this.tlpStats.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpStats.Controls.Add(this.cardStudents, 0, 0);
            this.tlpStats.Controls.Add(this.cardOnCampus, 1, 0);
            this.tlpStats.Controls.Add(this.cardAttendance, 2, 0);
            this.tlpStats.Controls.Add(this.cardRooms, 3, 0);
            this.tlpStats.Name = "tlpStats";
            this.tlpStats.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpStats.Margin = new System.Windows.Forms.Padding(0, 0, 0, 0);
            this.tlpStats.Size = new System.Drawing.Size(1340, 140);
            // 
            // cardStudents
            // 
            this.cardStudents.Controls.Add(this.lblStudentsTitle);
            this.cardStudents.Controls.Add(this.lblStudentsValue);
            this.cardStudents.Controls.Add(this.lblStudentsDelta);
            this.cardStudents.Controls.Add(this.lblStudentsGlyph);
            this.cardStudents.Name = "cardStudents";
            this.cardStudents.Location = new System.Drawing.Point(0, 0);
            this.cardStudents.Size = new System.Drawing.Size(320, 128);
            this.cardStudents.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cardStudents.Margin = new System.Windows.Forms.Padding(0, 6, 12, 6);
            // 
            // lblStudentsTitle
            // 
            this.lblStudentsTitle.Name = "lblStudentsTitle";
            this.lblStudentsTitle.AutoSize = true;
            this.lblStudentsTitle.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblStudentsTitle.ForeColor = System.Drawing.Color.FromArgb(85, 85, 85);
            this.lblStudentsTitle.Location = new System.Drawing.Point(16, 14);
            this.lblStudentsTitle.Text = "TOTAL STUDENTS";
            // 
            // lblStudentsValue
            // 
            this.lblStudentsValue.Name = "lblStudentsValue";
            this.lblStudentsValue.AutoSize = true;
            this.lblStudentsValue.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblStudentsValue.ForeColor = System.Drawing.Color.FromArgb(20, 20, 20);
            this.lblStudentsValue.Location = new System.Drawing.Point(15, 36);
            this.lblStudentsValue.Text = "0";
            // 
            // lblStudentsDelta
            // 
            this.lblStudentsDelta.Name = "lblStudentsDelta";
            this.lblStudentsDelta.AutoSize = true;
            this.lblStudentsDelta.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblStudentsDelta.ForeColor = System.Drawing.Color.FromArgb(35, 35, 35);
            this.lblStudentsDelta.Location = new System.Drawing.Point(16, 94);
            this.lblStudentsDelta.Text = "↑ 8.2%";
            // 
            // lblStudentsGlyph
            // 
            this.lblStudentsGlyph.Name = "lblStudentsGlyph";
            this.lblStudentsGlyph.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            this.lblStudentsGlyph.BackColor = System.Drawing.Color.FromArgb(232, 232, 232);
            this.lblStudentsGlyph.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblStudentsGlyph.ForeColor = System.Drawing.Color.FromArgb(20, 20, 20);
            this.lblStudentsGlyph.Location = new System.Drawing.Point(265, 38);
            this.lblStudentsGlyph.Size = new System.Drawing.Size(38, 38);
            this.lblStudentsGlyph.Text = "♙";
            this.lblStudentsGlyph.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cardOnCampus
            // 
            this.cardOnCampus.Controls.Add(this.lblOnCampusTitle);
            this.cardOnCampus.Controls.Add(this.lblOnCampusValue);
            this.cardOnCampus.Controls.Add(this.lblOnCampusDelta);
            this.cardOnCampus.Controls.Add(this.lblOnCampusGlyph);
            this.cardOnCampus.Name = "cardOnCampus";
            this.cardOnCampus.Location = new System.Drawing.Point(0, 0);
            this.cardOnCampus.Size = new System.Drawing.Size(320, 128);
            this.cardOnCampus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cardOnCampus.Margin = new System.Windows.Forms.Padding(0, 6, 12, 6);
            // 
            // lblOnCampusTitle
            // 
            this.lblOnCampusTitle.Name = "lblOnCampusTitle";
            this.lblOnCampusTitle.AutoSize = true;
            this.lblOnCampusTitle.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblOnCampusTitle.ForeColor = System.Drawing.Color.FromArgb(85, 85, 85);
            this.lblOnCampusTitle.Location = new System.Drawing.Point(16, 14);
            this.lblOnCampusTitle.Text = "ON CAMPUS";
            // 
            // lblOnCampusValue
            // 
            this.lblOnCampusValue.Name = "lblOnCampusValue";
            this.lblOnCampusValue.AutoSize = true;
            this.lblOnCampusValue.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblOnCampusValue.ForeColor = System.Drawing.Color.FromArgb(20, 20, 20);
            this.lblOnCampusValue.Location = new System.Drawing.Point(15, 36);
            this.lblOnCampusValue.Text = "0";
            // 
            // lblOnCampusDelta
            // 
            this.lblOnCampusDelta.Name = "lblOnCampusDelta";
            this.lblOnCampusDelta.AutoSize = true;
            this.lblOnCampusDelta.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblOnCampusDelta.ForeColor = System.Drawing.Color.FromArgb(35, 35, 35);
            this.lblOnCampusDelta.Location = new System.Drawing.Point(16, 94);
            this.lblOnCampusDelta.Text = "72.9% today";
            // 
            // lblOnCampusGlyph
            // 
            this.lblOnCampusGlyph.Name = "lblOnCampusGlyph";
            this.lblOnCampusGlyph.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            this.lblOnCampusGlyph.BackColor = System.Drawing.Color.FromArgb(232, 232, 232);
            this.lblOnCampusGlyph.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblOnCampusGlyph.ForeColor = System.Drawing.Color.FromArgb(35, 35, 35);
            this.lblOnCampusGlyph.Location = new System.Drawing.Point(265, 38);
            this.lblOnCampusGlyph.Size = new System.Drawing.Size(38, 38);
            this.lblOnCampusGlyph.Text = "⌂";
            this.lblOnCampusGlyph.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cardAttendance
            // 
            this.cardAttendance.Controls.Add(this.lblAttendanceTitle);
            this.cardAttendance.Controls.Add(this.lblAttendanceValue);
            this.cardAttendance.Controls.Add(this.lblAttendanceDelta);
            this.cardAttendance.Controls.Add(this.lblAttendanceGlyph);
            this.cardAttendance.Name = "cardAttendance";
            this.cardAttendance.Location = new System.Drawing.Point(0, 0);
            this.cardAttendance.Size = new System.Drawing.Size(320, 128);
            this.cardAttendance.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cardAttendance.Margin = new System.Windows.Forms.Padding(0, 6, 12, 6);
            // 
            // lblAttendanceTitle
            // 
            this.lblAttendanceTitle.Name = "lblAttendanceTitle";
            this.lblAttendanceTitle.AutoSize = true;
            this.lblAttendanceTitle.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblAttendanceTitle.ForeColor = System.Drawing.Color.FromArgb(85, 85, 85);
            this.lblAttendanceTitle.Location = new System.Drawing.Point(16, 14);
            this.lblAttendanceTitle.Text = "ATTENDANCE";
            // 
            // lblAttendanceValue
            // 
            this.lblAttendanceValue.Name = "lblAttendanceValue";
            this.lblAttendanceValue.AutoSize = true;
            this.lblAttendanceValue.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblAttendanceValue.ForeColor = System.Drawing.Color.FromArgb(20, 20, 20);
            this.lblAttendanceValue.Location = new System.Drawing.Point(15, 36);
            this.lblAttendanceValue.Text = "0";
            // 
            // lblAttendanceDelta
            // 
            this.lblAttendanceDelta.Name = "lblAttendanceDelta";
            this.lblAttendanceDelta.AutoSize = true;
            this.lblAttendanceDelta.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblAttendanceDelta.ForeColor = System.Drawing.Color.FromArgb(35, 35, 35);
            this.lblAttendanceDelta.Location = new System.Drawing.Point(16, 94);
            this.lblAttendanceDelta.Text = "↑ 2.4%";
            // 
            // lblAttendanceGlyph
            // 
            this.lblAttendanceGlyph.Name = "lblAttendanceGlyph";
            this.lblAttendanceGlyph.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            this.lblAttendanceGlyph.BackColor = System.Drawing.Color.FromArgb(232, 232, 232);
            this.lblAttendanceGlyph.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblAttendanceGlyph.ForeColor = System.Drawing.Color.FromArgb(75, 75, 75);
            this.lblAttendanceGlyph.Location = new System.Drawing.Point(265, 38);
            this.lblAttendanceGlyph.Size = new System.Drawing.Size(38, 38);
            this.lblAttendanceGlyph.Text = "◷";
            this.lblAttendanceGlyph.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cardRooms
            // 
            this.cardRooms.Controls.Add(this.lblRoomsTitle);
            this.cardRooms.Controls.Add(this.lblRoomsValue);
            this.cardRooms.Controls.Add(this.lblRoomsDelta);
            this.cardRooms.Controls.Add(this.lblRoomsGlyph);
            this.cardRooms.Name = "cardRooms";
            this.cardRooms.Location = new System.Drawing.Point(0, 0);
            this.cardRooms.Size = new System.Drawing.Size(320, 128);
            this.cardRooms.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cardRooms.Margin = new System.Windows.Forms.Padding(0, 6, 0, 6);
            // 
            // lblRoomsTitle
            // 
            this.lblRoomsTitle.Name = "lblRoomsTitle";
            this.lblRoomsTitle.AutoSize = true;
            this.lblRoomsTitle.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblRoomsTitle.ForeColor = System.Drawing.Color.FromArgb(85, 85, 85);
            this.lblRoomsTitle.Location = new System.Drawing.Point(16, 14);
            this.lblRoomsTitle.Text = "ACTIVE ROOMS";
            // 
            // lblRoomsValue
            // 
            this.lblRoomsValue.Name = "lblRoomsValue";
            this.lblRoomsValue.AutoSize = true;
            this.lblRoomsValue.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblRoomsValue.ForeColor = System.Drawing.Color.FromArgb(20, 20, 20);
            this.lblRoomsValue.Location = new System.Drawing.Point(15, 36);
            this.lblRoomsValue.Text = "0";
            // 
            // lblRoomsDelta
            // 
            this.lblRoomsDelta.Name = "lblRoomsDelta";
            this.lblRoomsDelta.AutoSize = true;
            this.lblRoomsDelta.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblRoomsDelta.ForeColor = System.Drawing.Color.FromArgb(35, 35, 35);
            this.lblRoomsDelta.Location = new System.Drawing.Point(16, 94);
            this.lblRoomsDelta.Text = "6 available";
            // 
            // lblRoomsGlyph
            // 
            this.lblRoomsGlyph.Name = "lblRoomsGlyph";
            this.lblRoomsGlyph.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            this.lblRoomsGlyph.BackColor = System.Drawing.Color.FromArgb(232, 232, 232);
            this.lblRoomsGlyph.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblRoomsGlyph.ForeColor = System.Drawing.Color.FromArgb(100, 100, 100);
            this.lblRoomsGlyph.Location = new System.Drawing.Point(265, 38);
            this.lblRoomsGlyph.Size = new System.Drawing.Size(38, 38);
            this.lblRoomsGlyph.Text = "▦";
            this.lblRoomsGlyph.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tlpMiddle
            // 
            this.tlpMiddle.ColumnCount = 2;
            this.tlpMiddle.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 62F));
            this.tlpMiddle.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 38F));
            this.tlpMiddle.RowCount = 1;
            this.tlpMiddle.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMiddle.Controls.Add(this.cardChart, 0, 0);
            this.tlpMiddle.Controls.Add(this.cardActivity, 1, 0);
            this.tlpMiddle.Name = "tlpMiddle";
            this.tlpMiddle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpMiddle.Margin = new System.Windows.Forms.Padding(0, 0, 0, 0);
            this.tlpMiddle.Size = new System.Drawing.Size(1340, 316);
            // 
            // cardChart
            // 
            this.cardChart.Controls.Add(this.lblChartTitle);
            this.cardChart.Controls.Add(this.lblChartSub);
            this.cardChart.Controls.Add(this.chartWeekly);
            this.cardChart.Name = "cardChart";
            this.cardChart.Location = new System.Drawing.Point(0, 0);
            this.cardChart.Size = new System.Drawing.Size(800, 304);
            this.cardChart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cardChart.Margin = new System.Windows.Forms.Padding(0, 6, 12, 6);
            // 
            // lblChartTitle
            // 
            this.lblChartTitle.Name = "lblChartTitle";
            this.lblChartTitle.AutoSize = true;
            this.lblChartTitle.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblChartTitle.ForeColor = System.Drawing.Color.FromArgb(20, 20, 20);
            this.lblChartTitle.Location = new System.Drawing.Point(20, 16);
            this.lblChartTitle.Text = "Weekly attendance";
            // 
            // lblChartSub
            // 
            this.lblChartSub.Name = "lblChartSub";
            this.lblChartSub.AutoSize = true;
            this.lblChartSub.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblChartSub.ForeColor = System.Drawing.Color.FromArgb(85, 85, 85);
            this.lblChartSub.Location = new System.Drawing.Point(20, 46);
            this.lblChartSub.Text = "Weekly check-ins across all departments";
            // 
            // chartWeekly
            // 
            this.chartWeekly.Name = "chartWeekly";
            this.chartWeekly.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            this.chartWeekly.BackColor = System.Drawing.Color.White;
            this.chartWeekly.Location = new System.Drawing.Point(19, 74);
            this.chartWeekly.Size = new System.Drawing.Size(762, 218);
            // 
            // cardActivity
            // 
            this.cardActivity.Controls.Add(this.lblActivityTitle);
            this.cardActivity.Controls.Add(this.lblActivityCaption);
            this.cardActivity.Controls.Add(this.dotActivity1);
            this.cardActivity.Controls.Add(this.lblActivityName1);
            this.cardActivity.Controls.Add(this.lblActivityDesc1);
            this.cardActivity.Controls.Add(this.lblActivityTime1);
            this.cardActivity.Controls.Add(this.dotActivity2);
            this.cardActivity.Controls.Add(this.lblActivityName2);
            this.cardActivity.Controls.Add(this.lblActivityDesc2);
            this.cardActivity.Controls.Add(this.lblActivityTime2);
            this.cardActivity.Controls.Add(this.dotActivity3);
            this.cardActivity.Controls.Add(this.lblActivityName3);
            this.cardActivity.Controls.Add(this.lblActivityDesc3);
            this.cardActivity.Controls.Add(this.lblActivityTime3);
            this.cardActivity.Controls.Add(this.dotActivity4);
            this.cardActivity.Controls.Add(this.lblActivityName4);
            this.cardActivity.Controls.Add(this.lblActivityDesc4);
            this.cardActivity.Controls.Add(this.lblActivityTime4);
            this.cardActivity.Name = "cardActivity";
            this.cardActivity.Location = new System.Drawing.Point(0, 0);
            this.cardActivity.Size = new System.Drawing.Size(490, 304);
            this.cardActivity.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cardActivity.Margin = new System.Windows.Forms.Padding(0, 6, 0, 6);
            // 
            // lblActivityTitle
            // 
            this.lblActivityTitle.Name = "lblActivityTitle";
            this.lblActivityTitle.AutoSize = true;
            this.lblActivityTitle.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblActivityTitle.ForeColor = System.Drawing.Color.FromArgb(20, 20, 20);
            this.lblActivityTitle.Location = new System.Drawing.Point(18, 16);
            this.lblActivityTitle.Text = "Recent activity";
            // 
            // lblActivityCaption
            // 
            this.lblActivityCaption.Name = "lblActivityCaption";
            this.lblActivityCaption.AutoSize = true;
            this.lblActivityCaption.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblActivityCaption.ForeColor = System.Drawing.Color.FromArgb(85, 85, 85);
            this.lblActivityCaption.Location = new System.Drawing.Point(18, 46);
            this.lblActivityCaption.Text = "LATEST ACTIVITY";
            // 
            // dotActivity1
            // 
            this.dotActivity1.Name = "dotActivity1";
            this.dotActivity1.BackColor = System.Drawing.Color.FromArgb(20, 20, 20);
            this.dotActivity1.Location = new System.Drawing.Point(19, 86);
            this.dotActivity1.Size = new System.Drawing.Size(8, 8);
            // 
            // lblActivityName1
            // 
            this.lblActivityName1.Name = "lblActivityName1";
            this.lblActivityName1.AutoEllipsis = true;
            this.lblActivityName1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblActivityName1.ForeColor = System.Drawing.Color.FromArgb(20, 20, 20);
            this.lblActivityName1.Location = new System.Drawing.Point(36, 78);
            this.lblActivityName1.Size = new System.Drawing.Size(340, 24);
            this.lblActivityName1.Text = "Mariam Hassan";
            this.lblActivityName1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblActivityName1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            // 
            // lblActivityDesc1
            // 
            this.lblActivityDesc1.Name = "lblActivityDesc1";
            this.lblActivityDesc1.AutoEllipsis = true;
            this.lblActivityDesc1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblActivityDesc1.ForeColor = System.Drawing.Color.FromArgb(85, 85, 85);
            this.lblActivityDesc1.Location = new System.Drawing.Point(36, 102);
            this.lblActivityDesc1.Size = new System.Drawing.Size(440, 22);
            this.lblActivityDesc1.Text = "Checked in · CS Lab 204";
            this.lblActivityDesc1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblActivityDesc1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            // 
            // lblActivityTime1
            // 
            this.lblActivityTime1.Name = "lblActivityTime1";
            this.lblActivityTime1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            this.lblActivityTime1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblActivityTime1.ForeColor = System.Drawing.Color.FromArgb(85, 85, 85);
            this.lblActivityTime1.Location = new System.Drawing.Point(390, 78);
            this.lblActivityTime1.Size = new System.Drawing.Size(82, 24);
            this.lblActivityTime1.Text = "09:04 AM";
            this.lblActivityTime1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dotActivity2
            // 
            this.dotActivity2.Name = "dotActivity2";
            this.dotActivity2.BackColor = System.Drawing.Color.FromArgb(35, 35, 35);
            this.dotActivity2.Location = new System.Drawing.Point(19, 140);
            this.dotActivity2.Size = new System.Drawing.Size(8, 8);
            // 
            // lblActivityName2
            // 
            this.lblActivityName2.Name = "lblActivityName2";
            this.lblActivityName2.AutoEllipsis = true;
            this.lblActivityName2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblActivityName2.ForeColor = System.Drawing.Color.FromArgb(20, 20, 20);
            this.lblActivityName2.Location = new System.Drawing.Point(36, 132);
            this.lblActivityName2.Size = new System.Drawing.Size(340, 24);
            this.lblActivityName2.Text = "Room 301";
            this.lblActivityName2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblActivityName2.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            // 
            // lblActivityDesc2
            // 
            this.lblActivityDesc2.Name = "lblActivityDesc2";
            this.lblActivityDesc2.AutoEllipsis = true;
            this.lblActivityDesc2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblActivityDesc2.ForeColor = System.Drawing.Color.FromArgb(85, 85, 85);
            this.lblActivityDesc2.Location = new System.Drawing.Point(36, 156);
            this.lblActivityDesc2.Size = new System.Drawing.Size(440, 22);
            this.lblActivityDesc2.Text = "Now available for booking";
            this.lblActivityDesc2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblActivityDesc2.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            // 
            // lblActivityTime2
            // 
            this.lblActivityTime2.Name = "lblActivityTime2";
            this.lblActivityTime2.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            this.lblActivityTime2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblActivityTime2.ForeColor = System.Drawing.Color.FromArgb(85, 85, 85);
            this.lblActivityTime2.Location = new System.Drawing.Point(390, 132);
            this.lblActivityTime2.Size = new System.Drawing.Size(82, 24);
            this.lblActivityTime2.Text = "08:52 AM";
            this.lblActivityTime2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dotActivity3
            // 
            this.dotActivity3.Name = "dotActivity3";
            this.dotActivity3.BackColor = System.Drawing.Color.FromArgb(75, 75, 75);
            this.dotActivity3.Location = new System.Drawing.Point(19, 194);
            this.dotActivity3.Size = new System.Drawing.Size(8, 8);
            // 
            // lblActivityName3
            // 
            this.lblActivityName3.Name = "lblActivityName3";
            this.lblActivityName3.AutoEllipsis = true;
            this.lblActivityName3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblActivityName3.ForeColor = System.Drawing.Color.FromArgb(20, 20, 20);
            this.lblActivityName3.Location = new System.Drawing.Point(36, 186);
            this.lblActivityName3.Size = new System.Drawing.Size(340, 24);
            this.lblActivityName3.Text = "Omar Khaled";
            this.lblActivityName3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblActivityName3.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            // 
            // lblActivityDesc3
            // 
            this.lblActivityDesc3.Name = "lblActivityDesc3";
            this.lblActivityDesc3.AutoEllipsis = true;
            this.lblActivityDesc3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblActivityDesc3.ForeColor = System.Drawing.Color.FromArgb(85, 85, 85);
            this.lblActivityDesc3.Location = new System.Drawing.Point(36, 210);
            this.lblActivityDesc3.Size = new System.Drawing.Size(440, 22);
            this.lblActivityDesc3.Text = "Arrived late · Database Systems";
            this.lblActivityDesc3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblActivityDesc3.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            // 
            // lblActivityTime3
            // 
            this.lblActivityTime3.Name = "lblActivityTime3";
            this.lblActivityTime3.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            this.lblActivityTime3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblActivityTime3.ForeColor = System.Drawing.Color.FromArgb(85, 85, 85);
            this.lblActivityTime3.Location = new System.Drawing.Point(390, 186);
            this.lblActivityTime3.Size = new System.Drawing.Size(82, 24);
            this.lblActivityTime3.Text = "08:41 AM";
            this.lblActivityTime3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dotActivity4
            // 
            this.dotActivity4.Name = "dotActivity4";
            this.dotActivity4.BackColor = System.Drawing.Color.FromArgb(100, 100, 100);
            this.dotActivity4.Location = new System.Drawing.Point(19, 248);
            this.dotActivity4.Size = new System.Drawing.Size(8, 8);
            // 
            // lblActivityName4
            // 
            this.lblActivityName4.Name = "lblActivityName4";
            this.lblActivityName4.AutoEllipsis = true;
            this.lblActivityName4.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblActivityName4.ForeColor = System.Drawing.Color.FromArgb(20, 20, 20);
            this.lblActivityName4.Location = new System.Drawing.Point(36, 240);
            this.lblActivityName4.Size = new System.Drawing.Size(340, 24);
            this.lblActivityName4.Text = "New announcement";
            this.lblActivityName4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblActivityName4.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            // 
            // lblActivityDesc4
            // 
            this.lblActivityDesc4.Name = "lblActivityDesc4";
            this.lblActivityDesc4.AutoEllipsis = true;
            this.lblActivityDesc4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblActivityDesc4.ForeColor = System.Drawing.Color.FromArgb(85, 85, 85);
            this.lblActivityDesc4.Location = new System.Drawing.Point(36, 264);
            this.lblActivityDesc4.Size = new System.Drawing.Size(440, 22);
            this.lblActivityDesc4.Text = "Midterm schedule published";
            this.lblActivityDesc4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblActivityDesc4.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            // 
            // lblActivityTime4
            // 
            this.lblActivityTime4.Name = "lblActivityTime4";
            this.lblActivityTime4.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            this.lblActivityTime4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblActivityTime4.ForeColor = System.Drawing.Color.FromArgb(85, 85, 85);
            this.lblActivityTime4.Location = new System.Drawing.Point(390, 240);
            this.lblActivityTime4.Size = new System.Drawing.Size(82, 24);
            this.lblActivityTime4.Text = "Yesterday";
            this.lblActivityTime4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pnlTodayHeader
            // 
            this.pnlTodayHeader.Controls.Add(this.lblToday);
            this.pnlTodayHeader.Controls.Add(this.lblLive);
            this.pnlTodayHeader.Name = "pnlTodayHeader";
            this.pnlTodayHeader.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlTodayHeader.Margin = new System.Windows.Forms.Padding(0, 0, 0, 0);
            this.pnlTodayHeader.Size = new System.Drawing.Size(1340, 48);
            // 
            // lblToday
            // 
            this.lblToday.Name = "lblToday";
            this.lblToday.AutoSize = true;
            this.lblToday.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblToday.ForeColor = System.Drawing.Color.FromArgb(20, 20, 20);
            this.lblToday.Location = new System.Drawing.Point(1, 10);
            this.lblToday.Text = "Today’s attendance";
            // 
            // lblLive
            // 
            this.lblLive.Name = "lblLive";
            this.lblLive.AutoSize = true;
            this.lblLive.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            this.lblLive.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblLive.ForeColor = System.Drawing.Color.FromArgb(35, 35, 35);
            this.lblLive.Location = new System.Drawing.Point(1290, 14);
            this.lblLive.Text = "LIVE";
            // 
            // dgvToday
            // 
            this.dgvToday.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colTodayStudent,
            this.colTodayCourse,
            this.colTodayTime,
            this.colTodayStatus});
            this.dgvToday.Name = "dgvToday";
            this.dgvToday.AllowUserToAddRows = false;
            this.dgvToday.AllowUserToDeleteRows = false;
            this.dgvToday.AllowUserToResizeRows = false;
            this.dgvToday.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.None;
            this.dgvToday.BackgroundColor = System.Drawing.Color.White;
            this.dgvToday.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvToday.ColumnHeadersHeight = 46;
            this.dgvToday.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvToday.EnableHeadersVisualStyles = false;
            this.dgvToday.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dgvToday.GridColor = System.Drawing.Color.FromArgb(210, 210, 210);
            this.dgvToday.Location = new System.Drawing.Point(0, 0);
            this.dgvToday.MultiSelect = false;
            this.dgvToday.ReadOnly = true;
            this.dgvToday.RowHeadersVisible = false;
            this.dgvToday.RowTemplate.Height = 48;
            this.dgvToday.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvToday.Size = new System.Drawing.Size(1340, 240);
            this.dgvToday.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvToday.Margin = new System.Windows.Forms.Padding(0, 0, 0, 0);
            // 
            // colTodayStudent
            // 
            this.colTodayStudent.Name = "colTodayStudent";
            this.colTodayStudent.HeaderText = "STUDENT";
            this.colTodayStudent.Width = 230;
            this.colTodayStudent.ReadOnly = true;
            this.colTodayStudent.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // colTodayCourse
            // 
            this.colTodayCourse.Name = "colTodayCourse";
            this.colTodayCourse.HeaderText = "COURSE";
            this.colTodayCourse.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colTodayCourse.ReadOnly = true;
            this.colTodayCourse.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // colTodayTime
            // 
            this.colTodayTime.Name = "colTodayTime";
            this.colTodayTime.HeaderText = "CHECK-IN";
            this.colTodayTime.Width = 145;
            this.colTodayTime.ReadOnly = true;
            this.colTodayTime.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // colTodayStatus
            // 
            this.colTodayStatus.Name = "colTodayStatus";
            this.colTodayStatus.HeaderText = "STATUS";
            this.colTodayStatus.Width = 140;
            this.colTodayStatus.ReadOnly = true;
            this.colTodayStatus.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // tmrCounters
            // 
            this.tmrCounters.Interval = 16;
            this.tmrCounters.Tick += new System.EventHandler(this.tmrCounters_Tick);
            // 
            // DashboardPage
            // 
            this.Controls.Add(this.tlpRoot);
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(250, 250, 250);
            this.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AutoScroll = true;
            this.AutoScrollMinSize = new System.Drawing.Size(900, 800);
            this.Size = new System.Drawing.Size(1340, 780);
            this.Name = "DashboardPage";
            this.tlpRoot.ResumeLayout(false);
            this.tlpRoot.PerformLayout();
            this.tlpStats.ResumeLayout(false);
            this.tlpStats.PerformLayout();
            this.cardStudents.ResumeLayout(false);
            this.cardOnCampus.ResumeLayout(false);
            this.cardAttendance.ResumeLayout(false);
            this.cardRooms.ResumeLayout(false);
            this.tlpMiddle.ResumeLayout(false);
            this.tlpMiddle.PerformLayout();
            this.cardChart.ResumeLayout(false);
            this.cardActivity.ResumeLayout(false);
            this.dotActivity1.ResumeLayout(false);
            this.dotActivity2.ResumeLayout(false);
            this.dotActivity3.ResumeLayout(false);
            this.dotActivity4.ResumeLayout(false);
            this.pnlTodayHeader.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvToday)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpRoot;
        private System.Windows.Forms.Label lblHeading;
        private System.Windows.Forms.TableLayoutPanel tlpStats;
        private SmartCampus.CardPanel cardStudents;
        private System.Windows.Forms.Label lblStudentsTitle;
        private System.Windows.Forms.Label lblStudentsValue;
        private System.Windows.Forms.Label lblStudentsDelta;
        private System.Windows.Forms.Label lblStudentsGlyph;
        private SmartCampus.CardPanel cardOnCampus;
        private System.Windows.Forms.Label lblOnCampusTitle;
        private System.Windows.Forms.Label lblOnCampusValue;
        private System.Windows.Forms.Label lblOnCampusDelta;
        private System.Windows.Forms.Label lblOnCampusGlyph;
        private SmartCampus.CardPanel cardAttendance;
        private System.Windows.Forms.Label lblAttendanceTitle;
        private System.Windows.Forms.Label lblAttendanceValue;
        private System.Windows.Forms.Label lblAttendanceDelta;
        private System.Windows.Forms.Label lblAttendanceGlyph;
        private SmartCampus.CardPanel cardRooms;
        private System.Windows.Forms.Label lblRoomsTitle;
        private System.Windows.Forms.Label lblRoomsValue;
        private System.Windows.Forms.Label lblRoomsDelta;
        private System.Windows.Forms.Label lblRoomsGlyph;
        private System.Windows.Forms.TableLayoutPanel tlpMiddle;
        private SmartCampus.CardPanel cardChart;
        private System.Windows.Forms.Label lblChartTitle;
        private System.Windows.Forms.Label lblChartSub;
        private SmartCampus.AttendanceChart chartWeekly;
        private SmartCampus.CardPanel cardActivity;
        private System.Windows.Forms.Label lblActivityTitle;
        private System.Windows.Forms.Label lblActivityCaption;
        private System.Windows.Forms.Panel dotActivity1;
        private System.Windows.Forms.Label lblActivityName1;
        private System.Windows.Forms.Label lblActivityDesc1;
        private System.Windows.Forms.Label lblActivityTime1;
        private System.Windows.Forms.Panel dotActivity2;
        private System.Windows.Forms.Label lblActivityName2;
        private System.Windows.Forms.Label lblActivityDesc2;
        private System.Windows.Forms.Label lblActivityTime2;
        private System.Windows.Forms.Panel dotActivity3;
        private System.Windows.Forms.Label lblActivityName3;
        private System.Windows.Forms.Label lblActivityDesc3;
        private System.Windows.Forms.Label lblActivityTime3;
        private System.Windows.Forms.Panel dotActivity4;
        private System.Windows.Forms.Label lblActivityName4;
        private System.Windows.Forms.Label lblActivityDesc4;
        private System.Windows.Forms.Label lblActivityTime4;
        private System.Windows.Forms.Panel pnlTodayHeader;
        private System.Windows.Forms.Label lblToday;
        private System.Windows.Forms.Label lblLive;
        private System.Windows.Forms.DataGridView dgvToday;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTodayStudent;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTodayCourse;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTodayTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTodayStatus;
        private System.Windows.Forms.Timer tmrCounters;
    }
}
