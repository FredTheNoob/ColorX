﻿using System;
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
        Color currColor;
        List<Color> colors = new List<Color>();

        Bitmap preview = new Bitmap(100, 50);

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

        private void BtnFindColor_MouseEnter(object sender, EventArgs e)
        {
            btnFindColor.BackColor = Color.FromArgb(64, 64, 64);
            btnFindColor.FlatAppearance.BorderColor = Color.Silver;
            btnFindColor.ForeColor = Color.Silver;
        }

        private void BtnFindColor_MouseLeave(object sender, EventArgs e)
        {
            btnFindColor.BackColor = Color.Silver;
            btnFindColor.FlatAppearance.BorderColor = Color.FromArgb(64, 64, 64);
            btnFindColor.ForeColor = Color.FromArgb(64, 64, 64);
        }

        private void BtnZoomIn_MouseEnter(object sender, EventArgs e)
        {
            btnZoomIn.BackColor = Color.FromArgb(64, 64, 64);
            btnZoomIn.FlatAppearance.BorderColor = Color.Silver;
            btnZoomIn.ForeColor = Color.Silver;
        }

        private void BtnZoomIn_MouseLeave(object sender, EventArgs e)
        {
            btnZoomIn.BackColor = Color.Silver;
            btnZoomIn.FlatAppearance.BorderColor = Color.FromArgb(64, 64, 64);
            btnZoomIn.ForeColor = Color.FromArgb(64, 64, 64);
        }

        private void BtnZoomOut_MouseEnter(object sender, EventArgs e)
        {
            btnZoomOut.BackColor = Color.FromArgb(64, 64, 64);
            btnZoomOut.FlatAppearance.BorderColor = Color.Silver;
            btnZoomOut.ForeColor = Color.Silver;
        }

        private void BtnZoomOut_MouseLeave(object sender, EventArgs e)
        {
            btnZoomOut.BackColor = Color.Silver;
            btnZoomOut.FlatAppearance.BorderColor = Color.FromArgb(64, 64, 64);
            btnZoomOut.ForeColor = Color.FromArgb(64, 64, 64);
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
        private void Form1_Load(object sender, EventArgs e)
        {
            ptbColorHistory.Visible = false;
            ptbColorHistory2.Visible = false;
            ptbColorHistory3.Visible = false;
            ptbColorHistory4.Visible = false;
            ptbColorHistory5.Visible = false;
            ptbColorHistory6.Visible = false;
            ptbColorHistory7.Visible = false;
            ptbColorHistory8.Visible = false;
            ptbColorHistory9.Visible = false;
            RectPtbCrosshair.Visible = false;
            btnZoomIn.Visible = false;
            btnZoomOut.Visible = false;
        }

        private void BtnFindColor_MouseDown(object sender, MouseEventArgs e)
        {
            timer1.Start();

            this.Cursor = Cursors.Cross;


            //RectPtbCrosshair.BackColor = Color.FromArgb(0, 255, 255, 255);
            RectPtbCrosshair.Visible = true;
            RectPtbCrosshair.BackColor = Color.FromArgb(143, 143, 143);
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            Bitmap bmp = new Bitmap(1, 1);

            int curX = Cursor.Position.X;
            int curY = Cursor.Position.Y;

            using (Graphics g = Graphics.FromImage(bmp))
            {
                g.CopyFromScreen(Cursor.Position, new Point(0, 0), new Size(1, 1));
            }
            using (Graphics g = Graphics.FromImage(preview))
            {
                g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.NearestNeighbor;
                g.CopyFromScreen(new Point(curX - 50, curY - 25), new Point(0, 0), new Size(100, 50));
            }
            Color pixel = bmp.GetPixel(0, 0);
            RectPtbCrosshair.BackColor = pixel;

            txtRValue.Text = bmp.GetPixel(0, 0).R.ToString();
            txtGValue.Text = bmp.GetPixel(0, 0).G.ToString();
            txtBValue.Text = bmp.GetPixel(0, 0).B.ToString();
            txtHexValue.Text = "#" + bmp.GetPixel(0,0).R.ToString("X2") + bmp.GetPixel(0, 0).G.ToString("X2") + bmp.GetPixel(0, 0).B.ToString("X2");

            currColor = pixel;
            ptbColor.BackColor = pixel;
            ptbPreview.Image = preview;
            lblStatus.Text = "Color found!";

            this.Invalidate();
        }

        private void BtnFindColor_MouseUp(object sender, MouseEventArgs e)
        {
            timer1.Stop();

            this.Cursor = Cursors.Default;

            colors.Add(currColor);

            try
            {
                
                ptbColorHistory.BackColor = colors[colors.Count-1];
                ptbColorHistory.Visible = true;

                ptbColorHistory2.BackColor = colors[colors.Count-2];
                ptbColorHistory2.Visible = true;

                ptbColorHistory3.BackColor = colors[colors.Count-3];
                ptbColorHistory3.Visible = true;

                ptbColorHistory4.BackColor = colors[colors.Count-4];
                ptbColorHistory4.Visible = true;

                ptbColorHistory5.BackColor = colors[colors.Count-5];
                ptbColorHistory5.Visible = true;

                ptbColorHistory6.BackColor = colors[colors.Count-6];
                ptbColorHistory6.Visible = true;

                ptbColorHistory7.BackColor = colors[colors.Count-7];
                ptbColorHistory7.Visible = true;

                ptbColorHistory8.BackColor = colors[colors.Count-8];
                ptbColorHistory8.Visible = true;

                ptbColorHistory9.BackColor = colors[colors.Count-9];
                ptbColorHistory9.Visible = true;
            }
            catch (Exception)
            {
            }

            RectPtbCrosshair.Visible = false;

            btnZoomIn.Visible = true;
            btnZoomOut.Visible = true;
        }

        private void LoadColor_Click(object sender, EventArgs e)
        {
            PictureBox ptbClicked = sender as PictureBox;

            ptbColor.BackColor = ptbClicked.BackColor;
            
            txtRValue.Text = ptbClicked.BackColor.R.ToString();
            txtGValue.Text = ptbClicked.BackColor.G.ToString();
            txtBValue.Text = ptbClicked.BackColor.B.ToString();
            txtHexValue.Text = "#" + ptbClicked.BackColor.R.ToString("X2") + ptbClicked.BackColor.G.ToString("X2") + ptbClicked.BackColor.B.ToString("X2");
        }

        private void ChangeCursor_MouseEnter(object sender, EventArgs e)
        {
            this.Cursor = new Cursor(new MemoryStream(Properties.Resources.aero_pen));
        }

        private void ChangeCursor_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;
        }

        private void BtnZoomIn_Click(object sender, EventArgs e)
        {
            Bitmap tmpImage1 = new Bitmap(preview.Width, preview.Height);
            Graphics g = Graphics.FromImage(tmpImage1);
            int left = preview.Width / 4;
            int top = preview.Height / 4;
            int width = preview.Width / 2;
            int height = preview.Height / 2;
            Rectangle srcRect = new Rectangle(left, top, width, height);
            Rectangle dstRect = new Rectangle(0, 0, tmpImage1.Width, tmpImage1.Height);
            g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.NearestNeighbor;
            g.DrawImage(preview, dstRect, srcRect, GraphicsUnit.Pixel);

            ptbPreview.Image = tmpImage1;

            lblStatus.Text = "Zoomed in";
        }

        private void BtnZoomOut_Click(object sender, EventArgs e)
        {
            Bitmap tmpImage1 = new Bitmap(preview.Width, preview.Height);
            Graphics g = Graphics.FromImage(tmpImage1);
            int left = preview.Width / 70;
            int top = preview.Height / 70;
            int width = preview.Width / 1;
            int height = preview.Height / 1;
            Rectangle srcRect = new Rectangle(left, top, width, height);
            Rectangle dstRect = new Rectangle(0, 0, tmpImage1.Width, tmpImage1.Height);
            g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.NearestNeighbor;
            g.DrawImage(preview, dstRect, srcRect, GraphicsUnit.Pixel);

            ptbPreview.Image = tmpImage1;

            lblStatus.Text = "Zoomed Out";
        }
    }
}
