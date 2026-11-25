#nullable disable
namespace SmartCampus
{
    partial class AttendancePage
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
            //
            this.dgvAttendance = new System.Windows.Forms.DataGridView();
            this.colStudent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCourse = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlSummary = new System.Windows.Forms.Panel();
            this.cardPresent = new SmartCampus.CardPanel();
            this.lblPresentTitle = new System.Windows.Forms.Label();
            this.lblPresentValue = new System.Windows.Forms.Label();
            this.cardLate = new SmartCampus.CardPanel();
            this.lblLateTitle = new System.Windows.Forms.Label();
            this.lblLateValue = new System.Windows.Forms.Label();
            this.cardAbsent = new SmartCampus.CardPanel();
            this.lblAbsentTitle = new System.Windows.Forms.Label();
            this.lblAbsentValue = new System.Windows.Forms.Label();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblHeading = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAttendance)).BeginInit();
            this.pnlSummary.SuspendLayout();
            this.cardPresent.SuspendLayout();
            this.cardLate.SuspendLayout();
            this.cardAbsent.SuspendLayout();
            this.pnlHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvAttendance
            // 
            this.dgvAttendance.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colStudent,
            this.colCourse,
            this.colTime,
            this.colStatus});
            this.dgvAttendance.Name = "dgvAttendance";
            this.dgvAttendance.AllowUserToAddRows = false;
            this.dgvAttendance.AllowUserToDeleteRows = false;
            this.dgvAttendance.AllowUserToResizeRows = false;
            this.dgvAttendance.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.None;
            this.dgvAttendance.BackgroundColor = System.Drawing.Color.White;
            this.dgvAttendance.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvAttendance.ColumnHeadersHeight = 46;
            this.dgvAttendance.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvAttendance.EnableHeadersVisualStyles = false;
            this.dgvAttendance.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dgvAttendance.GridColor = System.Drawing.Color.FromArgb(210, 210, 210);
            this.dgvAttendance.Location = new System.Drawing.Point(0, 172);
            this.dgvAttendance.MultiSelect = false;
            this.dgvAttendance.ReadOnly = true;
            this.dgvAttendance.RowHeadersVisible = false;
            this.dgvAttendance.RowTemplate.Height = 48;
            this.dgvAttendance.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAttendance.Size = new System.Drawing.Size(1340, 528);
            this.dgvAttendance.Dock = System.Windows.Forms.DockStyle.Fill;
            // 
            // colStudent
            // 
            this.colStudent.Name = "colStudent";
            this.colStudent.HeaderText = "STUDENT";
            this.colStudent.Width = 250;
            this.colStudent.ReadOnly = true;
            this.colStudent.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // colCourse
            // 
            this.colCourse.Name = "colCourse";
            this.colCourse.HeaderText = "COURSE";
            this.colCourse.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colCourse.ReadOnly = true;
            this.colCourse.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // colTime
            // 
            this.colTime.Name = "colTime";
            this.colTime.HeaderText = "CHECK-IN TIME";
            this.colTime.Width = 170;
            this.colTime.ReadOnly = true;
            this.colTime.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // colStatus
            // 
            this.colStatus.Name = "colStatus";
            this.colStatus.HeaderText = "STATUS";
            this.colStatus.Width = 150;
            this.colStatus.ReadOnly = true;
            this.colStatus.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // pnlSummary
            // 
            this.pnlSummary.Controls.Add(this.cardPresent);
            this.pnlSummary.Controls.Add(this.cardLate);
            this.pnlSummary.Controls.Add(this.cardAbsent);
            this.pnlSummary.Name = "pnlSummary";
            this.pnlSummary.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSummary.Location = new System.Drawing.Point(0, 62);
            this.pnlSummary.Size = new System.Drawing.Size(1340, 110);
            // 
            // cardPresent
            // 
            this.cardPresent.Controls.Add(this.lblPresentTitle);
            this.cardPresent.Controls.Add(this.lblPresentValue);
            this.cardPresent.Name = "cardPresent";
            this.cardPresent.Location = new System.Drawing.Point(0, 6);
            this.cardPresent.Size = new System.Drawing.Size(210, 94);
            // 
            // lblPresentTitle
            // 
            this.lblPresentTitle.Name = "lblPresentTitle";
            this.lblPresentTitle.AutoSize = true;
            this.lblPresentTitle.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPresentTitle.ForeColor = System.Drawing.Color.FromArgb(85, 85, 85);
            this.lblPresentTitle.Location = new System.Drawing.Point(17, 14);
            this.lblPresentTitle.Text = "PRESENT";
            // 
            // lblPresentValue
            // 
            this.lblPresentValue.Name = "lblPresentValue";
            this.lblPresentValue.AutoSize = true;
            this.lblPresentValue.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPresentValue.ForeColor = System.Drawing.Color.FromArgb(20, 20, 20);
            this.lblPresentValue.Location = new System.Drawing.Point(16, 38);
            this.lblPresentValue.Text = "936";
            // 
            // cardLate
            // 
            this.cardLate.Controls.Add(this.lblLateTitle);
            this.cardLate.Controls.Add(this.lblLateValue);
            this.cardLate.Name = "cardLate";
            this.cardLate.Location = new System.Drawing.Point(226, 6);
            this.cardLate.Size = new System.Drawing.Size(210, 94);
            // 
            // lblLateTitle
            // 
            this.lblLateTitle.Name = "lblLateTitle";
            this.lblLateTitle.AutoSize = true;
            this.lblLateTitle.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblLateTitle.ForeColor = System.Drawing.Color.FromArgb(85, 85, 85);
            this.lblLateTitle.Location = new System.Drawing.Point(17, 14);
            this.lblLateTitle.Text = "LATE";
            // 
            // lblLateValue
            // 
            this.lblLateValue.Name = "lblLateValue";
            this.lblLateValue.AutoSize = true;
            this.lblLateValue.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblLateValue.ForeColor = System.Drawing.Color.FromArgb(20, 20, 20);
            this.lblLateValue.Location = new System.Drawing.Point(16, 38);
            this.lblLateValue.Text = "42";
            // 
            // cardAbsent
            // 
            this.cardAbsent.Controls.Add(this.lblAbsentTitle);
            this.cardAbsent.Controls.Add(this.lblAbsentValue);
            this.cardAbsent.Name = "cardAbsent";
            this.cardAbsent.Location = new System.Drawing.Point(452, 6);
            this.cardAbsent.Size = new System.Drawing.Size(210, 94);
            // 
            // lblAbsentTitle
            // 
            this.lblAbsentTitle.Name = "lblAbsentTitle";
            this.lblAbsentTitle.AutoSize = true;
            this.lblAbsentTitle.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblAbsentTitle.ForeColor = System.Drawing.Color.FromArgb(85, 85, 85);
            this.lblAbsentTitle.Location = new System.Drawing.Point(17, 14);
            this.lblAbsentTitle.Text = "ABSENT";
            // 
            // lblAbsentValue
            // 
            this.lblAbsentValue.Name = "lblAbsentValue";
            this.lblAbsentValue.AutoSize = true;
            this.lblAbsentValue.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblAbsentValue.ForeColor = System.Drawing.Color.FromArgb(20, 20, 20);
            this.lblAbsentValue.Location = new System.Drawing.Point(16, 38);
            this.lblAbsentValue.Text = "51";
            // 
            // pnlHeader
            // 
            this.pnlHeader.Controls.Add(this.lblHeading);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Size = new System.Drawing.Size(1340, 62);
            // 
            // lblHeading
            // 
            this.lblHeading.Name = "lblHeading";
            this.lblHeading.AutoSize = true;
            this.lblHeading.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblHeading.ForeColor = System.Drawing.Color.FromArgb(20, 20, 20);
            this.lblHeading.Location = new System.Drawing.Point(0, 6);
            this.lblHeading.Text = "Attendance";
            // 
            // AttendancePage
            // 
            this.Controls.Add(this.dgvAttendance);
            this.Controls.Add(this.pnlSummary);
            this.Controls.Add(this.pnlHeader);
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(250, 250, 250);
            this.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Size = new System.Drawing.Size(1340, 700);
            this.Name = "AttendancePage";
            this.pnlSummary.ResumeLayout(false);
            this.cardPresent.ResumeLayout(false);
            this.cardLate.ResumeLayout(false);
            this.cardAbsent.ResumeLayout(false);
            this.pnlHeader.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAttendance)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.DataGridView dgvAttendance;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStudent;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCourse;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStatus;
        private System.Windows.Forms.Panel pnlSummary;
        private SmartCampus.CardPanel cardPresent;
        private System.Windows.Forms.Label lblPresentTitle;
        private System.Windows.Forms.Label lblPresentValue;
        private SmartCampus.CardPanel cardLate;
        private System.Windows.Forms.Label lblLateTitle;
        private System.Windows.Forms.Label lblLateValue;
        private SmartCampus.CardPanel cardAbsent;
        private System.Windows.Forms.Label lblAbsentTitle;
        private System.Windows.Forms.Label lblAbsentValue;
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblHeading;
    }
}
