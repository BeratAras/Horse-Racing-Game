namespace At_Oyunu__G_
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label label4;
            System.Windows.Forms.Label label3;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button2 = new System.Windows.Forms.Button();
            this.btnBasla = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.txtDurum = new System.Windows.Forms.TextBox();
            this.txtAt1puan = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtAt2puan = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtAt3puan = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnYenidenBaslat = new System.Windows.Forms.Button();
            label4 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            label4.BackColor = System.Drawing.Color.White;
            label4.Location = new System.Drawing.Point(0, 355);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(972, 23);
            label4.TabIndex = 13;
            // 
            // label3
            // 
            label3.BackColor = System.Drawing.Color.White;
            label3.Location = new System.Drawing.Point(0, 234);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(972, 23);
            label3.TabIndex = 12;
            // 
            // label2
            // 
            label2.BackColor = System.Drawing.Color.White;
            label2.Location = new System.Drawing.Point(0, 111);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(972, 23);
            label2.TabIndex = 11;
            // 
            // label1
            // 
            label1.BackColor = System.Drawing.Color.White;
            label1.Location = new System.Drawing.Point(0, 2);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(972, 23);
            label1.TabIndex = 10;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(964, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(33, 376);
            this.button2.TabIndex = 18;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // btnBasla
            // 
            this.btnBasla.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnBasla.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBasla.Location = new System.Drawing.Point(3, 411);
            this.btnBasla.Name = "btnBasla";
            this.btnBasla.Size = new System.Drawing.Size(108, 44);
            this.btnBasla.TabIndex = 17;
            this.btnBasla.Text = "BAŞLA";
            this.btnBasla.UseVisualStyleBackColor = false;
            this.btnBasla.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(3, 270);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(108, 80);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 16;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(3, 147);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(108, 80);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 15;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 28);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(108, 80);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(298, 397);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 13);
            this.label5.TabIndex = 20;
            this.label5.Text = "SON DURUM";
            // 
            // txtDurum
            // 
            this.txtDurum.AcceptsTab = true;
            this.txtDurum.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDurum.Enabled = false;
            this.txtDurum.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtDurum.Location = new System.Drawing.Point(261, 419);
            this.txtDurum.Name = "txtDurum";
            this.txtDurum.Size = new System.Drawing.Size(159, 30);
            this.txtDurum.TabIndex = 21;
            this.txtDurum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtAt1puan
            // 
            this.txtAt1puan.AcceptsTab = true;
            this.txtAt1puan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAt1puan.Enabled = false;
            this.txtAt1puan.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtAt1puan.Location = new System.Drawing.Point(491, 419);
            this.txtAt1puan.Name = "txtAt1puan";
            this.txtAt1puan.Size = new System.Drawing.Size(54, 30);
            this.txtAt1puan.TabIndex = 23;
            this.txtAt1puan.Text = "0";
            this.txtAt1puan.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(445, 397);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(150, 13);
            this.label6.TabIndex = 22;
            this.label6.Text = "Birinci At Kazanma Sayısı";
            // 
            // txtAt2puan
            // 
            this.txtAt2puan.AcceptsTab = true;
            this.txtAt2puan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAt2puan.Enabled = false;
            this.txtAt2puan.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtAt2puan.Location = new System.Drawing.Point(659, 419);
            this.txtAt2puan.Name = "txtAt2puan";
            this.txtAt2puan.Size = new System.Drawing.Size(54, 30);
            this.txtAt2puan.TabIndex = 25;
            this.txtAt2puan.Text = "0";
            this.txtAt2puan.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(613, 397);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(146, 13);
            this.label7.TabIndex = 24;
            this.label7.Text = "İkinci At Kazanma Sayısı";
            // 
            // txtAt3puan
            // 
            this.txtAt3puan.AcceptsTab = true;
            this.txtAt3puan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAt3puan.Enabled = false;
            this.txtAt3puan.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtAt3puan.Location = new System.Drawing.Point(821, 419);
            this.txtAt3puan.Name = "txtAt3puan";
            this.txtAt3puan.Size = new System.Drawing.Size(54, 30);
            this.txtAt3puan.TabIndex = 27;
            this.txtAt3puan.Text = "0";
            this.txtAt3puan.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(775, 397);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(159, 13);
            this.label8.TabIndex = 26;
            this.label8.Text = "Üçüncü At Kazanma Sayısı";
            // 
            // btnYenidenBaslat
            // 
            this.btnYenidenBaslat.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnYenidenBaslat.Font = new System.Drawing.Font("Forte", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnYenidenBaslat.Location = new System.Drawing.Point(117, 411);
            this.btnYenidenBaslat.Name = "btnYenidenBaslat";
            this.btnYenidenBaslat.Size = new System.Drawing.Size(108, 44);
            this.btnYenidenBaslat.TabIndex = 28;
            this.btnYenidenBaslat.Text = "Yeniden Başlat";
            this.btnYenidenBaslat.UseVisualStyleBackColor = false;
            this.btnYenidenBaslat.Click += new System.EventHandler(this.btnYenidenBaslat_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.btnBasla;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.ForestGreen;
            this.ClientSize = new System.Drawing.Size(994, 476);
            this.Controls.Add(this.btnYenidenBaslat);
            this.Controls.Add(this.txtAt3puan);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtAt2puan);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtAt1puan);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtDurum);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnBasla);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(label4);
            this.Controls.Add(label3);
            this.Controls.Add(label2);
            this.Controls.Add(label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AT OYUNU";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnBasla;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDurum;
        private System.Windows.Forms.TextBox txtAt1puan;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtAt2puan;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtAt3puan;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnYenidenBaslat;
    }
}

