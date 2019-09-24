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
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnSettings = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.mainpage1 = new ColorX.Mainpage();
            this.settings1 = new ColorX.Settings();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.borderBottom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.borderRight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.borderLeft)).BeginInit();
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
            this.borderBottom.Location = new System.Drawing.Point(5, 368);
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
            this.borderRight.Size = new System.Drawing.Size(5, 352);
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
            this.borderLeft.Size = new System.Drawing.Size(5, 352);
            this.borderLeft.TabIndex = 21;
            this.borderLeft.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            // 
            // btnSettings
            // 
            this.btnSettings.BackColor = System.Drawing.Color.Silver;
            this.btnSettings.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnSettings.FlatAppearance.BorderSize = 2;
            this.btnSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSettings.Font = new System.Drawing.Font("Roboto", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSettings.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnSettings.Location = new System.Drawing.Point(22, 22);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(51, 46);
            this.btnSettings.TabIndex = 64;
            this.btnSettings.Text = "⚙";
            this.btnSettings.UseVisualStyleBackColor = false;
            this.btnSettings.Click += new System.EventHandler(this.BtnSettings_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Silver;
            this.btnBack.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnBack.FlatAppearance.BorderSize = 2;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Roboto", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnBack.Location = new System.Drawing.Point(33, 22);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(30, 46);
            this.btnBack.TabIndex = 65;
            this.btnBack.Text = "⮜";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Visible = false;
            this.btnBack.Click += new System.EventHandler(this.BtnBack_Click);
            // 
            // mainpage1
            // 
            this.mainpage1.Location = new System.Drawing.Point(5, 22);
            this.mainpage1.Name = "mainpage1";
            this.mainpage1.Size = new System.Drawing.Size(302, 346);
            this.mainpage1.TabIndex = 24;
            // 
            // settings1
            // 
            this.settings1.Location = new System.Drawing.Point(5, 21);
            this.settings1.Name = "settings1";
            this.settings1.Size = new System.Drawing.Size(302, 346);
            this.settings1.TabIndex = 25;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(312, 373);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnSettings);
            this.Controls.Add(this.mainpage1);
            this.Controls.Add(this.borderBottom);
            this.Controls.Add(this.borderRight);
            this.Controls.Add(this.borderLeft);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnMinimize);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.settings1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.borderBottom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.borderRight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.borderLeft)).EndInit();
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
        private System.Windows.Forms.Timer timer1;
        private Mainpage mainpage1;
        private Settings settings1;
        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.Button btnBack;
    }
}

