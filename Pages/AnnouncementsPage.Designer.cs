#nullable disable
namespace SmartCampus
{
    partial class AnnouncementsPage
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
            this.flowRecent = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlRecentHeader = new System.Windows.Forms.Panel();
            this.lblRecent = new System.Windows.Forms.Label();
            this.pnlCreateHost = new System.Windows.Forms.Panel();
            this.cardCreate = new SmartCampus.CardPanel();
            this.lblCreateTitle = new System.Windows.Forms.Label();
            this.lblTitleCaption = new System.Windows.Forms.Label();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.lblMessageCaption = new System.Windows.Forms.Label();
            this.txtMessage = new System.Windows.Forms.TextBox();
            this.btnPublish = new System.Windows.Forms.Button();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblHeading = new System.Windows.Forms.Label();
            this.flowRecent.SuspendLayout();
            this.pnlRecentHeader.SuspendLayout();
            this.pnlCreateHost.SuspendLayout();
            this.cardCreate.SuspendLayout();
            this.pnlHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowRecent
            // 
            this.flowRecent.Name = "flowRecent";
            this.flowRecent.AutoScroll = true;
            this.flowRecent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowRecent.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowRecent.Location = new System.Drawing.Point(0, 490);
            this.flowRecent.Size = new System.Drawing.Size(1340, 270);
            this.flowRecent.WrapContents = false;
            // 
            // pnlRecentHeader
            // 
            this.pnlRecentHeader.Controls.Add(this.lblRecent);
            this.pnlRecentHeader.Name = "pnlRecentHeader";
            this.pnlRecentHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlRecentHeader.Location = new System.Drawing.Point(0, 442);
            this.pnlRecentHeader.Size = new System.Drawing.Size(1340, 48);
            // 
            // lblRecent
            // 
            this.lblRecent.Name = "lblRecent";
            this.lblRecent.AutoSize = true;
            this.lblRecent.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblRecent.ForeColor = System.Drawing.Color.FromArgb(20, 20, 20);
            this.lblRecent.Location = new System.Drawing.Point(0, 10);
            this.lblRecent.Text = "Recent notifications";
            // 
            // pnlCreateHost
            // 
            this.pnlCreateHost.Controls.Add(this.cardCreate);
            this.pnlCreateHost.Name = "pnlCreateHost";
            this.pnlCreateHost.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlCreateHost.Location = new System.Drawing.Point(0, 62);
            this.pnlCreateHost.Size = new System.Drawing.Size(1340, 380);
            // 
            // cardCreate
            // 
            this.cardCreate.Controls.Add(this.lblCreateTitle);
            this.cardCreate.Controls.Add(this.lblTitleCaption);
            this.cardCreate.Controls.Add(this.txtTitle);
            this.cardCreate.Controls.Add(this.lblMessageCaption);
            this.cardCreate.Controls.Add(this.txtMessage);
            this.cardCreate.Controls.Add(this.btnPublish);
            this.cardCreate.Name = "cardCreate";
            this.cardCreate.Location = new System.Drawing.Point(0, 0);
            this.cardCreate.Size = new System.Drawing.Size(690, 360);
            // 
            // lblCreateTitle
            // 
            this.lblCreateTitle.Name = "lblCreateTitle";
            this.lblCreateTitle.AutoSize = true;
            this.lblCreateTitle.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCreateTitle.ForeColor = System.Drawing.Color.FromArgb(20, 20, 20);
            this.lblCreateTitle.Location = new System.Drawing.Point(22, 18);
            this.lblCreateTitle.Text = "Create announcement";
            // 
            // lblTitleCaption
            // 
            this.lblTitleCaption.Name = "lblTitleCaption";
            this.lblTitleCaption.AutoSize = true;
            this.lblTitleCaption.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTitleCaption.ForeColor = System.Drawing.Color.FromArgb(85, 85, 85);
            this.lblTitleCaption.Location = new System.Drawing.Point(23, 62);
            this.lblTitleCaption.Text = "TITLE";
            // 
            // txtTitle
            // 
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTitle.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtTitle.Location = new System.Drawing.Point(23, 84);
            this.txtTitle.Size = new System.Drawing.Size(644, 32);
            this.txtTitle.PlaceholderText = "e.g. Midterm schedule published";
            this.txtTitle.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            // 
            // lblMessageCaption
            // 
            this.lblMessageCaption.Name = "lblMessageCaption";
            this.lblMessageCaption.AutoSize = true;
            this.lblMessageCaption.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblMessageCaption.ForeColor = System.Drawing.Color.FromArgb(85, 85, 85);
            this.lblMessageCaption.Location = new System.Drawing.Point(23, 134);
            this.lblMessageCaption.Text = "MESSAGE";
            // 
            // txtMessage
            // 
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMessage.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtMessage.Location = new System.Drawing.Point(23, 156);
            this.txtMessage.Size = new System.Drawing.Size(644, 110);
            this.txtMessage.Multiline = true;
            this.txtMessage.PlaceholderText = "Write a clear message for students and staff...";
            this.txtMessage.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            // 
            // btnPublish
            // 
            this.btnPublish.Name = "btnPublish";
            this.btnPublish.BackColor = System.Drawing.Color.FromArgb(20, 20, 20);
            this.btnPublish.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPublish.FlatAppearance.BorderSize = 0;
            this.btnPublish.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPublish.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnPublish.ForeColor = System.Drawing.Color.White;
            this.btnPublish.Location = new System.Drawing.Point(23, 290);
            this.btnPublish.Size = new System.Drawing.Size(175, 42);
            this.btnPublish.Text = "Publish notification";
            this.btnPublish.UseVisualStyleBackColor = false;
            this.btnPublish.Click += new System.EventHandler(this.btnPublish_Click);
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
            this.lblHeading.Text = "Announcements";
            // 
            // AnnouncementsPage
            // 
            this.Controls.Add(this.flowRecent);
            this.Controls.Add(this.pnlRecentHeader);
            this.Controls.Add(this.pnlCreateHost);
            this.Controls.Add(this.pnlHeader);
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(250, 250, 250);
            this.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Size = new System.Drawing.Size(1340, 760);
            this.Name = "AnnouncementsPage";
            this.flowRecent.ResumeLayout(false);
            this.flowRecent.PerformLayout();
            this.pnlRecentHeader.ResumeLayout(false);
            this.pnlCreateHost.ResumeLayout(false);
            this.cardCreate.ResumeLayout(false);
            this.pnlHeader.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowRecent;
        private System.Windows.Forms.Panel pnlRecentHeader;
        private System.Windows.Forms.Label lblRecent;
        private System.Windows.Forms.Panel pnlCreateHost;
        private SmartCampus.CardPanel cardCreate;
        private System.Windows.Forms.Label lblCreateTitle;
        private System.Windows.Forms.Label lblTitleCaption;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.Label lblMessageCaption;
        private System.Windows.Forms.TextBox txtMessage;
        private System.Windows.Forms.Button btnPublish;
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblHeading;
    }
}
