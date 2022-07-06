namespace Hastane_Otomasyon_Uygulaması
{
    partial class HastaKayitFormu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HastaKayitFormu));
            this.ustPanel = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblBaslik = new System.Windows.Forms.Label();
            this.lblTc = new System.Windows.Forms.Label();
            this.lblad = new System.Windows.Forms.Label();
            this.lblsoyad = new System.Windows.Forms.Label();
            this.lbldogum = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.mskTel = new System.Windows.Forms.MaskedTextBox();
            this.txtAdres = new System.Windows.Forms.TextBox();
            this.ds_HastaneOtomasyonu = new Hastane_Otomasyon_Uygulaması.ds_HastaneOtomasyonu();
            this.btnKayit = new System.Windows.Forms.Button();
            this.comboBoxil = new System.Windows.Forms.ComboBox();
            this.illerBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.dsHastaneOtomasyonuBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comboBoxilce = new System.Windows.Forms.ComboBox();
            this.fKilcelerillerBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.fKilcelerillerBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.fKilcelerillerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.illerBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.ilcelerTableAdapter = new Hastane_Otomasyon_Uygulaması.ds_HastaneOtomasyonuTableAdapters.ilcelerTableAdapter();
            this.ilcelerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.illerTableAdapter = new Hastane_Otomasyon_Uygulaması.ds_HastaneOtomasyonuTableAdapters.illerTableAdapter();
            this.illerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comboBoxCinsiyet = new System.Windows.Forms.ComboBox();
            this.lblCinsiyet = new System.Windows.Forms.Label();
            this.mskDogum = new System.Windows.Forms.DateTimePicker();
            this.mskTc = new System.Windows.Forms.MaskedTextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.ustPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds_HastaneOtomasyonu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.illerBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsHastaneOtomasyonuBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKilcelerillerBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKilcelerillerBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKilcelerillerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.illerBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ilcelerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.illerBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // ustPanel
            // 
            this.ustPanel.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ustPanel.Controls.Add(this.pictureBox2);
            this.ustPanel.Controls.Add(this.pictureBox1);
            this.ustPanel.Controls.Add(this.lblBaslik);
            this.ustPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.ustPanel.Location = new System.Drawing.Point(0, 0);
            this.ustPanel.Name = "ustPanel";
            this.ustPanel.Size = new System.Drawing.Size(343, 48);
            this.ustPanel.TabIndex = 0;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Hastane_Otomasyon_Uygulaması.Properties.Resources.reçete1;
            this.pictureBox2.Location = new System.Drawing.Point(0, -1);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(79, 49);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 20;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Hastane_Otomasyon_Uygulaması.Properties.Resources.pngguru1;
            this.pictureBox1.Location = new System.Drawing.Point(264, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(79, 49);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // lblBaslik
            // 
            this.lblBaslik.AutoSize = true;
            this.lblBaslik.Font = new System.Drawing.Font("Monotype Corsiva", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBaslik.ForeColor = System.Drawing.Color.Maroon;
            this.lblBaslik.Location = new System.Drawing.Point(107, 9);
            this.lblBaslik.Name = "lblBaslik";
            this.lblBaslik.Size = new System.Drawing.Size(151, 33);
            this.lblBaslik.TabIndex = 3;
            this.lblBaslik.Text = "Kayıt Formu";
            // 
            // lblTc
            // 
            this.lblTc.AutoSize = true;
            this.lblTc.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTc.Location = new System.Drawing.Point(62, 77);
            this.lblTc.Name = "lblTc";
            this.lblTc.Size = new System.Drawing.Size(64, 16);
            this.lblTc.TabIndex = 1;
            this.lblTc.Text = "Tc No :";
            // 
            // lblad
            // 
            this.lblad.AutoSize = true;
            this.lblad.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblad.Location = new System.Drawing.Point(85, 107);
            this.lblad.Name = "lblad";
            this.lblad.Size = new System.Drawing.Size(45, 16);
            this.lblad.TabIndex = 2;
            this.lblad.Text = "Ad : ";
            // 
            // lblsoyad
            // 
            this.lblsoyad.AutoSize = true;
            this.lblsoyad.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsoyad.Location = new System.Drawing.Point(62, 140);
            this.lblsoyad.Name = "lblsoyad";
            this.lblsoyad.Size = new System.Drawing.Size(63, 16);
            this.lblsoyad.TabIndex = 3;
            this.lblsoyad.Text = "Soyad :";
            // 
            // lbldogum
            // 
            this.lbldogum.AutoSize = true;
            this.lbldogum.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldogum.Location = new System.Drawing.Point(5, 171);
            this.lbldogum.Name = "lbldogum";
            this.lbldogum.Size = new System.Drawing.Size(119, 16);
            this.lbldogum.TabIndex = 4;
            this.lbldogum.Text = "Doğum Tarihi :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(50, 233);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "Telefon :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(63, 329);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "Adres :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(97, 265);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = "İl :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(81, 297);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 16);
            this.label4.TabIndex = 10;
            this.label4.Text = "İlçe :";
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(132, 107);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(126, 20);
            this.txtAd.TabIndex = 2;
            this.toolTip1.SetToolTip(this.txtAd, "İsminizi Giriniz");
            // 
            // txtSoyad
            // 
            this.txtSoyad.Location = new System.Drawing.Point(132, 139);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(126, 20);
            this.txtSoyad.TabIndex = 3;
            this.toolTip1.SetToolTip(this.txtSoyad, "Soyadınızı Giriniz");
            // 
            // mskTel
            // 
            this.mskTel.Location = new System.Drawing.Point(133, 232);
            this.mskTel.Mask = "00000000000";
            this.mskTel.Name = "mskTel";
            this.mskTel.Size = new System.Drawing.Size(125, 20);
            this.mskTel.TabIndex = 6;
            this.toolTip1.SetToolTip(this.mskTel, "Telefon Numaranızı 053******* olacak şekilde giriniz");
            // 
            // txtAdres
            // 
            this.txtAdres.Location = new System.Drawing.Point(130, 328);
            this.txtAdres.Multiline = true;
            this.txtAdres.Name = "txtAdres";
            this.txtAdres.Size = new System.Drawing.Size(128, 60);
            this.txtAdres.TabIndex = 9;
            this.toolTip1.SetToolTip(this.txtAdres, "Mahalle/Cadde/Sokak/Semt/Kapı No/Daire Bilgilerinizi Giriniz ");
            // 
            // ds_HastaneOtomasyonu
            // 
            this.ds_HastaneOtomasyonu.DataSetName = "ds_HastaneOtomasyonu";
            this.ds_HastaneOtomasyonu.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnKayit
            // 
            this.btnKayit.Location = new System.Drawing.Point(136, 404);
            this.btnKayit.Name = "btnKayit";
            this.btnKayit.Size = new System.Drawing.Size(104, 34);
            this.btnKayit.TabIndex = 10;
            this.btnKayit.Text = "Kaydet";
            this.toolTip1.SetToolTip(this.btnKayit, "Bilgilerinizi Kontrol Ettikten sonra Kaydedebilirsiniz");
            this.btnKayit.UseVisualStyleBackColor = true;
            this.btnKayit.Click += new System.EventHandler(this.btnKayit_Click);
            // 
            // comboBoxil
            // 
            this.comboBoxil.DataSource = this.illerBindingSource2;
            this.comboBoxil.DisplayMember = "sehir";
            this.comboBoxil.FormattingEnabled = true;
            this.comboBoxil.Location = new System.Drawing.Point(133, 265);
            this.comboBoxil.Name = "comboBoxil";
            this.comboBoxil.Size = new System.Drawing.Size(125, 21);
            this.comboBoxil.TabIndex = 7;
            this.toolTip1.SetToolTip(this.comboBoxil, "Yaşadığınız İli Seçiniz");
            // 
            // illerBindingSource2
            // 
            this.illerBindingSource2.DataMember = "iller";
            this.illerBindingSource2.DataSource = this.dsHastaneOtomasyonuBindingSource;
            // 
            // dsHastaneOtomasyonuBindingSource
            // 
            this.dsHastaneOtomasyonuBindingSource.DataSource = this.ds_HastaneOtomasyonu;
            this.dsHastaneOtomasyonuBindingSource.Position = 0;
            // 
            // comboBoxilce
            // 
            this.comboBoxilce.DataSource = this.fKilcelerillerBindingSource2;
            this.comboBoxilce.DisplayMember = "ilce";
            this.comboBoxilce.FormattingEnabled = true;
            this.comboBoxilce.Location = new System.Drawing.Point(133, 296);
            this.comboBoxilce.Name = "comboBoxilce";
            this.comboBoxilce.Size = new System.Drawing.Size(125, 21);
            this.comboBoxilce.TabIndex = 8;
            this.toolTip1.SetToolTip(this.comboBoxilce, "Yaşadığınız İlçeyi Seçiniz");
            // 
            // fKilcelerillerBindingSource2
            // 
            this.fKilcelerillerBindingSource2.DataMember = "FK_ilceler_iller";
            this.fKilcelerillerBindingSource2.DataSource = this.illerBindingSource2;
            // 
            // illerBindingSource1
            // 
            this.illerBindingSource1.DataMember = "iller";
            // 
            // ilcelerTableAdapter
            // 
            this.ilcelerTableAdapter.ClearBeforeFill = true;
            // 
            // ilcelerBindingSource
            // 
            this.ilcelerBindingSource.DataMember = "ilceler";
            // 
            // illerTableAdapter
            // 
            this.illerTableAdapter.ClearBeforeFill = true;
            // 
            // illerBindingSource
            // 
            this.illerBindingSource.DataMember = "iller";
            // 
            // comboBoxCinsiyet
            // 
            this.comboBoxCinsiyet.AutoCompleteCustomSource.AddRange(new string[] {
            "Bay",
            "Bayan"});
            this.comboBoxCinsiyet.FormattingEnabled = true;
            this.comboBoxCinsiyet.Items.AddRange(new object[] {
            "Bay",
            "Bayan"});
            this.comboBoxCinsiyet.Location = new System.Drawing.Point(131, 199);
            this.comboBoxCinsiyet.Name = "comboBoxCinsiyet";
            this.comboBoxCinsiyet.Size = new System.Drawing.Size(127, 21);
            this.comboBoxCinsiyet.TabIndex = 5;
            this.comboBoxCinsiyet.Text = "Belirtilmedi...";
            this.toolTip1.SetToolTip(this.comboBoxCinsiyet, "Cinsiyetinizi Seçiniz");
            // 
            // lblCinsiyet
            // 
            this.lblCinsiyet.AutoSize = true;
            this.lblCinsiyet.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCinsiyet.Location = new System.Drawing.Point(44, 200);
            this.lblCinsiyet.Name = "lblCinsiyet";
            this.lblCinsiyet.Size = new System.Drawing.Size(78, 16);
            this.lblCinsiyet.TabIndex = 22;
            this.lblCinsiyet.Text = "Cinsiyet :";
            // 
            // mskDogum
            // 
            this.mskDogum.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.mskDogum.Location = new System.Drawing.Point(132, 167);
            this.mskDogum.Name = "mskDogum";
            this.mskDogum.Size = new System.Drawing.Size(126, 20);
            this.mskDogum.TabIndex = 4;
            this.toolTip1.SetToolTip(this.mskDogum, "Kimliğinizdeki Doğum Tarihinizi Giriniz");
            // 
            // mskTc
            // 
            this.mskTc.Location = new System.Drawing.Point(131, 76);
            this.mskTc.Mask = "00000000000";
            this.mskTc.Name = "mskTc";
            this.mskTc.Size = new System.Drawing.Size(127, 20);
            this.mskTc.TabIndex = 1;
            this.toolTip1.SetToolTip(this.mskTc, "T.C. Kimlik Numaranızı Giriniz");
            this.mskTc.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.mskTc_MaskInputRejected);
            // 
            // HastaKayitFormu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Bisque;
            this.ClientSize = new System.Drawing.Size(343, 483);
            this.Controls.Add(this.mskTc);
            this.Controls.Add(this.mskDogum);
            this.Controls.Add(this.comboBoxCinsiyet);
            this.Controls.Add(this.lblCinsiyet);
            this.Controls.Add(this.comboBoxilce);
            this.Controls.Add(this.comboBoxil);
            this.Controls.Add(this.btnKayit);
            this.Controls.Add(this.txtAdres);
            this.Controls.Add(this.mskTel);
            this.Controls.Add(this.txtSoyad);
            this.Controls.Add(this.txtAd);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbldogum);
            this.Controls.Add(this.lblsoyad);
            this.Controls.Add(this.lblad);
            this.Controls.Add(this.lblTc);
            this.Controls.Add(this.ustPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "HastaKayitFormu";
            this.Text = "Hasta Kayıt Formu";
            this.Load += new System.EventHandler(this.HastaKayitFormu_Load);
            this.ustPanel.ResumeLayout(false);
            this.ustPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds_HastaneOtomasyonu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.illerBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsHastaneOtomasyonuBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKilcelerillerBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKilcelerillerBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKilcelerillerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.illerBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ilcelerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.illerBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel ustPanel;
        private System.Windows.Forms.Label lblTc;
        private System.Windows.Forms.Label lblad;
        private System.Windows.Forms.Label lblsoyad;
        private System.Windows.Forms.Label lbldogum;
        private System.Windows.Forms.Label lblBaslik;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.MaskedTextBox mskTel;
        private System.Windows.Forms.TextBox txtAdres;
        private System.Windows.Forms.Button btnKayit;
        private ds_HastaneOtomasyonu ds_HastaneOtomasyonu;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ComboBox comboBoxil;
        private System.Windows.Forms.ComboBox comboBoxilce;
        private System.Windows.Forms.BindingSource fKilcelerillerBindingSource1;
        private System.Windows.Forms.BindingSource fKilcelerillerBindingSource;
        private System.Windows.Forms.BindingSource illerBindingSource1;
        private ds_HastaneOtomasyonuTableAdapters.ilcelerTableAdapter ilcelerTableAdapter;
        private System.Windows.Forms.BindingSource ilcelerBindingSource;
        private ds_HastaneOtomasyonuTableAdapters.illerTableAdapter illerTableAdapter;
        private System.Windows.Forms.BindingSource illerBindingSource;
        private System.Windows.Forms.BindingSource dsHastaneOtomasyonuBindingSource;
        private System.Windows.Forms.BindingSource illerBindingSource2;
        private System.Windows.Forms.BindingSource fKilcelerillerBindingSource2;
        private System.Windows.Forms.ComboBox comboBoxCinsiyet;
        private System.Windows.Forms.Label lblCinsiyet;
        private System.Windows.Forms.DateTimePicker mskDogum;
        private System.Windows.Forms.MaskedTextBox mskTc;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}