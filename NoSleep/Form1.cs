namespace NoSleep
{
    public partial class NoSleepFrm : Form
    {
        public NoSleepFrm()
        {
            InitializeComponent();
        }

        private void NoSleepFrm_Load(object sender, EventArgs e)
        {
            //bool isMyFormOpen = false;
            //foreach (Form f in Application.OpenForms)
            //{
            //    if (f is NoSleepFrm)
            //    {
            //        isMyFormOpen = true;
            //        break;
            //    }
            //}
            //if (!isMyFormOpen)
            //{
            //    NoSleepFrm f = new NoSleepFrm();
            //    f.Show();
            //}

            StopBtn.Enabled = false;
            StatusLbl.Text = "NoSleep is NOT running...";
            trayNotifyIcon.BalloonTipText = "Application Minimized.";
            trayNotifyIcon.BalloonTipTitle = "No Sleep";
            //RunningPBox.Visible = false;
            trayNotifyIcon.Text = "NoSleep v1.31" + System.Environment.NewLine + "Your computer will never sleep again." + System.Environment.NewLine + "~ PQA ~";
        }

        private void StartBtn_Click(object sender, EventArgs e)
        {
            //System.Diagnostics.Debug.WriteLine("testxxx");
            //Program.cancelToken = new CancellationToken(false);
            Program.StartNoSleep();
            
            StopBtn.Enabled=true;
            StartBtn.Enabled=false;
            StatusLbl.Text = "NoSleep is running...";
            startToolStripMenuItem.Enabled = false;
            //RunningPBox.Visible = true;
            RunningPBox.Enabled=true;
        }

        private void StopBtn_Click(object sender, EventArgs e)
        {
            //System.Diagnostics.Debug.WriteLine("stop");
            //Program.cancelToken = new CancellationToken(true);

            NativeMethods.AllowSleep();
            StartBtn.Enabled = true;
            StopBtn.Enabled=false;
            StatusLbl.Text = "NoSleep is NOT running...";
            RunningPBox.Enabled = false;
        }

        private void HelpBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("NoSleep v1.31"+System.Environment.NewLine+"Your computer will never sleep again." + System.Environment.NewLine + "~ PQA ~");
        }

        private void NoSleepFrm_FormClosing(object sender, FormClosingEventArgs e)
        {
            NativeMethods.AllowSleep();
        }

        private void NoSleepFrm_Resize(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                ShowInTaskbar = false;
                trayNotifyIcon.Visible = true;
                trayNotifyIcon.ShowBalloonTip(1000);
            }
        }

        private void trayNotifyIcon_DoubleClick(object sender, EventArgs e)
        {
            ShowInTaskbar = true;
            trayNotifyIcon.Visible = false;
            WindowState = FormWindowState.Normal;
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void startToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Program.StartNoSleep();

            StopBtn.Enabled = true;
            StartBtn.Enabled = false;
            startToolStripMenuItem.Enabled = false;
            stopToolStripMenuItem.Enabled = true;
            StatusLbl.Text = "NoSleep is running...";
            RunningPBox.Enabled = true;
        }

        private void stopToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NativeMethods.AllowSleep();
            StartBtn.Enabled = true;
            StopBtn.Enabled = false;
            stopToolStripMenuItem.Enabled = false;
            startToolStripMenuItem.Enabled = true;
            StatusLbl.Text = "NoSleep is NOT running...";
            RunningPBox.Enabled = false;
        }

        private void openNoSleepToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowInTaskbar = true;
            trayNotifyIcon.Visible = false;
            WindowState = FormWindowState.Normal;
        }
    }
}