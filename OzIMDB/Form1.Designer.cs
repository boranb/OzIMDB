namespace OzIMDB
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnYeniFilm = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtFilmId = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.gboPuan = new System.Windows.Forms.GroupBox();
            this.rbPuan5 = new System.Windows.Forms.RadioButton();
            this.rbPuan4 = new System.Windows.Forms.RadioButton();
            this.rbPuan3 = new System.Windows.Forms.RadioButton();
            this.rbPuan2 = new System.Windows.Forms.RadioButton();
            this.rbPuan1 = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.txtFilmAd = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pboFoto = new System.Windows.Forms.PictureBox();
            this.lstFilmler = new System.Windows.Forms.ListBox();
            this.rbPuanYok = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.gboPuan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pboFoto)).BeginInit();
            this.SuspendLayout();
            // 
            // btnYeniFilm
            // 
            this.btnYeniFilm.Location = new System.Drawing.Point(9, 304);
            this.btnYeniFilm.Name = "btnYeniFilm";
            this.btnYeniFilm.Size = new System.Drawing.Size(200, 23);
            this.btnYeniFilm.TabIndex = 6;
            this.btnYeniFilm.Text = "Yeni Film Ekle";
            this.btnYeniFilm.UseVisualStyleBackColor = true;
            this.btnYeniFilm.Click += new System.EventHandler(this.btnYeniFilm_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtFilmId);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btnYeniFilm);
            this.groupBox1.Controls.Add(this.gboPuan);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtFilmAd);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.pboFoto);
            this.groupBox1.Location = new System.Drawing.Point(10, 14);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(389, 350);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Film Detayları";
            // 
            // txtFilmId
            // 
            this.txtFilmId.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFilmId.Location = new System.Drawing.Point(203, 49);
            this.txtFilmId.Name = "txtFilmId";
            this.txtFilmId.Size = new System.Drawing.Size(180, 20);
            this.txtFilmId.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(200, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Film No:";
            // 
            // gboPuan
            // 
            this.gboPuan.Controls.Add(this.rbPuanYok);
            this.gboPuan.Controls.Add(this.rbPuan5);
            this.gboPuan.Controls.Add(this.rbPuan4);
            this.gboPuan.Controls.Add(this.rbPuan3);
            this.gboPuan.Controls.Add(this.rbPuan2);
            this.gboPuan.Controls.Add(this.rbPuan1);
            this.gboPuan.Location = new System.Drawing.Point(9, 83);
            this.gboPuan.Name = "gboPuan";
            this.gboPuan.Size = new System.Drawing.Size(180, 207);
            this.gboPuan.TabIndex = 4;
            this.gboPuan.TabStop = false;
            this.gboPuan.Text = "Puan";
            // 
            // rbPuan5
            // 
            this.rbPuan5.AutoSize = true;
            this.rbPuan5.Location = new System.Drawing.Point(6, 164);
            this.rbPuan5.Name = "rbPuan5";
            this.rbPuan5.Size = new System.Drawing.Size(72, 17);
            this.rbPuan5.TabIndex = 4;
            this.rbPuan5.TabStop = true;
            this.rbPuan5.Tag = "5";
            this.rbPuan5.Text = "5 - Çok İyi";
            this.rbPuan5.UseVisualStyleBackColor = true;
            // 
            // rbPuan4
            // 
            this.rbPuan4.AutoSize = true;
            this.rbPuan4.Location = new System.Drawing.Point(6, 137);
            this.rbPuan4.Name = "rbPuan4";
            this.rbPuan4.Size = new System.Drawing.Size(50, 17);
            this.rbPuan4.TabIndex = 3;
            this.rbPuan4.TabStop = true;
            this.rbPuan4.Tag = "4";
            this.rbPuan4.Text = "4 - İyi";
            this.rbPuan4.UseVisualStyleBackColor = true;
            // 
            // rbPuan3
            // 
            this.rbPuan3.AutoSize = true;
            this.rbPuan3.Location = new System.Drawing.Point(6, 110);
            this.rbPuan3.Name = "rbPuan3";
            this.rbPuan3.Size = new System.Drawing.Size(60, 17);
            this.rbPuan3.TabIndex = 2;
            this.rbPuan3.TabStop = true;
            this.rbPuan3.Tag = "3";
            this.rbPuan3.Text = "3 - Orta";
            this.rbPuan3.UseVisualStyleBackColor = true;
            // 
            // rbPuan2
            // 
            this.rbPuan2.AutoSize = true;
            this.rbPuan2.Location = new System.Drawing.Point(6, 83);
            this.rbPuan2.Name = "rbPuan2";
            this.rbPuan2.Size = new System.Drawing.Size(62, 17);
            this.rbPuan2.TabIndex = 1;
            this.rbPuan2.TabStop = true;
            this.rbPuan2.Tag = "2";
            this.rbPuan2.Text = "2 - Kötü";
            this.rbPuan2.UseVisualStyleBackColor = true;
            // 
            // rbPuan1
            // 
            this.rbPuan1.AutoSize = true;
            this.rbPuan1.Location = new System.Drawing.Point(6, 56);
            this.rbPuan1.Name = "rbPuan1";
            this.rbPuan1.Size = new System.Drawing.Size(84, 17);
            this.rbPuan1.TabIndex = 0;
            this.rbPuan1.TabStop = true;
            this.rbPuan1.Tag = "1";
            this.rbPuan1.Text = "1 - Çok Kötü";
            this.rbPuan1.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.Location = new System.Drawing.Point(218, 293);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(150, 34);
            this.label3.TabIndex = 5;
            this.label3.Text = "Resmi Değiştirmek İçin Üzerine Tıklayınız";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtFilmAd
            // 
            this.txtFilmAd.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFilmAd.Location = new System.Drawing.Point(9, 49);
            this.txtFilmAd.Name = "txtFilmAd";
            this.txtFilmAd.Size = new System.Drawing.Size(180, 20);
            this.txtFilmAd.TabIndex = 1;
            this.txtFilmAd.TextChanged += new System.EventHandler(this.txtFilmAd_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Film Adı:";
            // 
            // pboFoto
            // 
            this.pboFoto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pboFoto.Location = new System.Drawing.Point(218, 90);
            this.pboFoto.Name = "pboFoto";
            this.pboFoto.Size = new System.Drawing.Size(150, 200);
            this.pboFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pboFoto.TabIndex = 0;
            this.pboFoto.TabStop = false;
            // 
            // lstFilmler
            // 
            this.lstFilmler.DisplayMember = "FilmAd";
            this.lstFilmler.FormattingEnabled = true;
            this.lstFilmler.Location = new System.Drawing.Point(405, 22);
            this.lstFilmler.Name = "lstFilmler";
            this.lstFilmler.Size = new System.Drawing.Size(287, 342);
            this.lstFilmler.TabIndex = 0;
            this.lstFilmler.ValueMember = "Id";
            this.lstFilmler.SelectedIndexChanged += new System.EventHandler(this.lstFilmler_SelectedIndexChanged);
            // 
            // rbPuanYok
            // 
            this.rbPuanYok.AutoSize = true;
            this.rbPuanYok.Location = new System.Drawing.Point(6, 29);
            this.rbPuanYok.Name = "rbPuanYok";
            this.rbPuanYok.Size = new System.Drawing.Size(93, 17);
            this.rbPuanYok.TabIndex = 5;
            this.rbPuanYok.TabStop = true;
            this.rbPuanYok.Tag = "";
            this.rbPuanYok.Text = "Puanlanmamış";
            this.rbPuanYok.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.ClientSize = new System.Drawing.Size(704, 377);
            this.Controls.Add(this.lstFilmler);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Öz IMDB";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gboPuan.ResumeLayout(false);
            this.gboPuan.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pboFoto)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnYeniFilm;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtFilmId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox gboPuan;
        private System.Windows.Forms.RadioButton rbPuan5;
        private System.Windows.Forms.RadioButton rbPuan4;
        private System.Windows.Forms.RadioButton rbPuan3;
        private System.Windows.Forms.RadioButton rbPuan2;
        private System.Windows.Forms.RadioButton rbPuan1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtFilmAd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pboFoto;
        private System.Windows.Forms.ListBox lstFilmler;
        private System.Windows.Forms.RadioButton rbPuanYok;
    }
}

