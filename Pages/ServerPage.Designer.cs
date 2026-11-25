#nullable disable
namespace SmartCampus
{
    partial class ServerPage
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
            this.lblHeading = new System.Windows.Forms.Label();
            this.tlpTop = new System.Windows.Forms.TableLayoutPanel();
            this.cardStatus = new SmartCampus.CardPanel();
            this.lblStatusCaption = new System.Windows.Forms.Label();
            this.lblStatusValue = new System.Windows.Forms.Label();
            this.lblStatusUrl = new System.Windows.Forms.Label();
            this.btnToggle = new System.Windows.Forms.Button();
            this.cardEndpoints = new SmartCampus.CardPanel();
            this.lblEndpointsCaption = new System.Windows.Forms.Label();
            this.lblEndpoint1 = new System.Windows.Forms.Label();
            this.lblEndpoint2 = new System.Windows.Forms.Label();
            this.lblEndpoint3 = new System.Windows.Forms.Label();
            this.cardDemo = new SmartCampus.CardPanel();
            this.lblDemoTitle = new System.Windows.Forms.Label();
            this.lblDemoText = new System.Windows.Forms.Label();
            this.btnSendTest = new System.Windows.Forms.Button();
            this.btnHealth = new System.Windows.Forms.Button();
            this.tlpRoot.SuspendLayout();
            this.tlpTop.SuspendLayout();
            this.cardStatus.SuspendLayout();
            this.cardEndpoints.SuspendLayout();
            this.cardDemo.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpRoot
            // 
            this.tlpRoot.ColumnCount = 1;
            this.tlpRoot.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpRoot.RowCount = 4;
            this.tlpRoot.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 62F));
            this.tlpRoot.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 184F));
            this.tlpRoot.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 240F));
            this.tlpRoot.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpRoot.Controls.Add(this.lblHeading, 0, 0);
            this.tlpRoot.Controls.Add(this.tlpTop, 0, 1);
            this.tlpRoot.Controls.Add(this.cardDemo, 0, 2);
            this.tlpRoot.Name = "tlpRoot";
            this.tlpRoot.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpRoot.Location = new System.Drawing.Point(0, 0);
            this.tlpRoot.Size = new System.Drawing.Size(1340, 700);
            // 
            // lblHeading
            // 
            this.lblHeading.Name = "lblHeading";
            this.lblHeading.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblHeading.Font = new System.Drawing.Font("Segoe UI Semibold", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblHeading.ForeColor = System.Drawing.Color.FromArgb(20, 20, 20);
            this.lblHeading.Margin = new System.Windows.Forms.Padding(0, 0, 0, 0);
            this.lblHeading.Text = "Server & API";
            this.lblHeading.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tlpTop
            // 
            this.tlpTop.ColumnCount = 2;
            this.tlpTop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 480F));
            this.tlpTop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpTop.RowCount = 1;
            this.tlpTop.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpTop.Controls.Add(this.cardStatus, 0, 0);
            this.tlpTop.Controls.Add(this.cardEndpoints, 1, 0);
            this.tlpTop.Name = "tlpTop";
            this.tlpTop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpTop.Margin = new System.Windows.Forms.Padding(0, 0, 0, 0);
            this.tlpTop.Size = new System.Drawing.Size(1340, 184);
            // 
            // cardStatus
            // 
            this.cardStatus.Controls.Add(this.lblStatusCaption);
            this.cardStatus.Controls.Add(this.lblStatusValue);
            this.cardStatus.Controls.Add(this.lblStatusUrl);
            this.cardStatus.Controls.Add(this.btnToggle);
            this.cardStatus.Name = "cardStatus";
            this.cardStatus.Location = new System.Drawing.Point(0, 0);
            this.cardStatus.Size = new System.Drawing.Size(480, 172);
            this.cardStatus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cardStatus.Margin = new System.Windows.Forms.Padding(0, 6, 12, 6);
            // 
            // lblStatusCaption
            // 
            this.lblStatusCaption.Name = "lblStatusCaption";
            this.lblStatusCaption.AutoSize = true;
            this.lblStatusCaption.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblStatusCaption.ForeColor = System.Drawing.Color.FromArgb(85, 85, 85);
            this.lblStatusCaption.Location = new System.Drawing.Point(20, 16);
            this.lblStatusCaption.Text = "SERVER STATUS";
            // 
            // lblStatusValue
            // 
            this.lblStatusValue.Name = "lblStatusValue";
            this.lblStatusValue.AutoSize = true;
            this.lblStatusValue.Font = new System.Drawing.Font("Segoe UI", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblStatusValue.ForeColor = System.Drawing.Color.FromArgb(35, 35, 35);
            this.lblStatusValue.Location = new System.Drawing.Point(20, 40);
            this.lblStatusValue.Text = "●  Online";
            // 
            // lblStatusUrl
            // 
            this.lblStatusUrl.Name = "lblStatusUrl";
            this.lblStatusUrl.AutoSize = true;
            this.lblStatusUrl.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblStatusUrl.ForeColor = System.Drawing.Color.FromArgb(20, 20, 20);
            this.lblStatusUrl.Location = new System.Drawing.Point(20, 88);
            this.lblStatusUrl.Text = "Listening on  http://127.0.0.1:5088/";
            // 
            // btnToggle
            // 
            this.btnToggle.Name = "btnToggle";
            this.btnToggle.BackColor = System.Drawing.Color.FromArgb(235, 235, 235);
            this.btnToggle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnToggle.FlatAppearance.BorderSize = 0;
            this.btnToggle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnToggle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnToggle.ForeColor = System.Drawing.Color.FromArgb(45, 45, 45);
            this.btnToggle.Location = new System.Drawing.Point(20, 124);
            this.btnToggle.Size = new System.Drawing.Size(130, 36);
            this.btnToggle.Text = "Stop server";
            this.btnToggle.UseVisualStyleBackColor = false;
            this.btnToggle.Click += new System.EventHandler(this.btnToggle_Click);
            // 
            // cardEndpoints
            // 
            this.cardEndpoints.Controls.Add(this.lblEndpointsCaption);
            this.cardEndpoints.Controls.Add(this.lblEndpoint1);
            this.cardEndpoints.Controls.Add(this.lblEndpoint2);
            this.cardEndpoints.Controls.Add(this.lblEndpoint3);
            this.cardEndpoints.Name = "cardEndpoints";
            this.cardEndpoints.Location = new System.Drawing.Point(0, 0);
            this.cardEndpoints.Size = new System.Drawing.Size(800, 172);
            this.cardEndpoints.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cardEndpoints.Margin = new System.Windows.Forms.Padding(0, 6, 0, 6);
            // 
            // lblEndpointsCaption
            // 
            this.lblEndpointsCaption.Name = "lblEndpointsCaption";
            this.lblEndpointsCaption.AutoSize = true;
            this.lblEndpointsCaption.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblEndpointsCaption.ForeColor = System.Drawing.Color.FromArgb(85, 85, 85);
            this.lblEndpointsCaption.Location = new System.Drawing.Point(18, 16);
            this.lblEndpointsCaption.Text = "AVAILABLE ENDPOINTS";
            // 
            // lblEndpoint1
            // 
            this.lblEndpoint1.Name = "lblEndpoint1";
            this.lblEndpoint1.AutoSize = true;
            this.lblEndpoint1.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblEndpoint1.ForeColor = System.Drawing.Color.FromArgb(20, 20, 20);
            this.lblEndpoint1.Location = new System.Drawing.Point(18, 48);
            this.lblEndpoint1.Text = "GET   /health";
            // 
            // lblEndpoint2
            // 
            this.lblEndpoint2.Name = "lblEndpoint2";
            this.lblEndpoint2.AutoSize = true;
            this.lblEndpoint2.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblEndpoint2.ForeColor = System.Drawing.Color.FromArgb(20, 20, 20);
            this.lblEndpoint2.Location = new System.Drawing.Point(18, 78);
            this.lblEndpoint2.Text = "GET   /notices";
            // 
            // lblEndpoint3
            // 
            this.lblEndpoint3.Name = "lblEndpoint3";
            this.lblEndpoint3.AutoSize = true;
            this.lblEndpoint3.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblEndpoint3.ForeColor = System.Drawing.Color.FromArgb(20, 20, 20);
            this.lblEndpoint3.Location = new System.Drawing.Point(18, 108);
            this.lblEndpoint3.Text = "POST /notices";
            // 
            // cardDemo
            // 
            this.cardDemo.Controls.Add(this.lblDemoTitle);
            this.cardDemo.Controls.Add(this.lblDemoText);
            this.cardDemo.Controls.Add(this.btnSendTest);
            this.cardDemo.Controls.Add(this.btnHealth);
            this.cardDemo.Name = "cardDemo";
            this.cardDemo.Location = new System.Drawing.Point(0, 0);
            this.cardDemo.Size = new System.Drawing.Size(680, 228);
            this.cardDemo.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left;
            this.cardDemo.Margin = new System.Windows.Forms.Padding(0, 6, 0, 6);
            // 
            // lblDemoTitle
            // 
            this.lblDemoTitle.Name = "lblDemoTitle";
            this.lblDemoTitle.AutoSize = true;
            this.lblDemoTitle.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDemoTitle.ForeColor = System.Drawing.Color.FromArgb(20, 20, 20);
            this.lblDemoTitle.Location = new System.Drawing.Point(20, 16);
            this.lblDemoTitle.Text = "Send a test message";
            // 
            // lblDemoText
            // 
            this.lblDemoText.Name = "lblDemoText";
            this.lblDemoText.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDemoText.ForeColor = System.Drawing.Color.FromArgb(85, 85, 85);
            this.lblDemoText.Location = new System.Drawing.Point(20, 48);
            this.lblDemoText.Size = new System.Drawing.Size(630, 40);
            this.lblDemoText.Text = "This client sends a JSON notification to the local server using HTTP over TCP.";
            // 
            // btnSendTest
            // 
            this.btnSendTest.Name = "btnSendTest";
            this.btnSendTest.BackColor = System.Drawing.Color.FromArgb(20, 20, 20);
            this.btnSendTest.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSendTest.FlatAppearance.BorderSize = 0;
            this.btnSendTest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSendTest.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSendTest.ForeColor = System.Drawing.Color.White;
            this.btnSendTest.Location = new System.Drawing.Point(20, 102);
            this.btnSendTest.Size = new System.Drawing.Size(190, 42);
            this.btnSendTest.Text = "Send test notification";
            this.btnSendTest.UseVisualStyleBackColor = false;
            this.btnSendTest.Click += new System.EventHandler(this.btnSendTest_Click);
            // 
            // btnHealth
            // 
            this.btnHealth.Name = "btnHealth";
            this.btnHealth.BackColor = System.Drawing.Color.FromArgb(232, 232, 232);
            this.btnHealth.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHealth.FlatAppearance.BorderSize = 0;
            this.btnHealth.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHealth.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnHealth.ForeColor = System.Drawing.Color.FromArgb(20, 20, 20);
            this.btnHealth.Location = new System.Drawing.Point(20, 158);
            this.btnHealth.Size = new System.Drawing.Size(195, 38);
            this.btnHealth.Text = "Open API health check ↗";
            this.btnHealth.UseVisualStyleBackColor = false;
            this.btnHealth.Click += new System.EventHandler(this.btnHealth_Click);
            // 
            // ServerPage
            // 
            this.Controls.Add(this.tlpRoot);
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(250, 250, 250);
            this.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Size = new System.Drawing.Size(1340, 700);
            this.Name = "ServerPage";
            this.tlpRoot.ResumeLayout(false);
            this.tlpRoot.PerformLayout();
            this.tlpTop.ResumeLayout(false);
            this.tlpTop.PerformLayout();
            this.cardStatus.ResumeLayout(false);
            this.cardEndpoints.ResumeLayout(false);
            this.cardDemo.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpRoot;
        private System.Windows.Forms.Label lblHeading;
        private System.Windows.Forms.TableLayoutPanel tlpTop;
        private SmartCampus.CardPanel cardStatus;
        private System.Windows.Forms.Label lblStatusCaption;
        private System.Windows.Forms.Label lblStatusValue;
        private System.Windows.Forms.Label lblStatusUrl;
        private System.Windows.Forms.Button btnToggle;
        private SmartCampus.CardPanel cardEndpoints;
        private System.Windows.Forms.Label lblEndpointsCaption;
        private System.Windows.Forms.Label lblEndpoint1;
        private System.Windows.Forms.Label lblEndpoint2;
        private System.Windows.Forms.Label lblEndpoint3;
        private SmartCampus.CardPanel cardDemo;
        private System.Windows.Forms.Label lblDemoTitle;
        private System.Windows.Forms.Label lblDemoText;
        private System.Windows.Forms.Button btnSendTest;
        private System.Windows.Forms.Button btnHealth;
    }
}
