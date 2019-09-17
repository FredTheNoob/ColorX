namespace ColorX
{
    partial class Mainpage
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnZoomOut = new System.Windows.Forms.Button();
            this.btnZoomIn = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.RectPtbCrosshair = new System.Windows.Forms.PictureBox();
            this.ptbColorHistory9 = new System.Windows.Forms.PictureBox();
            this.ptbColorHistory8 = new System.Windows.Forms.PictureBox();
            this.ptbColorHistory7 = new System.Windows.Forms.PictureBox();
            this.ptbColorHistory6 = new System.Windows.Forms.PictureBox();
            this.ptbColorHistory5 = new System.Windows.Forms.PictureBox();
            this.ptbColorHistory4 = new System.Windows.Forms.PictureBox();
            this.ptbColorHistory3 = new System.Windows.Forms.PictureBox();
            this.ptbColorHistory2 = new System.Windows.Forms.PictureBox();
            this.ptbColorHistory = new System.Windows.Forms.PictureBox();
            this.ptbPreview = new System.Windows.Forms.PictureBox();
            this.txtHexValue = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnFindColor = new System.Windows.Forms.Button();
            this.lblBValue = new System.Windows.Forms.Label();
            this.lblGValue = new System.Windows.Forms.Label();
            this.lblRValue = new System.Windows.Forms.Label();
            this.txtBValue = new System.Windows.Forms.TextBox();
            this.txtGValue = new System.Windows.Forms.TextBox();
            this.txtRValue = new System.Windows.Forms.TextBox();
            this.ptbColor = new System.Windows.Forms.PictureBox();
            this.lblHeader = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RectPtbCrosshair)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbColorHistory9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbColorHistory8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbColorHistory7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbColorHistory6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbColorHistory5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbColorHistory4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbColorHistory3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbColorHistory2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbColorHistory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbPreview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbColor)).BeginInit();
            this.SuspendLayout();
            // 
            // btnZoomOut
            // 
            this.btnZoomOut.BackColor = System.Drawing.Color.Silver;
            this.btnZoomOut.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnZoomOut.FlatAppearance.BorderSize = 2;
            this.btnZoomOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnZoomOut.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnZoomOut.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnZoomOut.Location = new System.Drawing.Point(84, 297);
            this.btnZoomOut.Name = "btnZoomOut";
            this.btnZoomOut.Size = new System.Drawing.Size(16, 25);
            this.btnZoomOut.TabIndex = 80;
            this.btnZoomOut.Text = "-";
            this.btnZoomOut.UseVisualStyleBackColor = false;
            this.btnZoomOut.Click += new System.EventHandler(this.BtnZoomOut_Click);
            this.btnZoomOut.MouseEnter += new System.EventHandler(this.BtnZoomOut_MouseEnter);
            this.btnZoomOut.MouseLeave += new System.EventHandler(this.BtnZoomOut_MouseLeave);
            // 
            // btnZoomIn
            // 
            this.btnZoomIn.BackColor = System.Drawing.Color.Silver;
            this.btnZoomIn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnZoomIn.FlatAppearance.BorderSize = 2;
            this.btnZoomIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnZoomIn.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnZoomIn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnZoomIn.Location = new System.Drawing.Point(84, 272);
            this.btnZoomIn.Name = "btnZoomIn";
            this.btnZoomIn.Size = new System.Drawing.Size(16, 26);
            this.btnZoomIn.TabIndex = 79;
            this.btnZoomIn.Text = "+";
            this.btnZoomIn.UseVisualStyleBackColor = false;
            this.btnZoomIn.Click += new System.EventHandler(this.BtnZoomIn_Click);
            this.btnZoomIn.MouseEnter += new System.EventHandler(this.BtnZoomIn_MouseEnter);
            this.btnZoomIn.MouseLeave += new System.EventHandler(this.BtnZoomIn_MouseLeave);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pictureBox3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pictureBox3.Location = new System.Drawing.Point(0, 325);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(302, 2);
            this.pictureBox3.TabIndex = 78;
            this.pictureBox3.TabStop = false;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.BackColor = System.Drawing.Color.Silver;
            this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.Location = new System.Drawing.Point(12, 329);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(144, 16);
            this.lblStatus.TabIndex = 77;
            this.lblStatus.Text = "Welcome to ColorX!";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Silver;
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pictureBox2.Location = new System.Drawing.Point(0, 327);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(302, 19);
            this.pictureBox2.TabIndex = 76;
            this.pictureBox2.TabStop = false;
            // 
            // RectPtbCrosshair
            // 
            this.RectPtbCrosshair.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.RectPtbCrosshair.Location = new System.Drawing.Point(154, 294);
            this.RectPtbCrosshair.Name = "RectPtbCrosshair";
            this.RectPtbCrosshair.Size = new System.Drawing.Size(5, 5);
            this.RectPtbCrosshair.TabIndex = 75;
            this.RectPtbCrosshair.TabStop = false;
            // 
            // ptbColorHistory9
            // 
            this.ptbColorHistory9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ptbColorHistory9.Location = new System.Drawing.Point(232, 297);
            this.ptbColorHistory9.Name = "ptbColorHistory9";
            this.ptbColorHistory9.Size = new System.Drawing.Size(50, 25);
            this.ptbColorHistory9.TabIndex = 74;
            this.ptbColorHistory9.TabStop = false;
            this.ptbColorHistory9.Click += new System.EventHandler(this.LoadColor_Click);
            this.ptbColorHistory9.MouseEnter += new System.EventHandler(this.ChangeCursor_MouseEnter);
            this.ptbColorHistory9.MouseLeave += new System.EventHandler(this.ChangeCursor_MouseLeave);
            // 
            // ptbColorHistory8
            // 
            this.ptbColorHistory8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ptbColorHistory8.Location = new System.Drawing.Point(232, 264);
            this.ptbColorHistory8.Name = "ptbColorHistory8";
            this.ptbColorHistory8.Size = new System.Drawing.Size(50, 25);
            this.ptbColorHistory8.TabIndex = 73;
            this.ptbColorHistory8.TabStop = false;
            this.ptbColorHistory8.Click += new System.EventHandler(this.LoadColor_Click);
            this.ptbColorHistory8.MouseEnter += new System.EventHandler(this.ChangeCursor_MouseEnter);
            this.ptbColorHistory8.MouseLeave += new System.EventHandler(this.ChangeCursor_MouseLeave);
            // 
            // ptbColorHistory7
            // 
            this.ptbColorHistory7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ptbColorHistory7.Location = new System.Drawing.Point(232, 230);
            this.ptbColorHistory7.Name = "ptbColorHistory7";
            this.ptbColorHistory7.Size = new System.Drawing.Size(50, 25);
            this.ptbColorHistory7.TabIndex = 72;
            this.ptbColorHistory7.TabStop = false;
            this.ptbColorHistory7.Click += new System.EventHandler(this.LoadColor_Click);
            this.ptbColorHistory7.MouseEnter += new System.EventHandler(this.ChangeCursor_MouseEnter);
            this.ptbColorHistory7.MouseLeave += new System.EventHandler(this.ChangeCursor_MouseLeave);
            // 
            // ptbColorHistory6
            // 
            this.ptbColorHistory6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ptbColorHistory6.Location = new System.Drawing.Point(232, 196);
            this.ptbColorHistory6.Name = "ptbColorHistory6";
            this.ptbColorHistory6.Size = new System.Drawing.Size(50, 25);
            this.ptbColorHistory6.TabIndex = 71;
            this.ptbColorHistory6.TabStop = false;
            this.ptbColorHistory6.Click += new System.EventHandler(this.LoadColor_Click);
            this.ptbColorHistory6.MouseEnter += new System.EventHandler(this.ChangeCursor_MouseEnter);
            this.ptbColorHistory6.MouseLeave += new System.EventHandler(this.ChangeCursor_MouseLeave);
            // 
            // ptbColorHistory5
            // 
            this.ptbColorHistory5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ptbColorHistory5.Location = new System.Drawing.Point(232, 163);
            this.ptbColorHistory5.Name = "ptbColorHistory5";
            this.ptbColorHistory5.Size = new System.Drawing.Size(50, 25);
            this.ptbColorHistory5.TabIndex = 70;
            this.ptbColorHistory5.TabStop = false;
            this.ptbColorHistory5.Click += new System.EventHandler(this.LoadColor_Click);
            this.ptbColorHistory5.MouseEnter += new System.EventHandler(this.ChangeCursor_MouseEnter);
            this.ptbColorHistory5.MouseLeave += new System.EventHandler(this.ChangeCursor_MouseLeave);
            // 
            // ptbColorHistory4
            // 
            this.ptbColorHistory4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ptbColorHistory4.Location = new System.Drawing.Point(232, 128);
            this.ptbColorHistory4.Name = "ptbColorHistory4";
            this.ptbColorHistory4.Size = new System.Drawing.Size(50, 25);
            this.ptbColorHistory4.TabIndex = 69;
            this.ptbColorHistory4.TabStop = false;
            this.ptbColorHistory4.Click += new System.EventHandler(this.LoadColor_Click);
            this.ptbColorHistory4.MouseEnter += new System.EventHandler(this.ChangeCursor_MouseEnter);
            this.ptbColorHistory4.MouseLeave += new System.EventHandler(this.ChangeCursor_MouseLeave);
            // 
            // ptbColorHistory3
            // 
            this.ptbColorHistory3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ptbColorHistory3.Location = new System.Drawing.Point(232, 93);
            this.ptbColorHistory3.Name = "ptbColorHistory3";
            this.ptbColorHistory3.Size = new System.Drawing.Size(50, 25);
            this.ptbColorHistory3.TabIndex = 68;
            this.ptbColorHistory3.TabStop = false;
            this.ptbColorHistory3.Click += new System.EventHandler(this.LoadColor_Click);
            this.ptbColorHistory3.MouseEnter += new System.EventHandler(this.ChangeCursor_MouseEnter);
            this.ptbColorHistory3.MouseLeave += new System.EventHandler(this.ChangeCursor_MouseLeave);
            // 
            // ptbColorHistory2
            // 
            this.ptbColorHistory2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ptbColorHistory2.Location = new System.Drawing.Point(232, 60);
            this.ptbColorHistory2.Name = "ptbColorHistory2";
            this.ptbColorHistory2.Size = new System.Drawing.Size(50, 25);
            this.ptbColorHistory2.TabIndex = 67;
            this.ptbColorHistory2.TabStop = false;
            this.ptbColorHistory2.Click += new System.EventHandler(this.LoadColor_Click);
            this.ptbColorHistory2.MouseEnter += new System.EventHandler(this.ChangeCursor_MouseEnter);
            this.ptbColorHistory2.MouseLeave += new System.EventHandler(this.ChangeCursor_MouseLeave);
            // 
            // ptbColorHistory
            // 
            this.ptbColorHistory.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ptbColorHistory.Location = new System.Drawing.Point(232, 28);
            this.ptbColorHistory.Name = "ptbColorHistory";
            this.ptbColorHistory.Size = new System.Drawing.Size(50, 25);
            this.ptbColorHistory.TabIndex = 66;
            this.ptbColorHistory.TabStop = false;
            this.ptbColorHistory.Click += new System.EventHandler(this.LoadColor_Click);
            this.ptbColorHistory.MouseEnter += new System.EventHandler(this.ChangeCursor_MouseEnter);
            this.ptbColorHistory.MouseLeave += new System.EventHandler(this.ChangeCursor_MouseLeave);
            // 
            // ptbPreview
            // 
            this.ptbPreview.Location = new System.Drawing.Point(106, 272);
            this.ptbPreview.Name = "ptbPreview";
            this.ptbPreview.Size = new System.Drawing.Size(100, 50);
            this.ptbPreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptbPreview.TabIndex = 65;
            this.ptbPreview.TabStop = false;
            // 
            // txtHexValue
            // 
            this.txtHexValue.Location = new System.Drawing.Point(106, 186);
            this.txtHexValue.Name = "txtHexValue";
            this.txtHexValue.Size = new System.Drawing.Size(100, 20);
            this.txtHexValue.TabIndex = 64;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(98, 167);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 16);
            this.label1.TabIndex = 63;
            this.label1.Text = "Hex Color Code";
            // 
            // btnFindColor
            // 
            this.btnFindColor.BackColor = System.Drawing.Color.Silver;
            this.btnFindColor.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnFindColor.FlatAppearance.BorderSize = 2;
            this.btnFindColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFindColor.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFindColor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnFindColor.Location = new System.Drawing.Point(106, 214);
            this.btnFindColor.Name = "btnFindColor";
            this.btnFindColor.Size = new System.Drawing.Size(99, 49);
            this.btnFindColor.TabIndex = 62;
            this.btnFindColor.Text = "Pick Color";
            this.btnFindColor.UseVisualStyleBackColor = false;
            this.btnFindColor.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BtnFindColor_MouseDown);
            this.btnFindColor.MouseEnter += new System.EventHandler(this.BtnFindColor_MouseEnter);
            this.btnFindColor.MouseLeave += new System.EventHandler(this.BtnFindColor_MouseLeave);
            this.btnFindColor.MouseUp += new System.Windows.Forms.MouseEventHandler(this.BtnFindColor_MouseUp);
            // 
            // lblBValue
            // 
            this.lblBValue.AutoSize = true;
            this.lblBValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBValue.Location = new System.Drawing.Point(81, 141);
            this.lblBValue.Name = "lblBValue";
            this.lblBValue.Size = new System.Drawing.Size(22, 16);
            this.lblBValue.TabIndex = 61;
            this.lblBValue.Text = "B:";
            // 
            // lblGValue
            // 
            this.lblGValue.AutoSize = true;
            this.lblGValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGValue.Location = new System.Drawing.Point(80, 115);
            this.lblGValue.Name = "lblGValue";
            this.lblGValue.Size = new System.Drawing.Size(23, 16);
            this.lblGValue.TabIndex = 60;
            this.lblGValue.Text = "G:";
            // 
            // lblRValue
            // 
            this.lblRValue.AutoSize = true;
            this.lblRValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRValue.Location = new System.Drawing.Point(80, 89);
            this.lblRValue.Name = "lblRValue";
            this.lblRValue.Size = new System.Drawing.Size(23, 16);
            this.lblRValue.TabIndex = 59;
            this.lblRValue.Text = "R:";
            // 
            // txtBValue
            // 
            this.txtBValue.Location = new System.Drawing.Point(106, 139);
            this.txtBValue.Name = "txtBValue";
            this.txtBValue.Size = new System.Drawing.Size(100, 20);
            this.txtBValue.TabIndex = 58;
            // 
            // txtGValue
            // 
            this.txtGValue.Location = new System.Drawing.Point(106, 113);
            this.txtGValue.Name = "txtGValue";
            this.txtGValue.Size = new System.Drawing.Size(100, 20);
            this.txtGValue.TabIndex = 57;
            // 
            // txtRValue
            // 
            this.txtRValue.Location = new System.Drawing.Point(106, 87);
            this.txtRValue.Name = "txtRValue";
            this.txtRValue.Size = new System.Drawing.Size(100, 20);
            this.txtRValue.TabIndex = 56;
            // 
            // ptbColor
            // 
            this.ptbColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ptbColor.Location = new System.Drawing.Point(106, 28);
            this.ptbColor.Name = "ptbColor";
            this.ptbColor.Size = new System.Drawing.Size(100, 50);
            this.ptbColor.TabIndex = 55;
            this.ptbColor.TabStop = false;
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.Location = new System.Drawing.Point(118, 1);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(83, 25);
            this.lblHeader.TabIndex = 54;
            this.lblHeader.Text = "ColorX";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // Mainpage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnZoomOut);
            this.Controls.Add(this.btnZoomIn);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.RectPtbCrosshair);
            this.Controls.Add(this.ptbColorHistory9);
            this.Controls.Add(this.ptbColorHistory8);
            this.Controls.Add(this.ptbColorHistory7);
            this.Controls.Add(this.ptbColorHistory6);
            this.Controls.Add(this.ptbColorHistory5);
            this.Controls.Add(this.ptbColorHistory4);
            this.Controls.Add(this.ptbColorHistory3);
            this.Controls.Add(this.ptbColorHistory2);
            this.Controls.Add(this.ptbColorHistory);
            this.Controls.Add(this.ptbPreview);
            this.Controls.Add(this.txtHexValue);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnFindColor);
            this.Controls.Add(this.lblBValue);
            this.Controls.Add(this.lblGValue);
            this.Controls.Add(this.lblRValue);
            this.Controls.Add(this.txtBValue);
            this.Controls.Add(this.txtGValue);
            this.Controls.Add(this.txtRValue);
            this.Controls.Add(this.ptbColor);
            this.Controls.Add(this.lblHeader);
            this.Name = "Mainpage";
            this.Size = new System.Drawing.Size(302, 346);
            this.Load += new System.EventHandler(this.Mainpage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RectPtbCrosshair)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbColorHistory9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbColorHistory8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbColorHistory7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbColorHistory6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbColorHistory5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbColorHistory4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbColorHistory3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbColorHistory2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbColorHistory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbPreview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbColor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnZoomOut;
        private System.Windows.Forms.Button btnZoomIn;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox RectPtbCrosshair;
        private System.Windows.Forms.PictureBox ptbColorHistory9;
        private System.Windows.Forms.PictureBox ptbColorHistory8;
        private System.Windows.Forms.PictureBox ptbColorHistory7;
        private System.Windows.Forms.PictureBox ptbColorHistory6;
        private System.Windows.Forms.PictureBox ptbColorHistory5;
        private System.Windows.Forms.PictureBox ptbColorHistory4;
        private System.Windows.Forms.PictureBox ptbColorHistory3;
        private System.Windows.Forms.PictureBox ptbColorHistory2;
        private System.Windows.Forms.PictureBox ptbColorHistory;
        private System.Windows.Forms.PictureBox ptbPreview;
        private System.Windows.Forms.TextBox txtHexValue;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnFindColor;
        private System.Windows.Forms.Label lblBValue;
        private System.Windows.Forms.Label lblGValue;
        private System.Windows.Forms.Label lblRValue;
        private System.Windows.Forms.TextBox txtBValue;
        private System.Windows.Forms.TextBox txtGValue;
        private System.Windows.Forms.TextBox txtRValue;
        private System.Windows.Forms.PictureBox ptbColor;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.Timer timer1;
    }
}
