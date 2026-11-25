#nullable disable
namespace SmartCampus
{
    partial class ResourcesForm
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
            this.tlpMain = new System.Windows.Forms.TableLayoutPanel();
            this.grpRooms = new System.Windows.Forms.GroupBox();
            this.lblRoomName = new System.Windows.Forms.Label();
            this.lblCapacity = new System.Windows.Forms.Label();
            this.txtRoomName = new System.Windows.Forms.TextBox();
            this.nudCapacity = new System.Windows.Forms.NumericUpDown();
            this.btnAddRoom = new System.Windows.Forms.Button();
            this.btnRemoveRoom = new System.Windows.Forms.Button();
            this.dgvRooms = new System.Windows.Forms.DataGridView();
            this.colRoomName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRoomCapacity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpSlots = new System.Windows.Forms.GroupBox();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblStart = new System.Windows.Forms.Label();
            this.lblEnd = new System.Windows.Forms.Label();
            this.dtpSlotDate = new System.Windows.Forms.DateTimePicker();
            this.dtpSlotStart = new System.Windows.Forms.DateTimePicker();
            this.dtpSlotEnd = new System.Windows.Forms.DateTimePicker();
            this.btnAddSlot = new System.Windows.Forms.Button();
            this.dgvSlots = new System.Windows.Forms.DataGridView();
            this.colSlotDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSlotStart = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSlotEnd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpBlocks = new System.Windows.Forms.GroupBox();
            this.lblSelRoom = new System.Windows.Forms.Label();
            this.lblSelDate = new System.Windows.Forms.Label();
            this.lblSelSlot = new System.Windows.Forms.Label();
            this.cboRoom = new System.Windows.Forms.ComboBox();
            this.cboDate = new System.Windows.Forms.ComboBox();
            this.cboSlot = new System.Windows.Forms.ComboBox();
            this.btnMark = new System.Windows.Forms.Button();
            this.dgvBlocks = new System.Windows.Forms.DataGridView();
            this.colBlockRoom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBlockDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBlockSlot = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.nudCapacity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRooms)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSlots)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBlocks)).BeginInit();
            this.tlpMain.SuspendLayout();
            this.grpRooms.SuspendLayout();
            this.grpSlots.SuspendLayout();
            this.grpBlocks.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpMain
            // 
            this.tlpMain.ColumnCount = 1;
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMain.RowCount = 3;
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.3F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.3F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.4F));
            this.tlpMain.Controls.Add(this.grpRooms, 0, 0);
            this.tlpMain.Controls.Add(this.grpSlots, 0, 1);
            this.tlpMain.Controls.Add(this.grpBlocks, 0, 2);
            this.tlpMain.Name = "tlpMain";
            this.tlpMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpMain.Location = new System.Drawing.Point(0, 0);
            this.tlpMain.Padding = new System.Windows.Forms.Padding(14, 14, 14, 14);
            this.tlpMain.Size = new System.Drawing.Size(700, 790);
            this.tlpMain.BackColor = System.Drawing.Color.FromArgb(250, 250, 250);
            // 
            // grpRooms
            // 
            this.grpRooms.Controls.Add(this.lblRoomName);
            this.grpRooms.Controls.Add(this.lblCapacity);
            this.grpRooms.Controls.Add(this.txtRoomName);
            this.grpRooms.Controls.Add(this.nudCapacity);
            this.grpRooms.Controls.Add(this.btnAddRoom);
            this.grpRooms.Controls.Add(this.btnRemoveRoom);
            this.grpRooms.Controls.Add(this.dgvRooms);
            this.grpRooms.Name = "grpRooms";
            this.grpRooms.BackColor = System.Drawing.Color.White;
            this.grpRooms.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpRooms.ForeColor = System.Drawing.Color.FromArgb(20, 20, 20);
            this.grpRooms.Margin = new System.Windows.Forms.Padding(0, 0, 0, 8);
            this.grpRooms.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpRooms.Size = new System.Drawing.Size(672, 242);
            this.grpRooms.Text = "Rooms Management";
            // 
            // lblRoomName
            // 
            this.lblRoomName.Name = "lblRoomName";
            this.lblRoomName.AutoSize = true;
            this.lblRoomName.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblRoomName.ForeColor = System.Drawing.Color.FromArgb(85, 85, 85);
            this.lblRoomName.Location = new System.Drawing.Point(14, 24);
            this.lblRoomName.Text = "Room Name";
            // 
            // lblCapacity
            // 
            this.lblCapacity.Name = "lblCapacity";
            this.lblCapacity.AutoSize = true;
            this.lblCapacity.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCapacity.ForeColor = System.Drawing.Color.FromArgb(85, 85, 85);
            this.lblCapacity.Location = new System.Drawing.Point(204, 24);
            this.lblCapacity.Text = "Capacity";
            // 
            // txtRoomName
            // 
            this.txtRoomName.Name = "txtRoomName";
            this.txtRoomName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRoomName.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtRoomName.Location = new System.Drawing.Point(14, 46);
            this.txtRoomName.Size = new System.Drawing.Size(175, 28);
            this.txtRoomName.PlaceholderText = "e.g. Room A";
            // 
            // nudCapacity
            // 
            this.nudCapacity.Name = "nudCapacity";
            this.nudCapacity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nudCapacity.Location = new System.Drawing.Point(204, 46);
            this.nudCapacity.Maximum = new decimal(new int[] {1000, 0, 0, 0});
            this.nudCapacity.Minimum = new decimal(new int[] {1, 0, 0, 0});
            this.nudCapacity.Size = new System.Drawing.Size(90, 28);
            this.nudCapacity.Value = new decimal(new int[] {30, 0, 0, 0});
            // 
            // btnAddRoom
            // 
            this.btnAddRoom.Name = "btnAddRoom";
            this.btnAddRoom.BackColor = System.Drawing.Color.FromArgb(20, 20, 20);
            this.btnAddRoom.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddRoom.FlatAppearance.BorderSize = 0;
            this.btnAddRoom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddRoom.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAddRoom.ForeColor = System.Drawing.Color.White;
            this.btnAddRoom.Location = new System.Drawing.Point(312, 44);
            this.btnAddRoom.Size = new System.Drawing.Size(110, 32);
            this.btnAddRoom.Text = "Add Room";
            this.btnAddRoom.UseVisualStyleBackColor = false;
            this.btnAddRoom.Click += new System.EventHandler(this.btnAddRoom_Click);
            // 
            // btnRemoveRoom
            // 
            this.btnRemoveRoom.Name = "btnRemoveRoom";
            this.btnRemoveRoom.BackColor = System.Drawing.Color.FromArgb(235, 235, 235);
            this.btnRemoveRoom.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRemoveRoom.FlatAppearance.BorderSize = 0;
            this.btnRemoveRoom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoveRoom.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnRemoveRoom.ForeColor = System.Drawing.Color.FromArgb(45, 45, 45);
            this.btnRemoveRoom.Location = new System.Drawing.Point(432, 44);
            this.btnRemoveRoom.Size = new System.Drawing.Size(190, 32);
            this.btnRemoveRoom.Text = "Remove Selected Room";
            this.btnRemoveRoom.UseVisualStyleBackColor = false;
            this.btnRemoveRoom.Click += new System.EventHandler(this.btnRemoveRoom_Click);
            // 
            // dgvRooms
            // 
            this.dgvRooms.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colRoomName,
            this.colRoomCapacity});
            this.dgvRooms.Name = "dgvRooms";
            this.dgvRooms.AllowUserToAddRows = false;
            this.dgvRooms.AllowUserToDeleteRows = false;
            this.dgvRooms.AllowUserToResizeRows = false;
            this.dgvRooms.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.None;
            this.dgvRooms.BackgroundColor = System.Drawing.Color.White;
            this.dgvRooms.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvRooms.ColumnHeadersHeight = 32;
            this.dgvRooms.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvRooms.EnableHeadersVisualStyles = false;
            this.dgvRooms.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dgvRooms.GridColor = System.Drawing.Color.FromArgb(210, 210, 210);
            this.dgvRooms.Location = new System.Drawing.Point(14, 88);
            this.dgvRooms.MultiSelect = false;
            this.dgvRooms.ReadOnly = true;
            this.dgvRooms.RowHeadersVisible = false;
            this.dgvRooms.RowTemplate.Height = 34;
            this.dgvRooms.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRooms.Size = new System.Drawing.Size(642, 140);
            this.dgvRooms.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            // 
            // colRoomName
            // 
            this.colRoomName.Name = "colRoomName";
            this.colRoomName.HeaderText = "Room Name";
            this.colRoomName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colRoomName.ReadOnly = true;
            this.colRoomName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // colRoomCapacity
            // 
            this.colRoomCapacity.Name = "colRoomCapacity";
            this.colRoomCapacity.HeaderText = "Capacity";
            this.colRoomCapacity.Width = 140;
            this.colRoomCapacity.ReadOnly = true;
            this.colRoomCapacity.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // grpSlots
            // 
            this.grpSlots.Controls.Add(this.lblDate);
            this.grpSlots.Controls.Add(this.lblStart);
            this.grpSlots.Controls.Add(this.lblEnd);
            this.grpSlots.Controls.Add(this.dtpSlotDate);
            this.grpSlots.Controls.Add(this.dtpSlotStart);
            this.grpSlots.Controls.Add(this.dtpSlotEnd);
            this.grpSlots.Controls.Add(this.btnAddSlot);
            this.grpSlots.Controls.Add(this.dgvSlots);
            this.grpSlots.Name = "grpSlots";
            this.grpSlots.BackColor = System.Drawing.Color.White;
            this.grpSlots.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpSlots.ForeColor = System.Drawing.Color.FromArgb(20, 20, 20);
            this.grpSlots.Margin = new System.Windows.Forms.Padding(0, 0, 0, 8);
            this.grpSlots.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpSlots.Size = new System.Drawing.Size(672, 242);
            this.grpSlots.Text = "Dates & Time Slots";
            // 
            // lblDate
            // 
            this.lblDate.Name = "lblDate";
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDate.ForeColor = System.Drawing.Color.FromArgb(85, 85, 85);
            this.lblDate.Location = new System.Drawing.Point(14, 24);
            this.lblDate.Text = "Date";
            // 
            // lblStart
            // 
            this.lblStart.Name = "lblStart";
            this.lblStart.AutoSize = true;
            this.lblStart.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblStart.ForeColor = System.Drawing.Color.FromArgb(85, 85, 85);
            this.lblStart.Location = new System.Drawing.Point(184, 24);
            this.lblStart.Text = "Start Time";
            // 
            // lblEnd
            // 
            this.lblEnd.Name = "lblEnd";
            this.lblEnd.AutoSize = true;
            this.lblEnd.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblEnd.ForeColor = System.Drawing.Color.FromArgb(85, 85, 85);
            this.lblEnd.Location = new System.Drawing.Point(314, 24);
            this.lblEnd.Text = "End Time";
            // 
            // dtpSlotDate
            // 
            this.dtpSlotDate.Name = "dtpSlotDate";
            this.dtpSlotDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpSlotDate.Location = new System.Drawing.Point(14, 46);
            this.dtpSlotDate.Size = new System.Drawing.Size(155, 28);
            // 
            // dtpSlotStart
            // 
            this.dtpSlotStart.Name = "dtpSlotStart";
            this.dtpSlotStart.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpSlotStart.Location = new System.Drawing.Point(184, 46);
            this.dtpSlotStart.ShowUpDown = true;
            this.dtpSlotStart.Size = new System.Drawing.Size(115, 28);
            // 
            // dtpSlotEnd
            // 
            this.dtpSlotEnd.Name = "dtpSlotEnd";
            this.dtpSlotEnd.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpSlotEnd.Location = new System.Drawing.Point(314, 46);
            this.dtpSlotEnd.ShowUpDown = true;
            this.dtpSlotEnd.Size = new System.Drawing.Size(115, 28);
            // 
            // btnAddSlot
            // 
            this.btnAddSlot.Name = "btnAddSlot";
            this.btnAddSlot.BackColor = System.Drawing.Color.FromArgb(20, 20, 20);
            this.btnAddSlot.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddSlot.FlatAppearance.BorderSize = 0;
            this.btnAddSlot.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddSlot.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAddSlot.ForeColor = System.Drawing.Color.White;
            this.btnAddSlot.Location = new System.Drawing.Point(446, 44);
            this.btnAddSlot.Size = new System.Drawing.Size(176, 32);
            this.btnAddSlot.Text = "Add Date & Slot";
            this.btnAddSlot.UseVisualStyleBackColor = false;
            this.btnAddSlot.Click += new System.EventHandler(this.btnAddSlot_Click);
            // 
            // dgvSlots
            // 
            this.dgvSlots.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colSlotDate,
            this.colSlotStart,
            this.colSlotEnd});
            this.dgvSlots.Name = "dgvSlots";
            this.dgvSlots.AllowUserToAddRows = false;
            this.dgvSlots.AllowUserToDeleteRows = false;
            this.dgvSlots.AllowUserToResizeRows = false;
            this.dgvSlots.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.None;
            this.dgvSlots.BackgroundColor = System.Drawing.Color.White;
            this.dgvSlots.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvSlots.ColumnHeadersHeight = 32;
            this.dgvSlots.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvSlots.EnableHeadersVisualStyles = false;
            this.dgvSlots.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dgvSlots.GridColor = System.Drawing.Color.FromArgb(210, 210, 210);
            this.dgvSlots.Location = new System.Drawing.Point(14, 88);
            this.dgvSlots.MultiSelect = false;
            this.dgvSlots.ReadOnly = true;
            this.dgvSlots.RowHeadersVisible = false;
            this.dgvSlots.RowTemplate.Height = 34;
            this.dgvSlots.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSlots.Size = new System.Drawing.Size(642, 140);
            this.dgvSlots.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            // 
            // colSlotDate
            // 
            this.colSlotDate.Name = "colSlotDate";
            this.colSlotDate.HeaderText = "Date";
            this.colSlotDate.Width = 170;
            this.colSlotDate.ReadOnly = true;
            this.colSlotDate.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // colSlotStart
            // 
            this.colSlotStart.Name = "colSlotStart";
            this.colSlotStart.HeaderText = "Start Time";
            this.colSlotStart.Width = 150;
            this.colSlotStart.ReadOnly = true;
            this.colSlotStart.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // colSlotEnd
            // 
            this.colSlotEnd.Name = "colSlotEnd";
            this.colSlotEnd.HeaderText = "End Time";
            this.colSlotEnd.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colSlotEnd.ReadOnly = true;
            this.colSlotEnd.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // grpBlocks
            // 
            this.grpBlocks.Controls.Add(this.lblSelRoom);
            this.grpBlocks.Controls.Add(this.lblSelDate);
            this.grpBlocks.Controls.Add(this.lblSelSlot);
            this.grpBlocks.Controls.Add(this.cboRoom);
            this.grpBlocks.Controls.Add(this.cboDate);
            this.grpBlocks.Controls.Add(this.cboSlot);
            this.grpBlocks.Controls.Add(this.btnMark);
            this.grpBlocks.Controls.Add(this.dgvBlocks);
            this.grpBlocks.Name = "grpBlocks";
            this.grpBlocks.BackColor = System.Drawing.Color.White;
            this.grpBlocks.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpBlocks.ForeColor = System.Drawing.Color.FromArgb(20, 20, 20);
            this.grpBlocks.Margin = new System.Windows.Forms.Padding(0, 0, 0, 8);
            this.grpBlocks.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpBlocks.Size = new System.Drawing.Size(672, 242);
            this.grpBlocks.Text = "Room Unavailability";
            // 
            // lblSelRoom
            // 
            this.lblSelRoom.Name = "lblSelRoom";
            this.lblSelRoom.AutoSize = true;
            this.lblSelRoom.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblSelRoom.ForeColor = System.Drawing.Color.FromArgb(85, 85, 85);
            this.lblSelRoom.Location = new System.Drawing.Point(14, 22);
            this.lblSelRoom.Text = "Select Room";
            // 
            // lblSelDate
            // 
            this.lblSelDate.Name = "lblSelDate";
            this.lblSelDate.AutoSize = true;
            this.lblSelDate.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblSelDate.ForeColor = System.Drawing.Color.FromArgb(85, 85, 85);
            this.lblSelDate.Location = new System.Drawing.Point(194, 22);
            this.lblSelDate.Text = "Select Date";
            // 
            // lblSelSlot
            // 
            this.lblSelSlot.Name = "lblSelSlot";
            this.lblSelSlot.AutoSize = true;
            this.lblSelSlot.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblSelSlot.ForeColor = System.Drawing.Color.FromArgb(85, 85, 85);
            this.lblSelSlot.Location = new System.Drawing.Point(374, 22);
            this.lblSelSlot.Text = "Select Slot";
            // 
            // cboRoom
            // 
            this.cboRoom.Name = "cboRoom";
            this.cboRoom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboRoom.FormattingEnabled = true;
            this.cboRoom.Location = new System.Drawing.Point(14, 42);
            this.cboRoom.Size = new System.Drawing.Size(165, 28);
            // 
            // cboDate
            // 
            this.cboDate.Name = "cboDate";
            this.cboDate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDate.FormattingEnabled = true;
            this.cboDate.Location = new System.Drawing.Point(194, 42);
            this.cboDate.Size = new System.Drawing.Size(165, 28);
            this.cboDate.Format += new System.Windows.Forms.ListControlConvertEventHandler(this.cboDate_Format);
            this.cboDate.SelectedIndexChanged += new System.EventHandler(this.cboDate_SelectedIndexChanged);
            // 
            // cboSlot
            // 
            this.cboSlot.Name = "cboSlot";
            this.cboSlot.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSlot.FormattingEnabled = true;
            this.cboSlot.Location = new System.Drawing.Point(374, 42);
            this.cboSlot.Size = new System.Drawing.Size(200, 28);
            // 
            // btnMark
            // 
            this.btnMark.Name = "btnMark";
            this.btnMark.BackColor = System.Drawing.Color.FromArgb(235, 235, 235);
            this.btnMark.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMark.FlatAppearance.BorderSize = 0;
            this.btnMark.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMark.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnMark.ForeColor = System.Drawing.Color.FromArgb(45, 45, 45);
            this.btnMark.Location = new System.Drawing.Point(14, 78);
            this.btnMark.Size = new System.Drawing.Size(220, 32);
            this.btnMark.Text = "Mark Room as Unavailable";
            this.btnMark.UseVisualStyleBackColor = false;
            this.btnMark.Click += new System.EventHandler(this.btnMark_Click);
            // 
            // dgvBlocks
            // 
            this.dgvBlocks.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colBlockRoom,
            this.colBlockDate,
            this.colBlockSlot});
            this.dgvBlocks.Name = "dgvBlocks";
            this.dgvBlocks.AllowUserToAddRows = false;
            this.dgvBlocks.AllowUserToDeleteRows = false;
            this.dgvBlocks.AllowUserToResizeRows = false;
            this.dgvBlocks.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.None;
            this.dgvBlocks.BackgroundColor = System.Drawing.Color.White;
            this.dgvBlocks.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvBlocks.ColumnHeadersHeight = 32;
            this.dgvBlocks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvBlocks.EnableHeadersVisualStyles = false;
            this.dgvBlocks.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dgvBlocks.GridColor = System.Drawing.Color.FromArgb(210, 210, 210);
            this.dgvBlocks.Location = new System.Drawing.Point(14, 118);
            this.dgvBlocks.MultiSelect = false;
            this.dgvBlocks.ReadOnly = true;
            this.dgvBlocks.RowHeadersVisible = false;
            this.dgvBlocks.RowTemplate.Height = 34;
            this.dgvBlocks.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBlocks.Size = new System.Drawing.Size(642, 112);
            this.dgvBlocks.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            // 
            // colBlockRoom
            // 
            this.colBlockRoom.Name = "colBlockRoom";
            this.colBlockRoom.HeaderText = "Room";
            this.colBlockRoom.Width = 160;
            this.colBlockRoom.ReadOnly = true;
            this.colBlockRoom.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // colBlockDate
            // 
            this.colBlockDate.Name = "colBlockDate";
            this.colBlockDate.HeaderText = "Date";
            this.colBlockDate.Width = 150;
            this.colBlockDate.ReadOnly = true;
            this.colBlockDate.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // colBlockSlot
            // 
            this.colBlockSlot.Name = "colBlockSlot";
            this.colBlockSlot.HeaderText = "Slot";
            this.colBlockSlot.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colBlockSlot.ReadOnly = true;
            this.colBlockSlot.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // ResourcesForm
            // 
            this.Controls.Add(this.tlpMain);
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(250, 250, 250);
            this.ClientSize = new System.Drawing.Size(700, 790);
            this.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.Color.FromArgb(20, 20, 20);
            this.MinimumSize = new System.Drawing.Size(640, 720);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Resources Management";
            this.Name = "ResourcesForm";
            this.tlpMain.ResumeLayout(false);
            this.tlpMain.PerformLayout();
            this.grpRooms.ResumeLayout(false);
            this.grpSlots.ResumeLayout(false);
            this.grpBlocks.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nudCapacity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRooms)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSlots)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBlocks)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpMain;
        private System.Windows.Forms.GroupBox grpRooms;
        private System.Windows.Forms.Label lblRoomName;
        private System.Windows.Forms.Label lblCapacity;
        private System.Windows.Forms.TextBox txtRoomName;
        private System.Windows.Forms.NumericUpDown nudCapacity;
        private System.Windows.Forms.Button btnAddRoom;
        private System.Windows.Forms.Button btnRemoveRoom;
        private System.Windows.Forms.DataGridView dgvRooms;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRoomName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRoomCapacity;
        private System.Windows.Forms.GroupBox grpSlots;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblStart;
        private System.Windows.Forms.Label lblEnd;
        private System.Windows.Forms.DateTimePicker dtpSlotDate;
        private System.Windows.Forms.DateTimePicker dtpSlotStart;
        private System.Windows.Forms.DateTimePicker dtpSlotEnd;
        private System.Windows.Forms.Button btnAddSlot;
        private System.Windows.Forms.DataGridView dgvSlots;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSlotDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSlotStart;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSlotEnd;
        private System.Windows.Forms.GroupBox grpBlocks;
        private System.Windows.Forms.Label lblSelRoom;
        private System.Windows.Forms.Label lblSelDate;
        private System.Windows.Forms.Label lblSelSlot;
        private System.Windows.Forms.ComboBox cboRoom;
        private System.Windows.Forms.ComboBox cboDate;
        private System.Windows.Forms.ComboBox cboSlot;
        private System.Windows.Forms.Button btnMark;
        private System.Windows.Forms.DataGridView dgvBlocks;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBlockRoom;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBlockDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBlockSlot;
    }
}
