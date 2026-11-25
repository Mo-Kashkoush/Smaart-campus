#nullable disable
namespace SmartCampus
{
    partial class RoomsPage
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
            this.tlpRoot = new System.Windows.Forms.TableLayoutPanel();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblHeading = new System.Windows.Forms.Label();
            this.btnOpenResources = new System.Windows.Forms.Button();
            this.cardRooms = new SmartCampus.CardPanel();
            this.lblRoomsTitle = new System.Windows.Forms.Label();
            this.lblRoomName = new System.Windows.Forms.Label();
            this.lblBuilding = new System.Windows.Forms.Label();
            this.lblCapacity = new System.Windows.Forms.Label();
            this.txtRoomName = new System.Windows.Forms.TextBox();
            this.txtBuilding = new System.Windows.Forms.TextBox();
            this.nudCapacity = new System.Windows.Forms.NumericUpDown();
            this.btnAddRoom = new System.Windows.Forms.Button();
            this.btnRemoveRoom = new System.Windows.Forms.Button();
            this.dgvRooms = new System.Windows.Forms.DataGridView();
            this.colRoomName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRoomBuilding = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRoomCapacity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRoomState = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cardSlots = new SmartCampus.CardPanel();
            this.lblSlotsTitle = new System.Windows.Forms.Label();
            this.lblSlotDate = new System.Windows.Forms.Label();
            this.lblSlotStart = new System.Windows.Forms.Label();
            this.lblSlotEnd = new System.Windows.Forms.Label();
            this.dtpSlotDate = new System.Windows.Forms.DateTimePicker();
            this.dtpSlotStart = new System.Windows.Forms.DateTimePicker();
            this.dtpSlotEnd = new System.Windows.Forms.DateTimePicker();
            this.btnAddSlot = new System.Windows.Forms.Button();
            this.dgvSlots = new System.Windows.Forms.DataGridView();
            this.colSlotDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSlotStart = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSlotEnd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cardBlocks = new SmartCampus.CardPanel();
            this.lblBlocksTitle = new System.Windows.Forms.Label();
            this.lblBlockRoom = new System.Windows.Forms.Label();
            this.lblBlockDate = new System.Windows.Forms.Label();
            this.lblBlockSlot = new System.Windows.Forms.Label();
            this.cboRoom = new System.Windows.Forms.ComboBox();
            this.dtpBlockDate = new System.Windows.Forms.DateTimePicker();
            this.cboSlot = new System.Windows.Forms.ComboBox();
            this.btnMarkUnavailable = new System.Windows.Forms.Button();
            this.dgvBlocks = new System.Windows.Forms.DataGridView();
            this.colBlockRoom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBlockDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBlockSlot = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.nudCapacity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRooms)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSlots)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBlocks)).BeginInit();
            this.tlpRoot.SuspendLayout();
            this.pnlHeader.SuspendLayout();
            this.cardRooms.SuspendLayout();
            this.cardSlots.SuspendLayout();
            this.cardBlocks.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpRoot
            // 
            this.tlpRoot.ColumnCount = 1;
            this.tlpRoot.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpRoot.RowCount = 4;
            this.tlpRoot.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tlpRoot.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 296F));
            this.tlpRoot.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 250F));
            this.tlpRoot.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 262F));
            this.tlpRoot.Controls.Add(this.pnlHeader, 0, 0);
            this.tlpRoot.Controls.Add(this.cardRooms, 0, 1);
            this.tlpRoot.Controls.Add(this.cardSlots, 0, 2);
            this.tlpRoot.Controls.Add(this.cardBlocks, 0, 3);
            this.tlpRoot.Name = "tlpRoot";
            this.tlpRoot.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpRoot.Location = new System.Drawing.Point(0, 0);
            this.tlpRoot.Size = new System.Drawing.Size(1340, 868);
            // 
            // pnlHeader
            // 
            this.pnlHeader.Controls.Add(this.lblHeading);
            this.pnlHeader.Controls.Add(this.btnOpenResources);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlHeader.Margin = new System.Windows.Forms.Padding(0, 0, 0, 0);
            this.pnlHeader.Size = new System.Drawing.Size(1340, 60);
            // 
            // lblHeading
            // 
            this.lblHeading.Name = "lblHeading";
            this.lblHeading.AutoSize = true;
            this.lblHeading.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblHeading.ForeColor = System.Drawing.Color.FromArgb(20, 20, 20);
            this.lblHeading.Location = new System.Drawing.Point(0, 4);
            this.lblHeading.Text = "Rooms";
            // 
            // btnOpenResources
            // 
            this.btnOpenResources.Name = "btnOpenResources";
            this.btnOpenResources.BackColor = System.Drawing.Color.FromArgb(232, 232, 232);
            this.btnOpenResources.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOpenResources.FlatAppearance.BorderSize = 0;
            this.btnOpenResources.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOpenResources.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnOpenResources.ForeColor = System.Drawing.Color.FromArgb(20, 20, 20);
            this.btnOpenResources.Location = new System.Drawing.Point(1110, 8);
            this.btnOpenResources.Size = new System.Drawing.Size(215, 38);
            this.btnOpenResources.Text = "Open Resources window ↗";
            this.btnOpenResources.UseVisualStyleBackColor = false;
            this.btnOpenResources.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            this.btnOpenResources.Click += new System.EventHandler(this.btnOpenResources_Click);
            // 
            // cardRooms
            // 
            this.cardRooms.Controls.Add(this.lblRoomsTitle);
            this.cardRooms.Controls.Add(this.lblRoomName);
            this.cardRooms.Controls.Add(this.lblBuilding);
            this.cardRooms.Controls.Add(this.lblCapacity);
            this.cardRooms.Controls.Add(this.txtRoomName);
            this.cardRooms.Controls.Add(this.txtBuilding);
            this.cardRooms.Controls.Add(this.nudCapacity);
            this.cardRooms.Controls.Add(this.btnAddRoom);
            this.cardRooms.Controls.Add(this.btnRemoveRoom);
            this.cardRooms.Controls.Add(this.dgvRooms);
            this.cardRooms.Name = "cardRooms";
            this.cardRooms.Location = new System.Drawing.Point(0, 0);
            this.cardRooms.Size = new System.Drawing.Size(1334, 280);
            this.cardRooms.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cardRooms.Margin = new System.Windows.Forms.Padding(0, 0, 6, 16);
            // 
            // lblRoomsTitle
            // 
            this.lblRoomsTitle.Name = "lblRoomsTitle";
            this.lblRoomsTitle.AutoSize = true;
            this.lblRoomsTitle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblRoomsTitle.ForeColor = System.Drawing.Color.FromArgb(20, 20, 20);
            this.lblRoomsTitle.Location = new System.Drawing.Point(20, 16);
            this.lblRoomsTitle.Text = "01  ·  ROOMS MANAGEMENT";
            // 
            // lblRoomName
            // 
            this.lblRoomName.Name = "lblRoomName";
            this.lblRoomName.AutoSize = true;
            this.lblRoomName.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblRoomName.ForeColor = System.Drawing.Color.FromArgb(85, 85, 85);
            this.lblRoomName.Location = new System.Drawing.Point(22, 50);
            this.lblRoomName.Text = "Room name";
            // 
            // lblBuilding
            // 
            this.lblBuilding.Name = "lblBuilding";
            this.lblBuilding.AutoSize = true;
            this.lblBuilding.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblBuilding.ForeColor = System.Drawing.Color.FromArgb(85, 85, 85);
            this.lblBuilding.Location = new System.Drawing.Point(222, 50);
            this.lblBuilding.Text = "Building / location";
            // 
            // lblCapacity
            // 
            this.lblCapacity.Name = "lblCapacity";
            this.lblCapacity.AutoSize = true;
            this.lblCapacity.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCapacity.ForeColor = System.Drawing.Color.FromArgb(85, 85, 85);
            this.lblCapacity.Location = new System.Drawing.Point(452, 50);
            this.lblCapacity.Text = "Capacity";
            // 
            // txtRoomName
            // 
            this.txtRoomName.Name = "txtRoomName";
            this.txtRoomName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRoomName.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtRoomName.Location = new System.Drawing.Point(22, 74);
            this.txtRoomName.Size = new System.Drawing.Size(185, 30);
            this.txtRoomName.PlaceholderText = "e.g. Lecture Hall B";
            // 
            // txtBuilding
            // 
            this.txtBuilding.Name = "txtBuilding";
            this.txtBuilding.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBuilding.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtBuilding.Location = new System.Drawing.Point(222, 74);
            this.txtBuilding.Size = new System.Drawing.Size(210, 30);
            this.txtBuilding.PlaceholderText = "e.g. Main building · Floor 2";
            // 
            // nudCapacity
            // 
            this.nudCapacity.Name = "nudCapacity";
            this.nudCapacity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nudCapacity.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.nudCapacity.Location = new System.Drawing.Point(452, 74);
            this.nudCapacity.Maximum = new decimal(new int[] {1000, 0, 0, 0});
            this.nudCapacity.Minimum = new decimal(new int[] {1, 0, 0, 0});
            this.nudCapacity.Size = new System.Drawing.Size(95, 30);
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
            this.btnAddRoom.Location = new System.Drawing.Point(565, 73);
            this.btnAddRoom.Size = new System.Drawing.Size(125, 32);
            this.btnAddRoom.Text = "＋  Add room";
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
            this.btnRemoveRoom.Location = new System.Drawing.Point(700, 73);
            this.btnRemoveRoom.Size = new System.Drawing.Size(145, 32);
            this.btnRemoveRoom.Text = "Remove selected";
            this.btnRemoveRoom.UseVisualStyleBackColor = false;
            this.btnRemoveRoom.Click += new System.EventHandler(this.btnRemoveRoom_Click);
            // 
            // dgvRooms
            // 
            this.dgvRooms.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colRoomName,
            this.colRoomBuilding,
            this.colRoomCapacity,
            this.colRoomState});
            this.dgvRooms.Name = "dgvRooms";
            this.dgvRooms.AllowUserToAddRows = false;
            this.dgvRooms.AllowUserToDeleteRows = false;
            this.dgvRooms.AllowUserToResizeRows = false;
            this.dgvRooms.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.None;
            this.dgvRooms.BackgroundColor = System.Drawing.Color.White;
            this.dgvRooms.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvRooms.ColumnHeadersHeight = 40;
            this.dgvRooms.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvRooms.EnableHeadersVisualStyles = false;
            this.dgvRooms.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dgvRooms.GridColor = System.Drawing.Color.FromArgb(210, 210, 210);
            this.dgvRooms.Location = new System.Drawing.Point(22, 118);
            this.dgvRooms.MultiSelect = false;
            this.dgvRooms.ReadOnly = true;
            this.dgvRooms.RowHeadersVisible = false;
            this.dgvRooms.RowTemplate.Height = 40;
            this.dgvRooms.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRooms.Size = new System.Drawing.Size(1290, 150);
            this.dgvRooms.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            // 
            // colRoomName
            // 
            this.colRoomName.Name = "colRoomName";
            this.colRoomName.HeaderText = "ROOM NAME";
            this.colRoomName.Width = 210;
            this.colRoomName.ReadOnly = true;
            this.colRoomName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // colRoomBuilding
            // 
            this.colRoomBuilding.Name = "colRoomBuilding";
            this.colRoomBuilding.HeaderText = "BUILDING / LOCATION";
            this.colRoomBuilding.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colRoomBuilding.ReadOnly = true;
            this.colRoomBuilding.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // colRoomCapacity
            // 
            this.colRoomCapacity.Name = "colRoomCapacity";
            this.colRoomCapacity.HeaderText = "CAPACITY";
            this.colRoomCapacity.Width = 110;
            this.colRoomCapacity.ReadOnly = true;
            this.colRoomCapacity.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // colRoomState
            // 
            this.colRoomState.Name = "colRoomState";
            this.colRoomState.HeaderText = "STATUS";
            this.colRoomState.Width = 130;
            this.colRoomState.ReadOnly = true;
            this.colRoomState.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // cardSlots
            // 
            this.cardSlots.Controls.Add(this.lblSlotsTitle);
            this.cardSlots.Controls.Add(this.lblSlotDate);
            this.cardSlots.Controls.Add(this.lblSlotStart);
            this.cardSlots.Controls.Add(this.lblSlotEnd);
            this.cardSlots.Controls.Add(this.dtpSlotDate);
            this.cardSlots.Controls.Add(this.dtpSlotStart);
            this.cardSlots.Controls.Add(this.dtpSlotEnd);
            this.cardSlots.Controls.Add(this.btnAddSlot);
            this.cardSlots.Controls.Add(this.dgvSlots);
            this.cardSlots.Name = "cardSlots";
            this.cardSlots.Location = new System.Drawing.Point(0, 0);
            this.cardSlots.Size = new System.Drawing.Size(1334, 234);
            this.cardSlots.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cardSlots.Margin = new System.Windows.Forms.Padding(0, 0, 6, 16);
            // 
            // lblSlotsTitle
            // 
            this.lblSlotsTitle.Name = "lblSlotsTitle";
            this.lblSlotsTitle.AutoSize = true;
            this.lblSlotsTitle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSlotsTitle.ForeColor = System.Drawing.Color.FromArgb(20, 20, 20);
            this.lblSlotsTitle.Location = new System.Drawing.Point(20, 16);
            this.lblSlotsTitle.Text = "02  ·  DATES & TIME SLOTS";
            // 
            // lblSlotDate
            // 
            this.lblSlotDate.Name = "lblSlotDate";
            this.lblSlotDate.AutoSize = true;
            this.lblSlotDate.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSlotDate.ForeColor = System.Drawing.Color.FromArgb(85, 85, 85);
            this.lblSlotDate.Location = new System.Drawing.Point(22, 50);
            this.lblSlotDate.Text = "Available date";
            // 
            // lblSlotStart
            // 
            this.lblSlotStart.Name = "lblSlotStart";
            this.lblSlotStart.AutoSize = true;
            this.lblSlotStart.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSlotStart.ForeColor = System.Drawing.Color.FromArgb(85, 85, 85);
            this.lblSlotStart.Location = new System.Drawing.Point(222, 50);
            this.lblSlotStart.Text = "Start time";
            // 
            // lblSlotEnd
            // 
            this.lblSlotEnd.Name = "lblSlotEnd";
            this.lblSlotEnd.AutoSize = true;
            this.lblSlotEnd.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSlotEnd.ForeColor = System.Drawing.Color.FromArgb(85, 85, 85);
            this.lblSlotEnd.Location = new System.Drawing.Point(392, 50);
            this.lblSlotEnd.Text = "End time";
            // 
            // dtpSlotDate
            // 
            this.dtpSlotDate.Name = "dtpSlotDate";
            this.dtpSlotDate.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dtpSlotDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpSlotDate.Location = new System.Drawing.Point(22, 74);
            this.dtpSlotDate.Size = new System.Drawing.Size(180, 30);
            // 
            // dtpSlotStart
            // 
            this.dtpSlotStart.Name = "dtpSlotStart";
            this.dtpSlotStart.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dtpSlotStart.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpSlotStart.Location = new System.Drawing.Point(222, 74);
            this.dtpSlotStart.ShowUpDown = true;
            this.dtpSlotStart.Size = new System.Drawing.Size(150, 30);
            // 
            // dtpSlotEnd
            // 
            this.dtpSlotEnd.Name = "dtpSlotEnd";
            this.dtpSlotEnd.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dtpSlotEnd.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpSlotEnd.Location = new System.Drawing.Point(392, 74);
            this.dtpSlotEnd.ShowUpDown = true;
            this.dtpSlotEnd.Size = new System.Drawing.Size(150, 30);
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
            this.btnAddSlot.Location = new System.Drawing.Point(565, 73);
            this.btnAddSlot.Size = new System.Drawing.Size(170, 32);
            this.btnAddSlot.Text = "＋  Add date & slot";
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
            this.dgvSlots.ColumnHeadersHeight = 40;
            this.dgvSlots.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvSlots.EnableHeadersVisualStyles = false;
            this.dgvSlots.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dgvSlots.GridColor = System.Drawing.Color.FromArgb(210, 210, 210);
            this.dgvSlots.Location = new System.Drawing.Point(22, 118);
            this.dgvSlots.MultiSelect = false;
            this.dgvSlots.ReadOnly = true;
            this.dgvSlots.RowHeadersVisible = false;
            this.dgvSlots.RowTemplate.Height = 40;
            this.dgvSlots.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSlots.Size = new System.Drawing.Size(1290, 100);
            this.dgvSlots.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            // 
            // colSlotDate
            // 
            this.colSlotDate.Name = "colSlotDate";
            this.colSlotDate.HeaderText = "DATE";
            this.colSlotDate.Width = 210;
            this.colSlotDate.ReadOnly = true;
            this.colSlotDate.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // colSlotStart
            // 
            this.colSlotStart.Name = "colSlotStart";
            this.colSlotStart.HeaderText = "START TIME";
            this.colSlotStart.Width = 190;
            this.colSlotStart.ReadOnly = true;
            this.colSlotStart.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // colSlotEnd
            // 
            this.colSlotEnd.Name = "colSlotEnd";
            this.colSlotEnd.HeaderText = "END TIME";
            this.colSlotEnd.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colSlotEnd.ReadOnly = true;
            this.colSlotEnd.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // cardBlocks
            // 
            this.cardBlocks.Controls.Add(this.lblBlocksTitle);
            this.cardBlocks.Controls.Add(this.lblBlockRoom);
            this.cardBlocks.Controls.Add(this.lblBlockDate);
            this.cardBlocks.Controls.Add(this.lblBlockSlot);
            this.cardBlocks.Controls.Add(this.cboRoom);
            this.cardBlocks.Controls.Add(this.dtpBlockDate);
            this.cardBlocks.Controls.Add(this.cboSlot);
            this.cardBlocks.Controls.Add(this.btnMarkUnavailable);
            this.cardBlocks.Controls.Add(this.dgvBlocks);
            this.cardBlocks.Name = "cardBlocks";
            this.cardBlocks.Location = new System.Drawing.Point(0, 0);
            this.cardBlocks.Size = new System.Drawing.Size(1334, 246);
            this.cardBlocks.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cardBlocks.Margin = new System.Windows.Forms.Padding(0, 0, 6, 16);
            // 
            // lblBlocksTitle
            // 
            this.lblBlocksTitle.Name = "lblBlocksTitle";
            this.lblBlocksTitle.AutoSize = true;
            this.lblBlocksTitle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblBlocksTitle.ForeColor = System.Drawing.Color.FromArgb(20, 20, 20);
            this.lblBlocksTitle.Location = new System.Drawing.Point(20, 16);
            this.lblBlocksTitle.Text = "03  ·  ROOM UNAVAILABILITY";
            // 
            // lblBlockRoom
            // 
            this.lblBlockRoom.Name = "lblBlockRoom";
            this.lblBlockRoom.AutoSize = true;
            this.lblBlockRoom.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblBlockRoom.ForeColor = System.Drawing.Color.FromArgb(85, 85, 85);
            this.lblBlockRoom.Location = new System.Drawing.Point(22, 50);
            this.lblBlockRoom.Text = "Select room";
            // 
            // lblBlockDate
            // 
            this.lblBlockDate.Name = "lblBlockDate";
            this.lblBlockDate.AutoSize = true;
            this.lblBlockDate.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblBlockDate.ForeColor = System.Drawing.Color.FromArgb(85, 85, 85);
            this.lblBlockDate.Location = new System.Drawing.Point(232, 50);
            this.lblBlockDate.Text = "Select date";
            // 
            // lblBlockSlot
            // 
            this.lblBlockSlot.Name = "lblBlockSlot";
            this.lblBlockSlot.AutoSize = true;
            this.lblBlockSlot.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblBlockSlot.ForeColor = System.Drawing.Color.FromArgb(85, 85, 85);
            this.lblBlockSlot.Location = new System.Drawing.Point(432, 50);
            this.lblBlockSlot.Text = "Select time slot";
            // 
            // cboRoom
            // 
            this.cboRoom.Name = "cboRoom";
            this.cboRoom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboRoom.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cboRoom.FormattingEnabled = true;
            this.cboRoom.Location = new System.Drawing.Point(22, 74);
            this.cboRoom.Size = new System.Drawing.Size(190, 30);
            // 
            // dtpBlockDate
            // 
            this.dtpBlockDate.Name = "dtpBlockDate";
            this.dtpBlockDate.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dtpBlockDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpBlockDate.Location = new System.Drawing.Point(232, 74);
            this.dtpBlockDate.Size = new System.Drawing.Size(180, 30);
            this.dtpBlockDate.ValueChanged += new System.EventHandler(this.dtpBlockDate_ValueChanged);
            // 
            // cboSlot
            // 
            this.cboSlot.Name = "cboSlot";
            this.cboSlot.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSlot.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cboSlot.FormattingEnabled = true;
            this.cboSlot.Location = new System.Drawing.Point(432, 74);
            this.cboSlot.Size = new System.Drawing.Size(250, 30);
            // 
            // btnMarkUnavailable
            // 
            this.btnMarkUnavailable.Name = "btnMarkUnavailable";
            this.btnMarkUnavailable.BackColor = System.Drawing.Color.FromArgb(235, 235, 235);
            this.btnMarkUnavailable.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMarkUnavailable.FlatAppearance.BorderSize = 0;
            this.btnMarkUnavailable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMarkUnavailable.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnMarkUnavailable.ForeColor = System.Drawing.Color.FromArgb(45, 45, 45);
            this.btnMarkUnavailable.Location = new System.Drawing.Point(700, 73);
            this.btnMarkUnavailable.Size = new System.Drawing.Size(215, 32);
            this.btnMarkUnavailable.Text = "Mark room as unavailable";
            this.btnMarkUnavailable.UseVisualStyleBackColor = false;
            this.btnMarkUnavailable.Click += new System.EventHandler(this.btnMarkUnavailable_Click);
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
            this.dgvBlocks.ColumnHeadersHeight = 40;
            this.dgvBlocks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvBlocks.EnableHeadersVisualStyles = false;
            this.dgvBlocks.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dgvBlocks.GridColor = System.Drawing.Color.FromArgb(210, 210, 210);
            this.dgvBlocks.Location = new System.Drawing.Point(22, 118);
            this.dgvBlocks.MultiSelect = false;
            this.dgvBlocks.ReadOnly = true;
            this.dgvBlocks.RowHeadersVisible = false;
            this.dgvBlocks.RowTemplate.Height = 40;
            this.dgvBlocks.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBlocks.Size = new System.Drawing.Size(1290, 112);
            this.dgvBlocks.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            // 
            // colBlockRoom
            // 
            this.colBlockRoom.Name = "colBlockRoom";
            this.colBlockRoom.HeaderText = "ROOM";
            this.colBlockRoom.Width = 210;
            this.colBlockRoom.ReadOnly = true;
            this.colBlockRoom.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // colBlockDate
            // 
            this.colBlockDate.Name = "colBlockDate";
            this.colBlockDate.HeaderText = "DATE";
            this.colBlockDate.Width = 190;
            this.colBlockDate.ReadOnly = true;
            this.colBlockDate.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // colBlockSlot
            // 
            this.colBlockSlot.Name = "colBlockSlot";
            this.colBlockSlot.HeaderText = "UNAVAILABLE TIME SLOT";
            this.colBlockSlot.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colBlockSlot.ReadOnly = true;
            this.colBlockSlot.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // RoomsPage
            // 
            this.Controls.Add(this.tlpRoot);
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(250, 250, 250);
            this.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AutoScroll = true;
            this.AutoScrollMinSize = new System.Drawing.Size(900, 870);
            this.Size = new System.Drawing.Size(1340, 868);
            this.Name = "RoomsPage";
            this.tlpRoot.ResumeLayout(false);
            this.tlpRoot.PerformLayout();
            this.pnlHeader.ResumeLayout(false);
            this.cardRooms.ResumeLayout(false);
            this.cardSlots.ResumeLayout(false);
            this.cardBlocks.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nudCapacity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRooms)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSlots)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBlocks)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpRoot;
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblHeading;
        private System.Windows.Forms.Button btnOpenResources;
        private SmartCampus.CardPanel cardRooms;
        private System.Windows.Forms.Label lblRoomsTitle;
        private System.Windows.Forms.Label lblRoomName;
        private System.Windows.Forms.Label lblBuilding;
        private System.Windows.Forms.Label lblCapacity;
        private System.Windows.Forms.TextBox txtRoomName;
        private System.Windows.Forms.TextBox txtBuilding;
        private System.Windows.Forms.NumericUpDown nudCapacity;
        private System.Windows.Forms.Button btnAddRoom;
        private System.Windows.Forms.Button btnRemoveRoom;
        private System.Windows.Forms.DataGridView dgvRooms;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRoomName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRoomBuilding;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRoomCapacity;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRoomState;
        private SmartCampus.CardPanel cardSlots;
        private System.Windows.Forms.Label lblSlotsTitle;
        private System.Windows.Forms.Label lblSlotDate;
        private System.Windows.Forms.Label lblSlotStart;
        private System.Windows.Forms.Label lblSlotEnd;
        private System.Windows.Forms.DateTimePicker dtpSlotDate;
        private System.Windows.Forms.DateTimePicker dtpSlotStart;
        private System.Windows.Forms.DateTimePicker dtpSlotEnd;
        private System.Windows.Forms.Button btnAddSlot;
        private System.Windows.Forms.DataGridView dgvSlots;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSlotDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSlotStart;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSlotEnd;
        private SmartCampus.CardPanel cardBlocks;
        private System.Windows.Forms.Label lblBlocksTitle;
        private System.Windows.Forms.Label lblBlockRoom;
        private System.Windows.Forms.Label lblBlockDate;
        private System.Windows.Forms.Label lblBlockSlot;
        private System.Windows.Forms.ComboBox cboRoom;
        private System.Windows.Forms.DateTimePicker dtpBlockDate;
        private System.Windows.Forms.ComboBox cboSlot;
        private System.Windows.Forms.Button btnMarkUnavailable;
        private System.Windows.Forms.DataGridView dgvBlocks;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBlockRoom;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBlockDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBlockSlot;
    }
}
