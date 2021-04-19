namespace ArabaYarisi
{
    partial class FrmGameRace
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmGameRace));
            this.line1 = new System.Windows.Forms.PictureBox();
            this.line2 = new System.Windows.Forms.PictureBox();
            this.line3 = new System.Windows.Forms.PictureBox();
            this.line4 = new System.Windows.Forms.PictureBox();
            this.pCar = new System.Windows.Forms.PictureBox();
            this.pCoin = new System.Windows.Forms.PictureBox();
            this.gameTimer4 = new System.Windows.Forms.Timer();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnStart = new DevExpress.XtraEditors.SimpleButton();
            this.pEnemy1 = new System.Windows.Forms.PictureBox();
            this.pEnemy2 = new System.Windows.Forms.PictureBox();
            this.pEnemy3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.line1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.line2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.line3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.line4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pCar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pCoin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pEnemy1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pEnemy2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pEnemy3)).BeginInit();
            this.SuspendLayout();
            // 
            // line1
            // 
            this.line1.BackColor = System.Drawing.Color.White;
            this.line1.Location = new System.Drawing.Point(150, 15);
            this.line1.Name = "line1";
            this.line1.Size = new System.Drawing.Size(10, 66);
            this.line1.TabIndex = 0;
            this.line1.TabStop = false;
            // 
            // line2
            // 
            this.line2.BackColor = System.Drawing.Color.White;
            this.line2.Location = new System.Drawing.Point(150, 113);
            this.line2.Name = "line2";
            this.line2.Size = new System.Drawing.Size(10, 72);
            this.line2.TabIndex = 1;
            this.line2.TabStop = false;
            // 
            // line3
            // 
            this.line3.BackColor = System.Drawing.Color.White;
            this.line3.Location = new System.Drawing.Point(150, 216);
            this.line3.Name = "line3";
            this.line3.Size = new System.Drawing.Size(10, 76);
            this.line3.TabIndex = 2;
            this.line3.TabStop = false;
            // 
            // line4
            // 
            this.line4.BackColor = System.Drawing.Color.White;
            this.line4.Location = new System.Drawing.Point(150, 328);
            this.line4.Name = "line4";
            this.line4.Size = new System.Drawing.Size(10, 73);
            this.line4.TabIndex = 3;
            this.line4.TabStop = false;
            // 
            // pCar
            // 
            this.pCar.Image = ((System.Drawing.Image)(resources.GetObject("pCar.Image")));
            this.pCar.Location = new System.Drawing.Point(216, 318);
            this.pCar.Name = "pCar";
            this.pCar.Size = new System.Drawing.Size(44, 71);
            this.pCar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pCar.TabIndex = 4;
            this.pCar.TabStop = false;
            // 
            // pCoin
            // 
            this.pCoin.Image = ((System.Drawing.Image)(resources.GetObject("pCoin.Image")));
            this.pCoin.Location = new System.Drawing.Point(80, 195);
            this.pCoin.Name = "pCoin";
            this.pCoin.Size = new System.Drawing.Size(25, 28);
            this.pCoin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pCoin.TabIndex = 5;
            this.pCoin.TabStop = false;
            // 
            // gameTimer4
            // 
            this.gameTimer4.Tick += new System.EventHandler(this.gameTimer4_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Location = new System.Drawing.Point(0, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(10, 448);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.White;
            this.pictureBox2.Location = new System.Drawing.Point(298, 1);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(10, 448);
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(63, 407);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(184, 29);
            this.btnStart.TabIndex = 8;
            this.btnStart.Text = "Başla";
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // pEnemy1
            // 
            this.pEnemy1.Image = ((System.Drawing.Image)(resources.GetObject("pEnemy1.Image")));
            this.pEnemy1.Location = new System.Drawing.Point(61, 81);
            this.pEnemy1.Name = "pEnemy1";
            this.pEnemy1.Size = new System.Drawing.Size(55, 30);
            this.pEnemy1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pEnemy1.TabIndex = 9;
            this.pEnemy1.TabStop = false;
            // 
            // pEnemy2
            // 
            this.pEnemy2.Image = ((System.Drawing.Image)(resources.GetObject("pEnemy2.Image")));
            this.pEnemy2.Location = new System.Drawing.Point(180, 155);
            this.pEnemy2.Name = "pEnemy2";
            this.pEnemy2.Size = new System.Drawing.Size(57, 30);
            this.pEnemy2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pEnemy2.TabIndex = 10;
            this.pEnemy2.TabStop = false;
            // 
            // pEnemy3
            // 
            this.pEnemy3.Image = ((System.Drawing.Image)(resources.GetObject("pEnemy3.Image")));
            this.pEnemy3.Location = new System.Drawing.Point(30, 234);
            this.pEnemy3.Name = "pEnemy3";
            this.pEnemy3.Size = new System.Drawing.Size(58, 30);
            this.pEnemy3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pEnemy3.TabIndex = 11;
            this.pEnemy3.TabStop = false;
            // 
            // FrmGameRace
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(307, 450);
            this.Controls.Add(this.pEnemy3);
            this.Controls.Add(this.pEnemy2);
            this.Controls.Add(this.pEnemy1);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pCoin);
            this.Controls.Add(this.pCar);
            this.Controls.Add(this.line4);
            this.Controls.Add(this.line3);
            this.Controls.Add(this.line2);
            this.Controls.Add(this.line1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmGameRace";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FrmGameRace_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmGameRace_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.line1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.line2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.line3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.line4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pCar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pCoin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pEnemy1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pEnemy2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pEnemy3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox line1;
        private System.Windows.Forms.PictureBox line2;
        private System.Windows.Forms.PictureBox line3;
        private System.Windows.Forms.PictureBox line4;
        private System.Windows.Forms.PictureBox pCar;
        private System.Windows.Forms.PictureBox pCoin;
        private System.Windows.Forms.Timer gameTimer4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private DevExpress.XtraEditors.SimpleButton btnStart;
        private System.Windows.Forms.PictureBox pEnemy1;
        private System.Windows.Forms.PictureBox pEnemy2;
        private System.Windows.Forms.PictureBox pEnemy3;
    }
}

