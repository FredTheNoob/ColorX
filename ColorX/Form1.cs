using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ColorX
{
    public partial class Form1 : Form
    {
        #region customUI

        // Kald på et windows native så man kan flytte rundt på vinduet vha. topbaren
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        private void PictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            // This makes the window movable
            ReleaseCapture();
            SendMessage(this.Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
        }

        #region FormControls
        private void BtnExit_Click(object sender, EventArgs e)
        {
            // When the button exit is pressed the program shall close!
            Application.Exit();
        }

        private void BtnExit_MouseLeave(object sender, EventArgs e)
        {
            btnExit.BackColor = Color.FromArgb(64, 64, 64);
        }

        private void BtnExit_MouseEnter(object sender, EventArgs e)
        {
            btnExit.BackColor = Color.Red;
        }

        private void BtnMinimize_MouseLeave(object sender, EventArgs e)
        {
            btnMinimize.BackColor = Color.FromArgb(64, 64, 64);
        }

        private void BtnMinimize_MouseEnter(object sender, EventArgs e)
        {
            btnMinimize.BackColor = Color.DimGray;
        }

        private void BtnMinimize_Click(object sender, EventArgs e)
        {
            // Minimize the window when the button is pressed
            this.WindowState = FormWindowState.Minimized;
        }

        #endregion FormControls


        #endregion customUI

        public Form1()
        {
            InitializeComponent();
        }

        //private void Form1_KeyDown(object sender, KeyEventArgs e)
        //{
        //    // if Control and 1 is pressed at the same time
        //    if (e.KeyCode == Keys.D1 && e.Modifiers == Keys.Control)
        //    {
                
        //    }
        //}
        private void Form1_Load(object sender, EventArgs e)
        {
            settings1.Hide();
            mainpage1.Show();
        }

        private void BtnSettings_Click(object sender, EventArgs e)
        {
            mainpage1.Hide();
            settings1.BringToFront();
            settings1.Show();
            btnBack.BringToFront();
            btnBack.Visible = true;
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            btnBack.Visible = false;
            btnBack.SendToBack();
            btnSettings.BringToFront();
            settings1.Hide();
            mainpage1.Show();
        }
    }
}
