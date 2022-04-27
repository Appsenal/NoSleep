namespace NoSleep
{
    partial class NoSleepFrm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NoSleepFrm));
            this.StartBtn = new System.Windows.Forms.Button();
            this.StopBtn = new System.Windows.Forms.Button();
            this.StatusLbl = new System.Windows.Forms.Label();
            this.HelpBtn = new System.Windows.Forms.Button();
            this.RunningPBox = new System.Windows.Forms.PictureBox();
            this.trayNotifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.trayCMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.openNoSleepToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.startToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stopToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.RunningPBox)).BeginInit();
            this.trayCMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // StartBtn
            // 
            this.StartBtn.Location = new System.Drawing.Point(12, 13);
            this.StartBtn.Name = "StartBtn";
            this.StartBtn.Size = new System.Drawing.Size(107, 37);
            this.StartBtn.TabIndex = 0;
            this.StartBtn.Text = "Start";
            this.StartBtn.UseVisualStyleBackColor = true;
            this.StartBtn.Click += new System.EventHandler(this.StartBtn_Click);
            // 
            // StopBtn
            // 
            this.StopBtn.Location = new System.Drawing.Point(125, 13);
            this.StopBtn.Name = "StopBtn";
            this.StopBtn.Size = new System.Drawing.Size(107, 37);
            this.StopBtn.TabIndex = 1;
            this.StopBtn.Text = "Stop";
            this.StopBtn.UseVisualStyleBackColor = true;
            this.StopBtn.Click += new System.EventHandler(this.StopBtn_Click);
            // 
            // StatusLbl
            // 
            this.StatusLbl.AutoSize = true;
            this.StatusLbl.Location = new System.Drawing.Point(12, 65);
            this.StatusLbl.Name = "StatusLbl";
            this.StatusLbl.Size = new System.Drawing.Size(50, 20);
            this.StatusLbl.TabIndex = 2;
            this.StatusLbl.Text = "label1";
            // 
            // HelpBtn
            // 
            this.HelpBtn.Location = new System.Drawing.Point(238, 13);
            this.HelpBtn.Name = "HelpBtn";
            this.HelpBtn.Size = new System.Drawing.Size(41, 37);
            this.HelpBtn.TabIndex = 3;
            this.HelpBtn.Text = "?";
            this.HelpBtn.UseVisualStyleBackColor = true;
            this.HelpBtn.Click += new System.EventHandler(this.HelpBtn_Click);
            // 
            // RunningPBox
            // 
            this.RunningPBox.Enabled = false;
            this.RunningPBox.Image = ((System.Drawing.Image)(resources.GetObject("RunningPBox.Image")));
            this.RunningPBox.Location = new System.Drawing.Point(249, 55);
            this.RunningPBox.Name = "RunningPBox";
            this.RunningPBox.Size = new System.Drawing.Size(29, 30);
            this.RunningPBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.RunningPBox.TabIndex = 4;
            this.RunningPBox.TabStop = false;
            // 
            // trayNotifyIcon
            // 
            this.trayNotifyIcon.ContextMenuStrip = this.trayCMenuStrip;
            this.trayNotifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("trayNotifyIcon.Icon")));
            this.trayNotifyIcon.Text = "No Sleep!\r\nMaking sure your computer \r\nwill never sleep again!\r\n~PQA~";
            this.trayNotifyIcon.Visible = true;
            this.trayNotifyIcon.DoubleClick += new System.EventHandler(this.trayNotifyIcon_DoubleClick);
            // 
            // trayCMenuStrip
            // 
            this.trayCMenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.trayCMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openNoSleepToolStripMenuItem,
            this.startToolStripMenuItem,
            this.stopToolStripMenuItem,
            this.closeToolStripMenuItem});
            this.trayCMenuStrip.Name = "trayCMenuStrip";
            this.trayCMenuStrip.Size = new System.Drawing.Size(178, 100);
            // 
            // openNoSleepToolStripMenuItem
            // 
            this.openNoSleepToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.openNoSleepToolStripMenuItem.Name = "openNoSleepToolStripMenuItem";
            this.openNoSleepToolStripMenuItem.Size = new System.Drawing.Size(177, 24);
            this.openNoSleepToolStripMenuItem.Text = "Open NoSleep";
            this.openNoSleepToolStripMenuItem.Click += new System.EventHandler(this.openNoSleepToolStripMenuItem_Click);
            // 
            // startToolStripMenuItem
            // 
            this.startToolStripMenuItem.Name = "startToolStripMenuItem";
            this.startToolStripMenuItem.Size = new System.Drawing.Size(177, 24);
            this.startToolStripMenuItem.Text = "Start";
            this.startToolStripMenuItem.Click += new System.EventHandler(this.startToolStripMenuItem_Click);
            // 
            // stopToolStripMenuItem
            // 
            this.stopToolStripMenuItem.Name = "stopToolStripMenuItem";
            this.stopToolStripMenuItem.Size = new System.Drawing.Size(177, 24);
            this.stopToolStripMenuItem.Text = "Stop";
            this.stopToolStripMenuItem.Click += new System.EventHandler(this.stopToolStripMenuItem_Click);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(177, 24);
            this.closeToolStripMenuItem.Text = "Close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // NoSleepFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(291, 96);
            this.Controls.Add(this.RunningPBox);
            this.Controls.Add(this.HelpBtn);
            this.Controls.Add(this.StatusLbl);
            this.Controls.Add(this.StopBtn);
            this.Controls.Add(this.StartBtn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(308, 129);
            this.Name = "NoSleepFrm";
            this.Text = "NoSleep";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.NoSleepFrm_FormClosing);
            this.Load += new System.EventHandler(this.NoSleepFrm_Load);
            this.Resize += new System.EventHandler(this.NoSleepFrm_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.RunningPBox)).EndInit();
            this.trayCMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button StartBtn;
        private Button StopBtn;
        private Label StatusLbl;
        private Button HelpBtn;
        private PictureBox RunningPBox;
        private NotifyIcon trayNotifyIcon;
        private ContextMenuStrip trayCMenuStrip;
        private ToolStripMenuItem startToolStripMenuItem;
        private ToolStripMenuItem stopToolStripMenuItem;
        private ToolStripMenuItem closeToolStripMenuItem;
        private ToolStripMenuItem openNoSleepToolStripMenuItem;
    }
}