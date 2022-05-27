using System;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;

namespace MouseClick
{
    public partial class frm_Clickity : Form
    {
        Point point;
        string PointX, PointY;
        bool run = false;

        public frm_Clickity()
        {
            InitializeComponent();
        }

        private void frm_Clickity_Load(object sender, EventArgs e)
        {
            this.TransparencyKey = Color.Red;
            pnl_Point.BackColor = Color.Red;

            point = lbl_Point.PointToScreen(new Point(0, 0));
            PointX = point.X.ToString();
            PointY = point.Y.ToString();
            lbl_PointPosition.Text = "X: " + PointX + ", Y: " + PointY;
            //this.Cursor = new Cursor(Cursor.Current.Handle);
            //Cursor.Position = new Point(Cursor.Position.X - 50, Cursor.Position.Y - 50);
            //Cursor.Clip = new Rectangle(this.Location, this.Size);

            num_Click.Enabled = false;
            btn_Start.Enabled = false;
            btn_Startauto.Enabled = false;
            btn_Stop.Enabled = false;

            //Process currentp = Process.GetCurrentProcess();
            //lbl_Progress.Text = currentp.MainWindowTitle;
            //Process[] processlist = Process.GetProcesses();

            //foreach (Process process in processlist)
            //{
            //    if (!String.IsNullOrEmpty(process.MainWindowTitle))
            //    {
            //        MessageBox.Show(String.Format("Process: {0} ID: {1} Window title: {2}", process.ProcessName, process.Id, process.MainWindowTitle));
            //    }
            //}
        }

        //This is a replacement for Cursor.Position in WinForms
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        static extern bool SetCursorPos(int x, int y);

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern void mouse_event(int dwFlags, int dx, int dy, int cButtons, int dwExtraInfo);

        //[DllImport("user32.dll")]
        //static extern IntPtr GetForegroundWindow();
        //public static extern bool PostMessage(int hWnd, uint Msg, int wParam, int lParam);

        public const int MOUSEEVENTF_LEFTDOWN = 0x02;
        public const int MOUSEEVENTF_LEFTUP = 0x04;
        //public const int MK_LBUTTON = 0x0001;

        //This simulates a left mouse click
        public static void LeftMouseClick(int xpos, int ypos)
        {
            SetCursorPos(xpos, ypos);
            mouse_event(MOUSEEVENTF_LEFTDOWN, xpos, ypos, 0, 0);
            mouse_event(MOUSEEVENTF_LEFTUP, xpos, ypos, 0, 0);
            //PostMessage(GetForegroundWindow(), MK_LBUTTON, 0, 0);
        }

        private void btn_Start_Click(object sender, EventArgs e)
        {
            btn_Start.Enabled = false;
            btn_Stop.Enabled = true;

            int click_total = (int)num_Click.Value;
            int progress_total = click_total;
            int progress = 0, progress_counter = 0;

            while(click_total != 0 && run)
            {
                LeftMouseClick(int.Parse(PointX), int.Parse(PointY));
                progress = (int)(((float)++progress_counter / (float)progress_total) * 100);
                lbl_Progress.Text = progress + "%";
                lbl_Progress.Refresh();
                progressBar.Value = progress;
                click_total--;
            }

            btn_Start.Enabled = true;
            btn_Stop.Enabled = false;
            run = true;
        }

        private void btn_Startauto_Click(object sender, EventArgs e)
        {
            run = true;
            btn_Stop.Enabled = true;

            while (run)
            {
                LeftMouseClick(int.Parse(PointX), int.Parse(PointY));
                int milliseconds = 1000;
                Thread.Sleep(milliseconds);
            }
        }

        private void btn_SetPoint_Click(object sender, EventArgs e)
        {
            point = lbl_Point.PointToScreen(new Point(0, 0));
            PointX = point.X.ToString();
            PointY = point.Y.ToString();
            lbl_PointPosition.Text = "X: " + PointX + ", Y: " + PointY;

            num_Click.Enabled = true;
            //btn_Startauto.Enabled = true;
            btn_Stop.Enabled = false;
        }

        private void num_Click_ValueChanged(object sender, EventArgs e)
        {
            num_Click.Refresh();
            num_Click_HandleValueChanged();
        }

        private void btn_Stop_Click(object sender, EventArgs e)
        {
            btn_Stop.Enabled = false;
            run = false;
        }

        private void num_Click_KeyUp(object sender, KeyEventArgs e)
        {
            num_Click.Refresh();
            num_Click_HandleValueChanged();
        }

        private void num_Click_HandleValueChanged()
        {
            if (num_Click.Value > 0)
            {
                btn_Start.Enabled = true;
                run = true;
            }
            else
            {
                btn_Start.Enabled = false;
                run = false;
            }
        }
    }
}
