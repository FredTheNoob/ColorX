﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
            timer1.Stop();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            // if Control and 1 is pressed at the same time
            if (e.KeyCode == Keys.D1 && e.Modifiers == Keys.Control)
            {
                
            }
        }

        private void BtnFindColor_MouseDown(object sender, MouseEventArgs e)
        {
            timer1.Start();
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            Bitmap preview = new Bitmap(20, 20);
            Bitmap bmp = new Bitmap(1, 1);
            using (Graphics g = Graphics.FromImage(bmp))
            {
                g.CopyFromScreen(System.Windows.Forms.Cursor.Position, new Point(0, 0), new Size(1, 1));
            }
            using (Graphics g = Graphics.FromImage(preview))
            {
                g.CopyFromScreen(Cursor.Position, new Point(4, 4), new Size(20, 20));
            }
            Color pixel = bmp.GetPixel(0, 0);
            
            txtRValue.Text = bmp.GetPixel(0, 0).R.ToString();
            txtGValue.Text = bmp.GetPixel(0, 0).G.ToString();
            txtBValue.Text = bmp.GetPixel(0, 0).B.ToString();
            txtHexValue.Text = "#" + bmp.GetPixel(0,0).R.ToString("X2") + bmp.GetPixel(0, 0).G.ToString("X2") + bmp.GetPixel(0, 0).B.ToString("X2");


            ptbColor.BackColor = pixel;
            this.Invalidate();
            ptbPreview.Image = preview;
        }

        private void BtnFindColor_MouseUp(object sender, MouseEventArgs e)
        {
            timer1.Stop();
        }
    }
}
