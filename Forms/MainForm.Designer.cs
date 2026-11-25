#nullable disable
namespace SmartCampus
{
    partial class MainForm
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
            this.lblToast = new System.Windows.Forms.Label();
            this.pnlContent = new System.Windows.Forms.Panel();
            this.pnlSidebar = new System.Windows.Forms.Panel();
            this.lblBrandMark = new System.Windows.Forms.Label();
            this.lblBrandTitle = new System.Windows.Forms.Label();
            this.lblBrandSub = new System.Windows.Forms.Label();
            this.lblWorkspace = new System.Windows.Forms.Label();
            this.btnNavDashboard = new System.Windows.Forms.Button();
            this.btnNavStudents = new System.Windows.Forms.Button();
            this.btnNavAttendance = new System.Windows.Forms.Button();
            this.btnNavRooms = new System.Windows.Forms.Button();
            this.btnNavAnnouncements = new System.Windows.Forms.Button();
            this.btnNavServer = new System.Windows.Forms.Button();
            this.lblSystem = new System.Windows.Forms.Label();
            this.btnSettings = new System.Windows.Forms.Button();
            this.pnlServerCard = new SmartCampus.CardPanel();
            this.lblServerCardTitle = new System.Windows.Forms.Label();
            this.lblServerCardPort = new System.Windows.Forms.Label();
            this.pnlTopbar = new System.Windows.Forms.Panel();
            this.btnMenu = new System.Windows.Forms.Button();
            this.lblPageTitle = new System.Windows.Forms.Label();
            this.flowTopRight = new System.Windows.Forms.FlowLayoutPanel();
            this.lblClock = new System.Windows.Forms.Label();
            this.lblServerBadge = new System.Windows.Forms.Label();
            this.lblProfile = new System.Windows.Forms.Label();
            this.tmrNav = new System.Windows.Forms.Timer(this.components);
            this.tmrClock = new System.Windows.Forms.Timer(this.components);
            this.tmrToast = new System.Windows.Forms.Timer(this.components);
            this.tmrPulse = new System.Windows.Forms.Timer(this.components);
            this.pnlContent.SuspendLayout();
            this.pnlSidebar.SuspendLayout();
            this.pnlServerCard.SuspendLayout();
            this.pnlTopbar.SuspendLayout();
            this.flowTopRight.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblToast
            // 
            this.lblToast.Name = "lblToast";
            this.lblToast.AutoSize = true;
            this.lblToast.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            this.lblToast.BackColor = System.Drawing.Color.FromArgb(232, 232, 232);
            this.lblToast.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblToast.ForeColor = System.Drawing.Color.FromArgb(20, 20, 20);
            this.lblToast.Location = new System.Drawing.Point(1000, 790);
            this.lblToast.Padding = new System.Windows.Forms.Padding(16, 12, 16, 12);
            this.lblToast.Text = "✓";
            this.lblToast.Visible = false;
            // 
            // pnlContent
            // 
            this.pnlContent.Name = "pnlContent";
            this.pnlContent.BackColor = System.Drawing.Color.FromArgb(250, 250, 250);
            this.pnlContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContent.Location = new System.Drawing.Point(278, 96);
            this.pnlContent.Padding = new System.Windows.Forms.Padding(34, 30, 34, 28);
            this.pnlContent.Size = new System.Drawing.Size(1146, 765);
            // 
            // pnlSidebar
            // 
            this.pnlSidebar.Controls.Add(this.lblBrandMark);
            this.pnlSidebar.Controls.Add(this.lblBrandTitle);
            this.pnlSidebar.Controls.Add(this.lblBrandSub);
            this.pnlSidebar.Controls.Add(this.lblWorkspace);
            this.pnlSidebar.Controls.Add(this.btnNavDashboard);
            this.pnlSidebar.Controls.Add(this.btnNavStudents);
            this.pnlSidebar.Controls.Add(this.btnNavAttendance);
            this.pnlSidebar.Controls.Add(this.btnNavRooms);
            this.pnlSidebar.Controls.Add(this.btnNavAnnouncements);
            this.pnlSidebar.Controls.Add(this.btnNavServer);
            this.pnlSidebar.Controls.Add(this.lblSystem);
            this.pnlSidebar.Controls.Add(this.btnSettings);
            this.pnlSidebar.Controls.Add(this.pnlServerCard);
            this.pnlSidebar.Name = "pnlSidebar";
            this.pnlSidebar.BackColor = System.Drawing.Color.White;
            this.pnlSidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlSidebar.Location = new System.Drawing.Point(0, 96);
            this.pnlSidebar.Size = new System.Drawing.Size(278, 765);
            // 
            // lblBrandMark
            // 
            this.lblBrandMark.Name = "lblBrandMark";
            this.lblBrandMark.BackColor = System.Drawing.Color.White;
            this.lblBrandMark.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblBrandMark.ForeColor = System.Drawing.Color.Black;
            this.lblBrandMark.Location = new System.Drawing.Point(20, 18);
            this.lblBrandMark.Size = new System.Drawing.Size(48, 48);
            this.lblBrandMark.Text = "✳";
            this.lblBrandMark.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblBrandTitle
            // 
            this.lblBrandTitle.Name = "lblBrandTitle";
            this.lblBrandTitle.AutoSize = true;
            this.lblBrandTitle.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblBrandTitle.ForeColor = System.Drawing.Color.FromArgb(20, 20, 20);
            this.lblBrandTitle.Location = new System.Drawing.Point(82, 12);
            this.lblBrandTitle.Text = "SC";
            // 
            // lblBrandSub
            // 
            this.lblBrandSub.Name = "lblBrandSub";
            this.lblBrandSub.AutoSize = true;
            this.lblBrandSub.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblBrandSub.ForeColor = System.Drawing.Color.FromArgb(85, 85, 85);
            this.lblBrandSub.Location = new System.Drawing.Point(84, 50);
            this.lblBrandSub.Text = "CAMPUS";
            // 
            // lblWorkspace
            // 
            this.lblWorkspace.Name = "lblWorkspace";
            this.lblWorkspace.AutoSize = true;
            this.lblWorkspace.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblWorkspace.ForeColor = System.Drawing.Color.FromArgb(85, 85, 85);
            this.lblWorkspace.Location = new System.Drawing.Point(18, 100);
            this.lblWorkspace.Text = "WORKSPACE";
            // 
            // btnNavDashboard
            // 
            this.btnNavDashboard.Name = "btnNavDashboard";
            this.btnNavDashboard.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            this.btnNavDashboard.BackColor = System.Drawing.Color.White;
            this.btnNavDashboard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNavDashboard.FlatAppearance.BorderSize = 0;
            this.btnNavDashboard.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(242, 242, 242);
            this.btnNavDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNavDashboard.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnNavDashboard.ForeColor = System.Drawing.Color.FromArgb(20, 20, 20);
            this.btnNavDashboard.Location = new System.Drawing.Point(12, 130);
            this.btnNavDashboard.Size = new System.Drawing.Size(246, 44);
            this.btnNavDashboard.Tag = "Dashboard";
            this.btnNavDashboard.Text = "   ◫     Dashboard";
            this.btnNavDashboard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNavDashboard.UseVisualStyleBackColor = false;
            this.btnNavDashboard.Click += new System.EventHandler(this.NavButton_Click);
            // 
            // btnNavStudents
            // 
            this.btnNavStudents.Name = "btnNavStudents";
            this.btnNavStudents.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            this.btnNavStudents.BackColor = System.Drawing.Color.White;
            this.btnNavStudents.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNavStudents.FlatAppearance.BorderSize = 0;
            this.btnNavStudents.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(242, 242, 242);
            this.btnNavStudents.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNavStudents.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnNavStudents.ForeColor = System.Drawing.Color.FromArgb(20, 20, 20);
            this.btnNavStudents.Location = new System.Drawing.Point(12, 180);
            this.btnNavStudents.Size = new System.Drawing.Size(246, 44);
            this.btnNavStudents.Tag = "Students";
            this.btnNavStudents.Text = "   ♙     Students";
            this.btnNavStudents.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNavStudents.UseVisualStyleBackColor = false;
            this.btnNavStudents.Click += new System.EventHandler(this.NavButton_Click);
            // 
            // btnNavAttendance
            // 
            this.btnNavAttendance.Name = "btnNavAttendance";
            this.btnNavAttendance.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            this.btnNavAttendance.BackColor = System.Drawing.Color.White;
            this.btnNavAttendance.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNavAttendance.FlatAppearance.BorderSize = 0;
            this.btnNavAttendance.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(242, 242, 242);
            this.btnNavAttendance.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNavAttendance.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnNavAttendance.ForeColor = System.Drawing.Color.FromArgb(20, 20, 20);
            this.btnNavAttendance.Location = new System.Drawing.Point(12, 230);
            this.btnNavAttendance.Size = new System.Drawing.Size(246, 44);
            this.btnNavAttendance.Tag = "Attendance";
            this.btnNavAttendance.Text = "   ◷     Attendance";
            this.btnNavAttendance.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNavAttendance.UseVisualStyleBackColor = false;
            this.btnNavAttendance.Click += new System.EventHandler(this.NavButton_Click);
            // 
            // btnNavRooms
            // 
            this.btnNavRooms.Name = "btnNavRooms";
            this.btnNavRooms.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            this.btnNavRooms.BackColor = System.Drawing.Color.White;
            this.btnNavRooms.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNavRooms.FlatAppearance.BorderSize = 0;
            this.btnNavRooms.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(242, 242, 242);
            this.btnNavRooms.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNavRooms.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnNavRooms.ForeColor = System.Drawing.Color.FromArgb(20, 20, 20);
            this.btnNavRooms.Location = new System.Drawing.Point(12, 280);
            this.btnNavRooms.Size = new System.Drawing.Size(246, 44);
            this.btnNavRooms.Tag = "Rooms";
            this.btnNavRooms.Text = "   ▦     Rooms";
            this.btnNavRooms.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNavRooms.UseVisualStyleBackColor = false;
            this.btnNavRooms.Click += new System.EventHandler(this.NavButton_Click);
            // 
            // btnNavAnnouncements
            // 
            this.btnNavAnnouncements.Name = "btnNavAnnouncements";
            this.btnNavAnnouncements.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            this.btnNavAnnouncements.BackColor = System.Drawing.Color.White;
            this.btnNavAnnouncements.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNavAnnouncements.FlatAppearance.BorderSize = 0;
            this.btnNavAnnouncements.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(242, 242, 242);
            this.btnNavAnnouncements.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNavAnnouncements.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnNavAnnouncements.ForeColor = System.Drawing.Color.FromArgb(20, 20, 20);
            this.btnNavAnnouncements.Location = new System.Drawing.Point(12, 330);
            this.btnNavAnnouncements.Size = new System.Drawing.Size(246, 44);
            this.btnNavAnnouncements.Tag = "Announcements";
            this.btnNavAnnouncements.Text = "   ◉     Announcements";
            this.btnNavAnnouncements.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNavAnnouncements.UseVisualStyleBackColor = false;
            this.btnNavAnnouncements.Click += new System.EventHandler(this.NavButton_Click);
            // 
            // btnNavServer
            // 
            this.btnNavServer.Name = "btnNavServer";
            this.btnNavServer.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            this.btnNavServer.BackColor = System.Drawing.Color.White;
            this.btnNavServer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNavServer.FlatAppearance.BorderSize = 0;
            this.btnNavServer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(242, 242, 242);
            this.btnNavServer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNavServer.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnNavServer.ForeColor = System.Drawing.Color.FromArgb(20, 20, 20);
            this.btnNavServer.Location = new System.Drawing.Point(12, 380);
            this.btnNavServer.Size = new System.Drawing.Size(246, 44);
            this.btnNavServer.Tag = "Server & API";
            this.btnNavServer.Text = "   ⇄     Server & API";
            this.btnNavServer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNavServer.UseVisualStyleBackColor = false;
            this.btnNavServer.Click += new System.EventHandler(this.NavButton_Click);
            // 
            // lblSystem
            // 
            this.lblSystem.Name = "lblSystem";
            this.lblSystem.AutoSize = true;
            this.lblSystem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSystem.ForeColor = System.Drawing.Color.FromArgb(85, 85, 85);
            this.lblSystem.Location = new System.Drawing.Point(18, 442);
            this.lblSystem.Text = "SYSTEM";
            // 
            // btnSettings
            // 
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            this.btnSettings.BackColor = System.Drawing.Color.White;
            this.btnSettings.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSettings.FlatAppearance.BorderSize = 0;
            this.btnSettings.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(242, 242, 242);
            this.btnSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSettings.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSettings.ForeColor = System.Drawing.Color.FromArgb(85, 85, 85);
            this.btnSettings.Location = new System.Drawing.Point(12, 470);
            this.btnSettings.Size = new System.Drawing.Size(246, 44);
            this.btnSettings.Text = "   ⚙     Settings";
            this.btnSettings.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSettings.UseVisualStyleBackColor = false;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // pnlServerCard
            // 
            this.pnlServerCard.Controls.Add(this.lblServerCardTitle);
            this.pnlServerCard.Controls.Add(this.lblServerCardPort);
            this.pnlServerCard.Name = "pnlServerCard";
            this.pnlServerCard.Location = new System.Drawing.Point(15, 690);
            this.pnlServerCard.Size = new System.Drawing.Size(243, 62);
            this.pnlServerCard.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            // 
            // lblServerCardTitle
            // 
            this.lblServerCardTitle.Name = "lblServerCardTitle";
            this.lblServerCardTitle.AutoSize = true;
            this.lblServerCardTitle.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblServerCardTitle.ForeColor = System.Drawing.Color.FromArgb(20, 20, 20);
            this.lblServerCardTitle.Location = new System.Drawing.Point(11, 9);
            this.lblServerCardTitle.Text = "◉   CAMPUS SERVER";
            // 
            // lblServerCardPort
            // 
            this.lblServerCardPort.Name = "lblServerCardPort";
            this.lblServerCardPort.AutoSize = true;
            this.lblServerCardPort.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblServerCardPort.ForeColor = System.Drawing.Color.FromArgb(20, 20, 20);
            this.lblServerCardPort.Location = new System.Drawing.Point(11, 32);
            this.lblServerCardPort.Text = "Listening on :5088";
            // 
            // pnlTopbar
            // 
            this.pnlTopbar.Controls.Add(this.btnMenu);
            this.pnlTopbar.Controls.Add(this.lblPageTitle);
            this.pnlTopbar.Controls.Add(this.flowTopRight);
            this.pnlTopbar.Name = "pnlTopbar";
            this.pnlTopbar.BackColor = System.Drawing.Color.White;
            this.pnlTopbar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTopbar.Location = new System.Drawing.Point(0, 0);
            this.pnlTopbar.Size = new System.Drawing.Size(1424, 96);
            // 
            // btnMenu
            // 
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.BackColor = System.Drawing.Color.FromArgb(232, 232, 232);
            this.btnMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMenu.FlatAppearance.BorderSize = 0;
            this.btnMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenu.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnMenu.ForeColor = System.Drawing.Color.FromArgb(20, 20, 20);
            this.btnMenu.Location = new System.Drawing.Point(22, 25);
            this.btnMenu.Size = new System.Drawing.Size(46, 46);
            this.btnMenu.Text = "☰";
            this.btnMenu.UseVisualStyleBackColor = false;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // lblPageTitle
            // 
            this.lblPageTitle.Name = "lblPageTitle";
            this.lblPageTitle.AutoSize = true;
            this.lblPageTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPageTitle.ForeColor = System.Drawing.Color.FromArgb(20, 20, 20);
            this.lblPageTitle.Location = new System.Drawing.Point(84, 26);
            this.lblPageTitle.Text = "Dashboard";
            // 
            // flowTopRight
            // 
            this.flowTopRight.Controls.Add(this.lblClock);
            this.flowTopRight.Controls.Add(this.lblServerBadge);
            this.flowTopRight.Controls.Add(this.lblProfile);
            this.flowTopRight.Name = "flowTopRight";
            this.flowTopRight.AutoSize = true;
            this.flowTopRight.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowTopRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.flowTopRight.Location = new System.Drawing.Point(900, 0);
            this.flowTopRight.Padding = new System.Windows.Forms.Padding(0, 0, 28, 0);
            this.flowTopRight.Size = new System.Drawing.Size(524, 96);
            this.flowTopRight.WrapContents = false;
            // 
            // lblClock
            // 
            this.lblClock.Name = "lblClock";
            this.lblClock.AutoSize = true;
            this.lblClock.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblClock.ForeColor = System.Drawing.Color.FromArgb(85, 85, 85);
            this.lblClock.Location = new System.Drawing.Point(0, 38);
            this.lblClock.Margin = new System.Windows.Forms.Padding(0, 38, 26, 0);
            this.lblClock.Text = "Wed, Nov 25  ·  09:00 AM";
            // 
            // lblServerBadge
            // 
            this.lblServerBadge.Name = "lblServerBadge";
            this.lblServerBadge.AutoSize = true;
            this.lblServerBadge.BackColor = System.Drawing.Color.FromArgb(235, 235, 235);
            this.lblServerBadge.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblServerBadge.ForeColor = System.Drawing.Color.FromArgb(35, 35, 35);
            this.lblServerBadge.Location = new System.Drawing.Point(200, 29);
            this.lblServerBadge.Margin = new System.Windows.Forms.Padding(0, 29, 16, 0);
            this.lblServerBadge.Padding = new System.Windows.Forms.Padding(12, 9, 12, 9);
            this.lblServerBadge.Text = "●  Server online  ·  :5088";
            // 
            // lblProfile
            // 
            this.lblProfile.Name = "lblProfile";
            this.lblProfile.BackColor = System.Drawing.Color.FromArgb(232, 232, 232);
            this.lblProfile.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblProfile.ForeColor = System.Drawing.Color.FromArgb(20, 20, 20);
            this.lblProfile.Location = new System.Drawing.Point(450, 27);
            this.lblProfile.Margin = new System.Windows.Forms.Padding(0, 27, 0, 0);
            this.lblProfile.Size = new System.Drawing.Size(42, 42);
            this.lblProfile.Text = "AM";
            this.lblProfile.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tmrNav
            // 
            this.tmrNav.Interval = 15;
            this.tmrNav.Tick += new System.EventHandler(this.tmrNav_Tick);
            // 
            // tmrClock
            // 
            this.tmrClock.Interval = 1000;
            this.tmrClock.Tick += new System.EventHandler(this.tmrClock_Tick);
            // 
            // tmrToast
            // 
            this.tmrToast.Interval = 2600;
            this.tmrToast.Tick += new System.EventHandler(this.tmrToast_Tick);
            // 
            // tmrPulse
            // 
            this.tmrPulse.Interval = 850;
            this.tmrPulse.Tick += new System.EventHandler(this.tmrPulse_Tick);
            // 
            // MainForm
            // 
            this.Controls.Add(this.lblToast);
            this.Controls.Add(this.pnlContent);
            this.Controls.Add(this.pnlSidebar);
            this.Controls.Add(this.pnlTopbar);
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(250, 250, 250);
            this.ClientSize = new System.Drawing.Size(1424, 861);
            this.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MinimumSize = new System.Drawing.Size(1120, 740);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Integrated Smart Campus | Campus Administration";
            this.Name = "MainForm";
            this.Resize += new System.EventHandler(this.MainForm_Resize);
            this.Shown += new System.EventHandler(this.MainForm_Shown);
            this.pnlContent.ResumeLayout(false);
            this.pnlSidebar.ResumeLayout(false);
            this.pnlServerCard.ResumeLayout(false);
            this.pnlTopbar.ResumeLayout(false);
            this.flowTopRight.ResumeLayout(false);
            this.flowTopRight.PerformLayout();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Label lblToast;
        private System.Windows.Forms.Panel pnlContent;
        private System.Windows.Forms.Panel pnlSidebar;
        private System.Windows.Forms.Label lblBrandMark;
        private System.Windows.Forms.Label lblBrandTitle;
        private System.Windows.Forms.Label lblBrandSub;
        private System.Windows.Forms.Label lblWorkspace;
        private System.Windows.Forms.Button btnNavDashboard;
        private System.Windows.Forms.Button btnNavStudents;
        private System.Windows.Forms.Button btnNavAttendance;
        private System.Windows.Forms.Button btnNavRooms;
        private System.Windows.Forms.Button btnNavAnnouncements;
        private System.Windows.Forms.Button btnNavServer;
        private System.Windows.Forms.Label lblSystem;
        private System.Windows.Forms.Button btnSettings;
        private SmartCampus.CardPanel pnlServerCard;
        private System.Windows.Forms.Label lblServerCardTitle;
        private System.Windows.Forms.Label lblServerCardPort;
        private System.Windows.Forms.Panel pnlTopbar;
        private System.Windows.Forms.Button btnMenu;
        private System.Windows.Forms.Label lblPageTitle;
        private System.Windows.Forms.FlowLayoutPanel flowTopRight;
        private System.Windows.Forms.Label lblClock;
        private System.Windows.Forms.Label lblServerBadge;
        private System.Windows.Forms.Label lblProfile;
        private System.Windows.Forms.Timer tmrNav;
        private System.Windows.Forms.Timer tmrClock;
        private System.Windows.Forms.Timer tmrToast;
        private System.Windows.Forms.Timer tmrPulse;
    }
}
