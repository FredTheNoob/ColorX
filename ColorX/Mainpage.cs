using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace ColorX
{
    public partial class Mainpage : UserControl
    {
        Color currColor;
        List<Color> colors = new List<Color>();

        Bitmap preview = new Bitmap(100, 50);

        public Mainpage()
        {
            InitializeComponent();
            timer1.Stop();
        }

        #region FormControls

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



        private void Mainpage_Load(object sender, EventArgs e)
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
            txtHexValue.Text = "#" + bmp.GetPixel(0, 0).R.ToString("X2") + bmp.GetPixel(0, 0).G.ToString("X2") + bmp.GetPixel(0, 0).B.ToString("X2");

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

                ptbColorHistory.BackColor = colors[colors.Count - 1];
                ptbColorHistory.Visible = true;

                ptbColorHistory2.BackColor = colors[colors.Count - 2];
                ptbColorHistory2.Visible = true;

                ptbColorHistory3.BackColor = colors[colors.Count - 3];
                ptbColorHistory3.Visible = true;

                ptbColorHistory4.BackColor = colors[colors.Count - 4];
                ptbColorHistory4.Visible = true;

                ptbColorHistory5.BackColor = colors[colors.Count - 5];
                ptbColorHistory5.Visible = true;

                ptbColorHistory6.BackColor = colors[colors.Count - 6];
                ptbColorHistory6.Visible = true;

                ptbColorHistory7.BackColor = colors[colors.Count - 7];
                ptbColorHistory7.Visible = true;

                ptbColorHistory8.BackColor = colors[colors.Count - 8];
                ptbColorHistory8.Visible = true;

                ptbColorHistory9.BackColor = colors[colors.Count - 9];
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
