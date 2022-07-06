namespace Hastane_Otomasyon_Uygulaması
{
    partial class HastaDüzenlemeVeArama
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HastaDüzenlemeVeArama));
            this.comboBoxilce = new System.Windows.Forms.ComboBox();
            this.fKilcelerillerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.illerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ds_HastaneOtomasyonu = new Hastane_Otomasyon_Uygulaması.ds_HastaneOtomasyonu();
            this.comboBoxil = new System.Windows.Forms.ComboBox();
            this.txtAdres = new System.Windows.Forms.TextBox();
            this.mskTel = new System.Windows.Forms.MaskedTextBox();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbldogum = new System.Windows.Forms.Label();
            this.lblsoyad = new System.Windows.Forms.Label();
            this.lblad = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnDüzenle = new System.Windows.Forms.Button();
            this.mskDogum = new System.Windows.Forms.DateTimePicker();
            this.comboBoxCinsiyet = new System.Windows.Forms.ComboBox();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnGüncelle = new System.Windows.Forms.Button();
            this.lblCinsiyet = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.hastaBilgileriBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mskTc = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnAra = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.hasta_BilgileriTableAdapter = new Hastane_Otomasyon_Uygulaması.ds_HastaneOtomasyonuTableAdapters.Hasta_BilgileriTableAdapter();
            this.fKTedaviBilgileriHastaBilgileriBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tedavi_BilgileriTableAdapter = new Hastane_Otomasyon_Uygulaması.ds_HastaneOtomasyonuTableAdapters.Tedavi_BilgileriTableAdapter();
            this.dsHastaneOtomasyonuBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.illerTableAdapter = new Hastane_Otomasyon_Uygulaması.ds_HastaneOtomasyonuTableAdapters.illerTableAdapter();
            this.ilcelerTableAdapter = new Hastane_Otomasyon_Uygulaması.ds_HastaneOtomasyonuTableAdapters.ilcelerTableAdapter();
            this.formBilgilendirme = new System.Windows.Forms.ToolTip(this.components);
            this.hastane_Otomasyonu_VeritabanıDataSet = new Hastane_Otomasyon_Uygulaması.Hastane_Otomasyonu_VeritabanıDataSet();
            this.hastaBilgileriBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.hasta_BilgileriTableAdapter1 = new Hastane_Otomasyon_Uygulaması.Hastane_Otomasyonu_VeritabanıDataSetTableAdapters.Hasta_BilgileriTableAdapter();
            this.tcNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soyadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dogumTarihiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cinsiyetDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adresDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ilDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ilceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.fKilcelerillerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.illerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds_HastaneOtomasyonu)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hastaBilgileriBindingSource)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fKTedaviBilgileriHastaBilgileriBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsHastaneOtomasyonuBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hastane_Otomasyonu_VeritabanıDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hastaBilgileriBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxilce
            // 
            this.comboBoxilce.DataSource = this.fKilcelerillerBindingSource;
            this.comboBoxilce.DisplayMember = "ilce";
            this.comboBoxilce.FormattingEnabled = true;
            this.comboBoxilce.Location = new System.Drawing.Point(147, 345);
            this.comboBoxilce.Name = "comboBoxilce";
            this.comboBoxilce.Size = new System.Drawing.Size(126, 21);
            this.comboBoxilce.TabIndex = 10;
            this.formBilgilendirme.SetToolTip(this.comboBoxilce, "Bulunduğunuz İlçeyi Güncelleyebilirsiniz");
            // 
            // fKilcelerillerBindingSource
            // 
            this.fKilcelerillerBindingSource.DataMember = "FK_ilceler_iller";
            this.fKilcelerillerBindingSource.DataSource = this.illerBindingSource;
            // 
            // illerBindingSource
            // 
            this.illerBindingSource.DataMember = "iller";
            this.illerBindingSource.DataSource = this.ds_HastaneOtomasyonu;
            // 
            // ds_HastaneOtomasyonu
            // 
            this.ds_HastaneOtomasyonu.DataSetName = "ds_HastaneOtomasyonu";
            this.ds_HastaneOtomasyonu.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // comboBoxil
            // 
            this.comboBoxil.DataSource = this.illerBindingSource;
            this.comboBoxil.DisplayMember = "sehir";
            this.comboBoxil.FormattingEnabled = true;
            this.comboBoxil.Location = new System.Drawing.Point(147, 314);
            this.comboBoxil.Name = "comboBoxil";
            this.comboBoxil.Size = new System.Drawing.Size(126, 21);
            this.comboBoxil.TabIndex = 9;
            this.formBilgilendirme.SetToolTip(this.comboBoxil, "Bulunduğunuz İli Güncelleyebilirsiniz");
            // 
            // txtAdres
            // 
            this.txtAdres.Location = new System.Drawing.Point(144, 377);
            this.txtAdres.Multiline = true;
            this.txtAdres.Name = "txtAdres";
            this.txtAdres.Size = new System.Drawing.Size(129, 60);
            this.txtAdres.TabIndex = 11;
            this.formBilgilendirme.SetToolTip(this.txtAdres, "Adresinizi Güncelleyebilirsiniz");
            // 
            // mskTel
            // 
            this.mskTel.Location = new System.Drawing.Point(147, 281);
            this.mskTel.Mask = "00000000000";
            this.mskTel.Name = "mskTel";
            this.mskTel.Size = new System.Drawing.Size(126, 20);
            this.mskTel.TabIndex = 8;
            this.formBilgilendirme.SetToolTip(this.mskTel, "Telefon Numaranızı Güncelleyebilirsiniz");
            this.mskTel.ValidatingType = typeof(int);
            // 
            // txtSoyad
            // 
            this.txtSoyad.Location = new System.Drawing.Point(147, 179);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(126, 20);
            this.txtSoyad.TabIndex = 5;
            this.formBilgilendirme.SetToolTip(this.txtSoyad, "Soyadınızı Girebilirsiniz");
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(147, 147);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(126, 20);
            this.txtAd.TabIndex = 4;
            this.formBilgilendirme.SetToolTip(this.txtAd, "Adınızı Girebilirsiniz");
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(95, 346);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 16);
            this.label4.TabIndex = 30;
            this.label4.Text = "İlçe :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(111, 314);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 16);
            this.label3.TabIndex = 29;
            this.label3.Text = "İl :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(77, 378);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 16);
            this.label2.TabIndex = 28;
            this.label2.Text = "Adres :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(64, 282);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 16);
            this.label1.TabIndex = 27;
            this.label1.Text = "Telefon :";
            // 
            // lbldogum
            // 
            this.lbldogum.AutoSize = true;
            this.lbldogum.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldogum.Location = new System.Drawing.Point(20, 211);
            this.lbldogum.Name = "lbldogum";
            this.lbldogum.Size = new System.Drawing.Size(119, 16);
            this.lbldogum.TabIndex = 25;
            this.lbldogum.Text = "Doğum Tarihi :";
            // 
            // lblsoyad
            // 
            this.lblsoyad.AutoSize = true;
            this.lblsoyad.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsoyad.Location = new System.Drawing.Point(77, 180);
            this.lblsoyad.Name = "lblsoyad";
            this.lblsoyad.Size = new System.Drawing.Size(63, 16);
            this.lblsoyad.TabIndex = 24;
            this.lblsoyad.Text = "Soyad :";
            // 
            // lblad
            // 
            this.lblad.AutoSize = true;
            this.lblad.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblad.Location = new System.Drawing.Point(100, 147);
            this.lblad.Name = "lblad";
            this.lblad.Size = new System.Drawing.Size(45, 16);
            this.lblad.TabIndex = 23;
            this.lblad.Text = "Ad : ";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnDüzenle);
            this.panel1.Controls.Add(this.mskDogum);
            this.panel1.Controls.Add(this.comboBoxCinsiyet);
            this.panel1.Controls.Add(this.btnSil);
            this.panel1.Controls.Add(this.btnGüncelle);
            this.panel1.Controls.Add(this.lblCinsiyet);
            this.panel1.Location = new System.Drawing.Point(12, 125);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(301, 395);
            this.panel1.TabIndex = 39;
            // 
            // btnDüzenle
            // 
            this.btnDüzenle.BackgroundImage = global::Hastane_Otomasyon_Uygulaması.Properties.Resources.edit_button;
            this.btnDüzenle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnDüzenle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDüzenle.FlatAppearance.BorderSize = 0;
            this.btnDüzenle.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnDüzenle.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnDüzenle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDüzenle.Location = new System.Drawing.Point(29, 329);
            this.btnDüzenle.Name = "btnDüzenle";
            this.btnDüzenle.Size = new System.Drawing.Size(71, 56);
            this.btnDüzenle.TabIndex = 2;
            this.formBilgilendirme.SetToolTip(this.btnDüzenle, "Düzenleme Yapmak için nesnelere erişimi açar");
            this.btnDüzenle.UseVisualStyleBackColor = true;
            this.btnDüzenle.Click += new System.EventHandler(this.btnDüzenle_Click);
            // 
            // mskDogum
            // 
            this.mskDogum.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.mskDogum.Location = new System.Drawing.Point(132, 82);
            this.mskDogum.Name = "mskDogum";
            this.mskDogum.Size = new System.Drawing.Size(129, 20);
            this.mskDogum.TabIndex = 6;
            this.formBilgilendirme.SetToolTip(this.mskDogum, "Doğum Tarihinizi Giriniz");
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
            this.comboBoxCinsiyet.Location = new System.Drawing.Point(135, 120);
            this.comboBoxCinsiyet.Name = "comboBoxCinsiyet";
            this.comboBoxCinsiyet.Size = new System.Drawing.Size(126, 21);
            this.comboBoxCinsiyet.TabIndex = 7;
            this.comboBoxCinsiyet.Text = "Belirtilmedi...";
            this.formBilgilendirme.SetToolTip(this.comboBoxCinsiyet, "Cinsiyetinizi Belirtiniz");
            // 
            // btnSil
            // 
            this.btnSil.BackgroundImage = global::Hastane_Otomasyon_Uygulaması.Properties.Resources.blueaccountdelete;
            this.btnSil.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSil.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSil.FlatAppearance.BorderSize = 0;
            this.btnSil.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnSil.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnSil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSil.Location = new System.Drawing.Point(204, 329);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(81, 56);
            this.btnSil.TabIndex = 13;
            this.formBilgilendirme.SetToolTip(this.btnSil, "Kayıtlı Hastanın Kaydını Siler");
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnGüncelle
            // 
            this.btnGüncelle.BackgroundImage = global::Hastane_Otomasyon_Uygulaması.Properties.Resources.update;
            this.btnGüncelle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnGüncelle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGüncelle.FlatAppearance.BorderSize = 0;
            this.btnGüncelle.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnGüncelle.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnGüncelle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGüncelle.Location = new System.Drawing.Point(113, 329);
            this.btnGüncelle.Name = "btnGüncelle";
            this.btnGüncelle.Size = new System.Drawing.Size(72, 56);
            this.btnGüncelle.TabIndex = 12;
            this.formBilgilendirme.SetToolTip(this.btnGüncelle, "Verileri Günceller");
            this.btnGüncelle.UseVisualStyleBackColor = true;
            this.btnGüncelle.Click += new System.EventHandler(this.btnGüncelle_Click);
            // 
            // lblCinsiyet
            // 
            this.lblCinsiyet.AutoSize = true;
            this.lblCinsiyet.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCinsiyet.Location = new System.Drawing.Point(48, 121);
            this.lblCinsiyet.Name = "lblCinsiyet";
            this.lblCinsiyet.Size = new System.Drawing.Size(78, 16);
            this.lblCinsiyet.TabIndex = 5;
            this.lblCinsiyet.Text = "Cinsiyet :";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tcNoDataGridViewTextBoxColumn,
            this.adDataGridViewTextBoxColumn,
            this.soyadDataGridViewTextBoxColumn,
            this.dogumTarihiDataGridViewTextBoxColumn,
            this.cinsiyetDataGridViewTextBoxColumn,
            this.telefonDataGridViewTextBoxColumn,
            this.adresDataGridViewTextBoxColumn,
            this.ilDataGridViewTextBoxColumn,
            this.ilceDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.hastaBilgileriBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(332, 125);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(689, 395);
            this.dataGridView1.TabIndex = 41;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // hastaBilgileriBindingSource
            // 
            this.hastaBilgileriBindingSource.DataMember = "Hasta_Bilgileri";
            this.hastaBilgileriBindingSource.DataSource = this.ds_HastaneOtomasyonu;
            // 
            // mskTc
            // 
            this.mskTc.Location = new System.Drawing.Point(72, 47);
            this.mskTc.Mask = "00000000000";
            this.mskTc.Name = "mskTc";
            this.mskTc.Size = new System.Drawing.Size(126, 20);
            this.mskTc.TabIndex = 0;
            this.formBilgilendirme.SetToolTip(this.mskTc, "Aramak istediğiniz Hastanın T.C. Kimlik Numarasını Giriniz");
            this.mskTc.ValidatingType = typeof(int);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Myanmar Text", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Maroon;
            this.label5.Location = new System.Drawing.Point(38, 4);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(195, 42);
            this.label5.TabIndex = 0;
            this.label5.Text = "Lütfen Aramak İstediğiniz Kişinin\r\n         T.C. Numarasını Giriniz.";
            // 
            // btnAra
            // 
            this.btnAra.Location = new System.Drawing.Point(204, 41);
            this.btnAra.Name = "btnAra";
            this.btnAra.Size = new System.Drawing.Size(75, 31);
            this.btnAra.TabIndex = 1;
            this.btnAra.Text = "ARA";
            this.btnAra.UseVisualStyleBackColor = true;
            this.btnAra.Click += new System.EventHandler(this.btnAra_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkSalmon;
            this.panel2.Controls.Add(this.btnAra);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.mskTc);
            this.panel2.Location = new System.Drawing.Point(12, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(301, 81);
            this.panel2.TabIndex = 40;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DarkSalmon;
            this.panel3.Controls.Add(this.label6);
            this.panel3.Location = new System.Drawing.Point(332, 12);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(689, 81);
            this.panel3.TabIndex = 42;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Monotype Corsiva", 36F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.Color.Firebrick;
            this.label6.Location = new System.Drawing.Point(83, 10);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(479, 57);
            this.label6.TabIndex = 0;
            this.label6.Text = "HASTA KAYIT LİSTESİ";
            // 
            // hasta_BilgileriTableAdapter
            // 
            this.hasta_BilgileriTableAdapter.ClearBeforeFill = true;
            // 
            // fKTedaviBilgileriHastaBilgileriBindingSource
            // 
            this.fKTedaviBilgileriHastaBilgileriBindingSource.DataMember = "FK_Tedavi_Bilgileri_Hasta_Bilgileri";
            this.fKTedaviBilgileriHastaBilgileriBindingSource.DataSource = this.hastaBilgileriBindingSource;
            // 
            // tedavi_BilgileriTableAdapter
            // 
            this.tedavi_BilgileriTableAdapter.ClearBeforeFill = true;
            // 
            // dsHastaneOtomasyonuBindingSource
            // 
            this.dsHastaneOtomasyonuBindingSource.DataSource = this.ds_HastaneOtomasyonu;
            this.dsHastaneOtomasyonuBindingSource.Position = 0;
            // 
            // illerTableAdapter
            // 
            this.illerTableAdapter.ClearBeforeFill = true;
            // 
            // ilcelerTableAdapter
            // 
            this.ilcelerTableAdapter.ClearBeforeFill = true;
            // 
            // hastane_Otomasyonu_VeritabanıDataSet
            // 
            this.hastane_Otomasyonu_VeritabanıDataSet.DataSetName = "Hastane_Otomasyonu_VeritabanıDataSet";
            this.hastane_Otomasyonu_VeritabanıDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // hastaBilgileriBindingSource1
            // 
            this.hastaBilgileriBindingSource1.DataMember = "Hasta_Bilgileri";
            this.hastaBilgileriBindingSource1.DataSource = this.hastane_Otomasyonu_VeritabanıDataSet;
            // 
            // hasta_BilgileriTableAdapter1
            // 
            this.hasta_BilgileriTableAdapter1.ClearBeforeFill = true;
            // 
            // tcNoDataGridViewTextBoxColumn
            // 
            this.tcNoDataGridViewTextBoxColumn.DataPropertyName = "Tc_No";
            this.tcNoDataGridViewTextBoxColumn.HeaderText = "T.C. No";
            this.tcNoDataGridViewTextBoxColumn.Name = "tcNoDataGridViewTextBoxColumn";
            // 
            // adDataGridViewTextBoxColumn
            // 
            this.adDataGridViewTextBoxColumn.DataPropertyName = "Ad";
            this.adDataGridViewTextBoxColumn.HeaderText = "Ad";
            this.adDataGridViewTextBoxColumn.Name = "adDataGridViewTextBoxColumn";
            // 
            // soyadDataGridViewTextBoxColumn
            // 
            this.soyadDataGridViewTextBoxColumn.DataPropertyName = "Soyad";
            this.soyadDataGridViewTextBoxColumn.HeaderText = "Soyad";
            this.soyadDataGridViewTextBoxColumn.Name = "soyadDataGridViewTextBoxColumn";
            // 
            // dogumTarihiDataGridViewTextBoxColumn
            // 
            this.dogumTarihiDataGridViewTextBoxColumn.DataPropertyName = "Dogum_Tarihi";
            this.dogumTarihiDataGridViewTextBoxColumn.HeaderText = "Doğum Tarihi";
            this.dogumTarihiDataGridViewTextBoxColumn.Name = "dogumTarihiDataGridViewTextBoxColumn";
            // 
            // cinsiyetDataGridViewTextBoxColumn
            // 
            this.cinsiyetDataGridViewTextBoxColumn.DataPropertyName = "Cinsiyet";
            this.cinsiyetDataGridViewTextBoxColumn.HeaderText = "Cinsiyet";
            this.cinsiyetDataGridViewTextBoxColumn.Name = "cinsiyetDataGridViewTextBoxColumn";
            // 
            // telefonDataGridViewTextBoxColumn
            // 
            this.telefonDataGridViewTextBoxColumn.DataPropertyName = "Telefon";
            this.telefonDataGridViewTextBoxColumn.HeaderText = "Telefon";
            this.telefonDataGridViewTextBoxColumn.Name = "telefonDataGridViewTextBoxColumn";
            // 
            // adresDataGridViewTextBoxColumn
            // 
            this.adresDataGridViewTextBoxColumn.DataPropertyName = "Adres";
            this.adresDataGridViewTextBoxColumn.HeaderText = "Adres";
            this.adresDataGridViewTextBoxColumn.Name = "adresDataGridViewTextBoxColumn";
            // 
            // ilDataGridViewTextBoxColumn
            // 
            this.ilDataGridViewTextBoxColumn.DataPropertyName = "il";
            this.ilDataGridViewTextBoxColumn.HeaderText = "il";
            this.ilDataGridViewTextBoxColumn.Name = "ilDataGridViewTextBoxColumn";
            // 
            // ilceDataGridViewTextBoxColumn
            // 
            this.ilceDataGridViewTextBoxColumn.DataPropertyName = "ilce";
            this.ilceDataGridViewTextBoxColumn.HeaderText = "ilçe";
            this.ilceDataGridViewTextBoxColumn.Name = "ilceDataGridViewTextBoxColumn";
            // 
            // HastaDüzenlemeVeArama
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = global::Hastane_Otomasyon_Uygulaması.Properties.Resources.backkground;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1044, 532);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.comboBoxilce);
            this.Controls.Add(this.comboBoxil);
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
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "HastaDüzenlemeVeArama";
            this.Text = "Hasta Arama Ve Düzenleme Menüsü";
            this.Load += new System.EventHandler(this.HastaDüzenlemeVeArama_Load);
            ((System.ComponentModel.ISupportInitialize)(this.fKilcelerillerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.illerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds_HastaneOtomasyonu)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hastaBilgileriBindingSource)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fKTedaviBilgileriHastaBilgileriBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsHastaneOtomasyonuBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hastane_Otomasyonu_VeritabanıDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hastaBilgileriBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxilce;
        private System.Windows.Forms.ComboBox comboBoxil;
        private System.Windows.Forms.TextBox txtAdres;
        private System.Windows.Forms.MaskedTextBox mskTel;
        private System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbldogum;
        private System.Windows.Forms.Label lblsoyad;
        private System.Windows.Forms.Label lblad;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnGüncelle;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.MaskedTextBox mskTc;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnAra;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label6;
        private ds_HastaneOtomasyonu ds_HastaneOtomasyonu;
        private System.Windows.Forms.BindingSource hastaBilgileriBindingSource;
        private ds_HastaneOtomasyonuTableAdapters.Hasta_BilgileriTableAdapter hasta_BilgileriTableAdapter;
        private System.Windows.Forms.ComboBox comboBoxCinsiyet;
        private System.Windows.Forms.Label lblCinsiyet;
        private System.Windows.Forms.DateTimePicker mskDogum;
        private System.Windows.Forms.Button btnDüzenle;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.BindingSource fKTedaviBilgileriHastaBilgileriBindingSource;
        private ds_HastaneOtomasyonuTableAdapters.Tedavi_BilgileriTableAdapter tedavi_BilgileriTableAdapter;
        private System.Windows.Forms.BindingSource dsHastaneOtomasyonuBindingSource;
        private System.Windows.Forms.BindingSource illerBindingSource;
        private ds_HastaneOtomasyonuTableAdapters.illerTableAdapter illerTableAdapter;
        private System.Windows.Forms.BindingSource fKilcelerillerBindingSource;
        private ds_HastaneOtomasyonuTableAdapters.ilcelerTableAdapter ilcelerTableAdapter;
        private System.Windows.Forms.ToolTip formBilgilendirme;
        private Hastane_Otomasyonu_VeritabanıDataSet hastane_Otomasyonu_VeritabanıDataSet;
        private System.Windows.Forms.BindingSource hastaBilgileriBindingSource1;
        private Hastane_Otomasyonu_VeritabanıDataSetTableAdapters.Hasta_BilgileriTableAdapter hasta_BilgileriTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn tcNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn soyadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dogumTarihiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cinsiyetDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefonDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adresDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ilDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ilceDataGridViewTextBoxColumn;
    }
}