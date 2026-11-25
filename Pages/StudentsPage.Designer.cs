#nullable disable
namespace SmartCampus
{
    partial class StudentsPage
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
            this.cardGrid = new SmartCampus.CardPanel();
            this.dgvStudents = new System.Windows.Forms.DataGridView();
            this.colId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDepartment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colYear = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEdit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.colDelete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.pnlTop = new System.Windows.Forms.Panel();
            this.lblHeading = new System.Windows.Forms.Label();
            this.btnAddStudent = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudents)).BeginInit();
            this.cardGrid.SuspendLayout();
            this.pnlTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // cardGrid
            // 
            this.cardGrid.Controls.Add(this.dgvStudents);
            this.cardGrid.Name = "cardGrid";
            this.cardGrid.Location = new System.Drawing.Point(0, 128);
            this.cardGrid.Size = new System.Drawing.Size(1340, 572);
            this.cardGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cardGrid.Padding = new System.Windows.Forms.Padding(15, 15, 15, 15);
            // 
            // dgvStudents
            // 
            this.dgvStudents.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colId,
            this.colName,
            this.colDepartment,
            this.colEmail,
            this.colYear,
            this.colStatus,
            this.colEdit,
            this.colDelete});
            this.dgvStudents.Name = "dgvStudents";
            this.dgvStudents.AllowUserToAddRows = false;
            this.dgvStudents.AllowUserToDeleteRows = false;
            this.dgvStudents.AllowUserToResizeRows = false;
            this.dgvStudents.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.None;
            this.dgvStudents.BackgroundColor = System.Drawing.Color.White;
            this.dgvStudents.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvStudents.ColumnHeadersHeight = 46;
            this.dgvStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvStudents.EnableHeadersVisualStyles = false;
            this.dgvStudents.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dgvStudents.GridColor = System.Drawing.Color.FromArgb(210, 210, 210);
            this.dgvStudents.Location = new System.Drawing.Point(15, 15);
            this.dgvStudents.MultiSelect = false;
            this.dgvStudents.ReadOnly = true;
            this.dgvStudents.RowHeadersVisible = false;
            this.dgvStudents.RowTemplate.Height = 48;
            this.dgvStudents.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvStudents.Size = new System.Drawing.Size(1310, 542);
            this.dgvStudents.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvStudents.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvStudents_CellContentClick);
            this.dgvStudents.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvStudents_CellDoubleClick);
            // 
            // colId
            // 
            this.colId.Name = "colId";
            this.colId.HeaderText = "STUDENT ID";
            this.colId.Width = 100;
            this.colId.ReadOnly = true;
            this.colId.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // colName
            // 
            this.colName.Name = "colName";
            this.colName.HeaderText = "FULL NAME";
            this.colName.Width = 175;
            this.colName.ReadOnly = true;
            this.colName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // colDepartment
            // 
            this.colDepartment.Name = "colDepartment";
            this.colDepartment.HeaderText = "DEPARTMENT";
            this.colDepartment.Width = 165;
            this.colDepartment.ReadOnly = true;
            this.colDepartment.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // colEmail
            // 
            this.colEmail.Name = "colEmail";
            this.colEmail.HeaderText = "EMAIL ADDRESS";
            this.colEmail.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colEmail.ReadOnly = true;
            this.colEmail.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // colYear
            // 
            this.colYear.Name = "colYear";
            this.colYear.HeaderText = "YEAR";
            this.colYear.Width = 84;
            this.colYear.ReadOnly = true;
            this.colYear.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // colStatus
            // 
            this.colStatus.Name = "colStatus";
            this.colStatus.HeaderText = "STATUS";
            this.colStatus.Width = 100;
            this.colStatus.ReadOnly = true;
            this.colStatus.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // colEdit
            // 
            this.colEdit.Name = "colEdit";
            this.colEdit.HeaderText = "ACTIONS";
            this.colEdit.Width = 80;
            this.colEdit.ReadOnly = true;
            this.colEdit.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colEdit.Text = "Edit";
            this.colEdit.UseColumnTextForButtonValue = true;
            // 
            // colDelete
            // 
            this.colDelete.Name = "colDelete";
            this.colDelete.HeaderText = "";
            this.colDelete.Width = 90;
            this.colDelete.ReadOnly = true;
            this.colDelete.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colDelete.Text = "Delete";
            this.colDelete.UseColumnTextForButtonValue = true;
            // 
            // pnlTop
            // 
            this.pnlTop.Controls.Add(this.lblHeading);
            this.pnlTop.Controls.Add(this.btnAddStudent);
            this.pnlTop.Controls.Add(this.txtSearch);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Size = new System.Drawing.Size(1340, 128);
            // 
            // lblHeading
            // 
            this.lblHeading.Name = "lblHeading";
            this.lblHeading.AutoSize = true;
            this.lblHeading.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblHeading.ForeColor = System.Drawing.Color.FromArgb(20, 20, 20);
            this.lblHeading.Location = new System.Drawing.Point(0, 6);
            this.lblHeading.Text = "Students";
            // 
            // btnAddStudent
            // 
            this.btnAddStudent.Name = "btnAddStudent";
            this.btnAddStudent.BackColor = System.Drawing.Color.FromArgb(20, 20, 20);
            this.btnAddStudent.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddStudent.FlatAppearance.BorderSize = 0;
            this.btnAddStudent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddStudent.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAddStudent.ForeColor = System.Drawing.Color.White;
            this.btnAddStudent.Location = new System.Drawing.Point(1180, 8);
            this.btnAddStudent.Size = new System.Drawing.Size(150, 40);
            this.btnAddStudent.Text = "＋  Add student";
            this.btnAddStudent.UseVisualStyleBackColor = false;
            this.btnAddStudent.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            this.btnAddStudent.Click += new System.EventHandler(this.btnAddStudent_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtSearch.Location = new System.Drawing.Point(0, 74);
            this.txtSearch.Size = new System.Drawing.Size(395, 34);
            this.txtSearch.PlaceholderText = "⌕   Search name, ID, department or email...";
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // StudentsPage
            // 
            this.Controls.Add(this.cardGrid);
            this.Controls.Add(this.pnlTop);
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(250, 250, 250);
            this.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Size = new System.Drawing.Size(1340, 700);
            this.Name = "StudentsPage";
            this.cardGrid.ResumeLayout(false);
            this.pnlTop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudents)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private SmartCampus.CardPanel cardGrid;
        private System.Windows.Forms.DataGridView dgvStudents;
        private System.Windows.Forms.DataGridViewTextBoxColumn colId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDepartment;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn colYear;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStatus;
        private System.Windows.Forms.DataGridViewButtonColumn colEdit;
        private System.Windows.Forms.DataGridViewButtonColumn colDelete;
        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Label lblHeading;
        private System.Windows.Forms.Button btnAddStudent;
        private System.Windows.Forms.TextBox txtSearch;
    }
}
