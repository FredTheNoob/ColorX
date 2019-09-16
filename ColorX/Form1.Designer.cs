namespace ColorX
{
    partial class Form1
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnExit = new System.Windows.Forms.Label();
            this.btnMinimize = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.borderBottom = new System.Windows.Forms.PictureBox();
            this.borderRight = new System.Windows.Forms.PictureBox();
            this.borderLeft = new System.Windows.Forms.PictureBox();
            this.lblHeader = new System.Windows.Forms.Label();
            this.ptbColor = new System.Windows.Forms.PictureBox();
            this.txtRValue = new System.Windows.Forms.TextBox();
            this.txtGValue = new System.Windows.Forms.TextBox();
            this.txtBValue = new System.Windows.Forms.TextBox();
            this.lblRValue = new System.Windows.Forms.Label();
            this.lblGValue = new System.Windows.Forms.Label();
            this.lblBValue = new System.Windows.Forms.Label();
            this.btnFindColor = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.txtHexValue = new System.Windows.Forms.TextBox();
            this.ptbPreview = new System.Windows.Forms.PictureBox();
            this.ptbColorHistory = new System.Windows.Forms.PictureBox();
            this.ptbColorHistory2 = new System.Windows.Forms.PictureBox();
            this.ptbColorHistory3 = new System.Windows.Forms.PictureBox();
            this.ptbColorHistory4 = new System.Windows.Forms.PictureBox();
            this.ptbColorHistory5 = new System.Windows.Forms.PictureBox();
            this.ptbColorHistory6 = new System.Windows.Forms.PictureBox();
            this.ptbColorHistory7 = new System.Windows.Forms.PictureBox();
            this.ptbColorHistory8 = new System.Windows.Forms.PictureBox();
            this.ptbColorHistory9 = new System.Windows.Forms.PictureBox();
            this.RectPtbCrosshair = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.borderBottom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.borderRight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.borderLeft)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbColor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbPreview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbColorHistory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbColorHistory2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbColorHistory3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbColorHistory4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbColorHistory5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbColorHistory6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbColorHistory7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbColorHistory8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbColorHistory9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RectPtbCrosshair)).BeginInit();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.AutoSize = true;
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.Silver;
            this.btnExit.Location = new System.Drawing.Point(281, -3);
            this.btnExit.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(31, 24);
            this.btnExit.TabIndex = 19;
            this.btnExit.Text = "✖";
            this.btnExit.Click += new System.EventHandler(this.BtnExit_Click);
            this.btnExit.MouseEnter += new System.EventHandler(this.BtnExit_MouseEnter);
            this.btnExit.MouseLeave += new System.EventHandler(this.BtnExit_MouseLeave);
            // 
            // btnMinimize
            // 
            this.btnMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimize.AutoSize = true;
            this.btnMinimize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnMinimize.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinimize.ForeColor = System.Drawing.Color.Silver;
            this.btnMinimize.Location = new System.Drawing.Point(261, -3);
            this.btnMinimize.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(21, 24);
            this.btnMinimize.TabIndex = 20;
            this.btnMinimize.Text = "−";
            this.btnMinimize.Click += new System.EventHandler(this.BtnMinimize_Click);
            this.btnMinimize.MouseEnter += new System.EventHandler(this.BtnMinimize_MouseEnter);
            this.btnMinimize.MouseLeave += new System.EventHandler(this.BtnMinimize_MouseLeave);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(312, 21);
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PictureBox1_MouseDown);
            // 
            // borderBottom
            // 
            this.borderBottom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.borderBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.borderBottom.Location = new System.Drawing.Point(5, 359);
            this.borderBottom.Margin = new System.Windows.Forms.Padding(2);
            this.borderBottom.Name = "borderBottom";
            this.borderBottom.Size = new System.Drawing.Size(302, 5);
            this.borderBottom.TabIndex = 23;
            this.borderBottom.TabStop = false;
            // 
            // borderRight
            // 
            this.borderRight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.borderRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.borderRight.Location = new System.Drawing.Point(307, 21);
            this.borderRight.Margin = new System.Windows.Forms.Padding(2);
            this.borderRight.Name = "borderRight";
            this.borderRight.Size = new System.Drawing.Size(5, 343);
            this.borderRight.TabIndex = 22;
            this.borderRight.TabStop = false;
            // 
            // borderLeft
            // 
            this.borderLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.borderLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.borderLeft.Location = new System.Drawing.Point(0, 21);
            this.borderLeft.Margin = new System.Windows.Forms.Padding(2);
            this.borderLeft.Name = "borderLeft";
            this.borderLeft.Size = new System.Drawing.Size(5, 343);
            this.borderLeft.TabIndex = 21;
            this.borderLeft.TabStop = false;
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.Location = new System.Drawing.Point(118, 31);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(83, 25);
            this.lblHeader.TabIndex = 24;
            this.lblHeader.Text = "ColorX";
            // 
            // ptbColor
            // 
            this.ptbColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ptbColor.Location = new System.Drawing.Point(106, 58);
            this.ptbColor.Name = "ptbColor";
            this.ptbColor.Size = new System.Drawing.Size(100, 50);
            this.ptbColor.TabIndex = 25;
            this.ptbColor.TabStop = false;
            // 
            // txtRValue
            // 
            this.txtRValue.Location = new System.Drawing.Point(106, 117);
            this.txtRValue.Name = "txtRValue";
            this.txtRValue.Size = new System.Drawing.Size(100, 20);
            this.txtRValue.TabIndex = 27;
            // 
            // txtGValue
            // 
            this.txtGValue.Location = new System.Drawing.Point(106, 143);
            this.txtGValue.Name = "txtGValue";
            this.txtGValue.Size = new System.Drawing.Size(100, 20);
            this.txtGValue.TabIndex = 28;
            // 
            // txtBValue
            // 
            this.txtBValue.Location = new System.Drawing.Point(106, 169);
            this.txtBValue.Name = "txtBValue";
            this.txtBValue.Size = new System.Drawing.Size(100, 20);
            this.txtBValue.TabIndex = 29;
            // 
            // lblRValue
            // 
            this.lblRValue.AutoSize = true;
            this.lblRValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRValue.Location = new System.Drawing.Point(80, 119);
            this.lblRValue.Name = "lblRValue";
            this.lblRValue.Size = new System.Drawing.Size(23, 16);
            this.lblRValue.TabIndex = 30;
            this.lblRValue.Text = "R:";
            // 
            // lblGValue
            // 
            this.lblGValue.AutoSize = true;
            this.lblGValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGValue.Location = new System.Drawing.Point(80, 145);
            this.lblGValue.Name = "lblGValue";
            this.lblGValue.Size = new System.Drawing.Size(23, 16);
            this.lblGValue.TabIndex = 31;
            this.lblGValue.Text = "G:";
            // 
            // lblBValue
            // 
            this.lblBValue.AutoSize = true;
            this.lblBValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBValue.Location = new System.Drawing.Point(81, 171);
            this.lblBValue.Name = "lblBValue";
            this.lblBValue.Size = new System.Drawing.Size(22, 16);
            this.lblBValue.TabIndex = 32;
            this.lblBValue.Text = "B:";
            // 
            // btnFindColor
            // 
            this.btnFindColor.BackColor = System.Drawing.Color.Silver;
            this.btnFindColor.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnFindColor.FlatAppearance.BorderSize = 2;
            this.btnFindColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFindColor.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFindColor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnFindColor.Location = new System.Drawing.Point(106, 244);
            this.btnFindColor.Name = "btnFindColor";
            this.btnFindColor.Size = new System.Drawing.Size(99, 49);
            this.btnFindColor.TabIndex = 34;
            this.btnFindColor.Text = "Pick Color";
            this.btnFindColor.UseVisualStyleBackColor = false;
            this.btnFindColor.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BtnFindColor_MouseDown);
            this.btnFindColor.MouseEnter += new System.EventHandler(this.BtnFindColor_MouseEnter);
            this.btnFindColor.MouseLeave += new System.EventHandler(this.BtnFindColor_MouseLeave);
            this.btnFindColor.MouseUp += new System.Windows.Forms.MouseEventHandler(this.BtnFindColor_MouseUp);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(98, 197);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 16);
            this.label1.TabIndex = 35;
            this.label1.Text = "Hex Color Code";
            // 
            // txtHexValue
            // 
            this.txtHexValue.Location = new System.Drawing.Point(106, 216);
            this.txtHexValue.Name = "txtHexValue";
            this.txtHexValue.Size = new System.Drawing.Size(100, 20);
            this.txtHexValue.TabIndex = 36;
            // 
            // ptbPreview
            // 
            this.ptbPreview.Location = new System.Drawing.Point(106, 302);
            this.ptbPreview.Name = "ptbPreview";
            this.ptbPreview.Size = new System.Drawing.Size(100, 50);
            this.ptbPreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptbPreview.TabIndex = 37;
            this.ptbPreview.TabStop = false;
            // 
            // ptbColorHistory
            // 
            this.ptbColorHistory.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ptbColorHistory.Location = new System.Drawing.Point(232, 58);
            this.ptbColorHistory.Name = "ptbColorHistory";
            this.ptbColorHistory.Size = new System.Drawing.Size(50, 25);
            this.ptbColorHistory.TabIndex = 38;
            this.ptbColorHistory.TabStop = false;
            this.ptbColorHistory.Click += new System.EventHandler(this.LoadColor_Click);
            this.ptbColorHistory.MouseEnter += new System.EventHandler(this.ChangeCursor_MouseEnter);
            this.ptbColorHistory.MouseLeave += new System.EventHandler(this.ChangeCursor_MouseLeave);
            // 
            // ptbColorHistory2
            // 
            this.ptbColorHistory2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ptbColorHistory2.Location = new System.Drawing.Point(232, 90);
            this.ptbColorHistory2.Name = "ptbColorHistory2";
            this.ptbColorHistory2.Size = new System.Drawing.Size(50, 25);
            this.ptbColorHistory2.TabIndex = 39;
            this.ptbColorHistory2.TabStop = false;
            this.ptbColorHistory2.Click += new System.EventHandler(this.LoadColor_Click);
            this.ptbColorHistory2.MouseEnter += new System.EventHandler(this.ChangeCursor_MouseEnter);
            this.ptbColorHistory2.MouseLeave += new System.EventHandler(this.ChangeCursor_MouseLeave);
            // 
            // ptbColorHistory3
            // 
            this.ptbColorHistory3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ptbColorHistory3.Location = new System.Drawing.Point(232, 123);
            this.ptbColorHistory3.Name = "ptbColorHistory3";
            this.ptbColorHistory3.Size = new System.Drawing.Size(50, 25);
            this.ptbColorHistory3.TabIndex = 40;
            this.ptbColorHistory3.TabStop = false;
            this.ptbColorHistory3.Click += new System.EventHandler(this.LoadColor_Click);
            this.ptbColorHistory3.MouseEnter += new System.EventHandler(this.ChangeCursor_MouseEnter);
            this.ptbColorHistory3.MouseLeave += new System.EventHandler(this.ChangeCursor_MouseLeave);
            // 
            // ptbColorHistory4
            // 
            this.ptbColorHistory4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ptbColorHistory4.Location = new System.Drawing.Point(232, 158);
            this.ptbColorHistory4.Name = "ptbColorHistory4";
            this.ptbColorHistory4.Size = new System.Drawing.Size(50, 25);
            this.ptbColorHistory4.TabIndex = 41;
            this.ptbColorHistory4.TabStop = false;
            this.ptbColorHistory4.Click += new System.EventHandler(this.LoadColor_Click);
            this.ptbColorHistory4.MouseEnter += new System.EventHandler(this.ChangeCursor_MouseEnter);
            this.ptbColorHistory4.MouseLeave += new System.EventHandler(this.ChangeCursor_MouseLeave);
            // 
            // ptbColorHistory5
            // 
            this.ptbColorHistory5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ptbColorHistory5.Location = new System.Drawing.Point(232, 193);
            this.ptbColorHistory5.Name = "ptbColorHistory5";
            this.ptbColorHistory5.Size = new System.Drawing.Size(50, 25);
            this.ptbColorHistory5.TabIndex = 42;
            this.ptbColorHistory5.TabStop = false;
            this.ptbColorHistory5.Click += new System.EventHandler(this.LoadColor_Click);
            this.ptbColorHistory5.MouseEnter += new System.EventHandler(this.ChangeCursor_MouseEnter);
            this.ptbColorHistory5.MouseLeave += new System.EventHandler(this.ChangeCursor_MouseLeave);
            // 
            // ptbColorHistory6
            // 
            this.ptbColorHistory6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ptbColorHistory6.Location = new System.Drawing.Point(232, 226);
            this.ptbColorHistory6.Name = "ptbColorHistory6";
            this.ptbColorHistory6.Size = new System.Drawing.Size(50, 25);
            this.ptbColorHistory6.TabIndex = 43;
            this.ptbColorHistory6.TabStop = false;
            this.ptbColorHistory6.Click += new System.EventHandler(this.LoadColor_Click);
            this.ptbColorHistory6.MouseEnter += new System.EventHandler(this.ChangeCursor_MouseEnter);
            this.ptbColorHistory6.MouseLeave += new System.EventHandler(this.ChangeCursor_MouseLeave);
            // 
            // ptbColorHistory7
            // 
            this.ptbColorHistory7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ptbColorHistory7.Location = new System.Drawing.Point(232, 260);
            this.ptbColorHistory7.Name = "ptbColorHistory7";
            this.ptbColorHistory7.Size = new System.Drawing.Size(50, 25);
            this.ptbColorHistory7.TabIndex = 44;
            this.ptbColorHistory7.TabStop = false;
            this.ptbColorHistory7.Click += new System.EventHandler(this.LoadColor_Click);
            this.ptbColorHistory7.MouseEnter += new System.EventHandler(this.ChangeCursor_MouseEnter);
            this.ptbColorHistory7.MouseLeave += new System.EventHandler(this.ChangeCursor_MouseLeave);
            // 
            // ptbColorHistory8
            // 
            this.ptbColorHistory8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ptbColorHistory8.Location = new System.Drawing.Point(232, 294);
            this.ptbColorHistory8.Name = "ptbColorHistory8";
            this.ptbColorHistory8.Size = new System.Drawing.Size(50, 25);
            this.ptbColorHistory8.TabIndex = 45;
            this.ptbColorHistory8.TabStop = false;
            this.ptbColorHistory8.Click += new System.EventHandler(this.LoadColor_Click);
            this.ptbColorHistory8.MouseEnter += new System.EventHandler(this.ChangeCursor_MouseEnter);
            this.ptbColorHistory8.MouseLeave += new System.EventHandler(this.ChangeCursor_MouseLeave);
            // 
            // ptbColorHistory9
            // 
            this.ptbColorHistory9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ptbColorHistory9.Location = new System.Drawing.Point(232, 327);
            this.ptbColorHistory9.Name = "ptbColorHistory9";
            this.ptbColorHistory9.Size = new System.Drawing.Size(50, 25);
            this.ptbColorHistory9.TabIndex = 46;
            this.ptbColorHistory9.TabStop = false;
            this.ptbColorHistory9.Click += new System.EventHandler(this.LoadColor_Click);
            this.ptbColorHistory9.MouseEnter += new System.EventHandler(this.ChangeCursor_MouseEnter);
            this.ptbColorHistory9.MouseLeave += new System.EventHandler(this.ChangeCursor_MouseLeave);
            // 
            // RectPtbCrosshair
            // 
            this.RectPtbCrosshair.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.RectPtbCrosshair.Location = new System.Drawing.Point(154, 324);
            this.RectPtbCrosshair.Name = "RectPtbCrosshair";
            this.RectPtbCrosshair.Size = new System.Drawing.Size(5, 5);
            this.RectPtbCrosshair.TabIndex = 47;
            this.RectPtbCrosshair.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(312, 364);
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
            this.Controls.Add(this.borderBottom);
            this.Controls.Add(this.borderRight);
            this.Controls.Add(this.borderLeft);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnMinimize);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.borderBottom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.borderRight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.borderLeft)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbColor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbPreview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbColorHistory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbColorHistory2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbColorHistory3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbColorHistory4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbColorHistory5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbColorHistory6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbColorHistory7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbColorHistory8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbColorHistory9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RectPtbCrosshair)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label btnExit;
        private System.Windows.Forms.Label btnMinimize;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox borderBottom;
        private System.Windows.Forms.PictureBox borderRight;
        private System.Windows.Forms.PictureBox borderLeft;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.PictureBox ptbColor;
        private System.Windows.Forms.TextBox txtRValue;
        private System.Windows.Forms.TextBox txtGValue;
        private System.Windows.Forms.TextBox txtBValue;
        private System.Windows.Forms.Label lblRValue;
        private System.Windows.Forms.Label lblGValue;
        private System.Windows.Forms.Label lblBValue;
        private System.Windows.Forms.Button btnFindColor;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtHexValue;
        private System.Windows.Forms.PictureBox ptbPreview;
        private System.Windows.Forms.PictureBox ptbColorHistory;
        private System.Windows.Forms.PictureBox ptbColorHistory2;
        private System.Windows.Forms.PictureBox ptbColorHistory3;
        private System.Windows.Forms.PictureBox ptbColorHistory4;
        private System.Windows.Forms.PictureBox ptbColorHistory5;
        private System.Windows.Forms.PictureBox ptbColorHistory6;
        private System.Windows.Forms.PictureBox ptbColorHistory7;
        private System.Windows.Forms.PictureBox ptbColorHistory8;
        private System.Windows.Forms.PictureBox ptbColorHistory9;
        private System.Windows.Forms.PictureBox RectPtbCrosshair;
    }
}

