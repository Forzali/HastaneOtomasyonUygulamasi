namespace Hastane_Otomasyon_Uygulaması
{
    partial class TedaviBilgileri
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TedaviBilgileri));
            this.tedaviListesi = new System.Windows.Forms.DataGridView();
            this.polNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.drSicilNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hTcNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tedaviTarihiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tedaviDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tedaviSonucuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tedaviBilgileriBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hastane_Otomasyonu_VeritabanıDataSet = new Hastane_Otomasyon_Uygulaması.Hastane_Otomasyonu_VeritabanıDataSet();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label18 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.DrSicilNoGüncelYazi = new System.Windows.Forms.Label();
            this.drSicilNoGüncel = new System.Windows.Forms.Label();
            this.txtGüncelSonuc = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtGüncelTedavi = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnDüzenle = new System.Windows.Forms.Button();
            this.dtpGüncelTarih = new System.Windows.Forms.DateTimePicker();
            this.btnGüncelle = new System.Windows.Forms.Button();
            this.mskGüncelTc = new System.Windows.Forms.MaskedTextBox();
            this.btnSil = new System.Windows.Forms.Button();
            this.comboBoxGüncelPolno = new System.Windows.Forms.ComboBox();
            this.poliklinikBilgileriBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnAra = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtSonuc = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.DrSicilNo = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.dtpTarih = new System.Windows.Forms.DateTimePicker();
            this.mskTc = new System.Windows.Forms.MaskedTextBox();
            this.comboBoxPolno = new System.Windows.Forms.ComboBox();
            this.txtTedavi = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tedavi_BilgileriTableAdapter = new Hastane_Otomasyon_Uygulaması.Hastane_Otomasyonu_VeritabanıDataSetTableAdapters.Tedavi_BilgileriTableAdapter();
            this.poliklinik_BilgileriTableAdapter = new Hastane_Otomasyon_Uygulaması.Hastane_Otomasyonu_VeritabanıDataSetTableAdapters.Poliklinik_BilgileriTableAdapter();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.tedaviListesi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tedaviBilgileriBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hastane_Otomasyonu_VeritabanıDataSet)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.poliklinikBilgileriBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tedaviListesi
            // 
            this.tedaviListesi.AutoGenerateColumns = false;
            this.tedaviListesi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tedaviListesi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tedaviListesi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.polNoDataGridViewTextBoxColumn,
            this.drSicilNoDataGridViewTextBoxColumn,
            this.hTcNoDataGridViewTextBoxColumn,
            this.tedaviTarihiDataGridViewTextBoxColumn,
            this.tedaviDataGridViewTextBoxColumn,
            this.tedaviSonucuDataGridViewTextBoxColumn});
            this.tedaviListesi.DataSource = this.tedaviBilgileriBindingSource;
            this.tedaviListesi.Location = new System.Drawing.Point(7, 394);
            this.tedaviListesi.Name = "tedaviListesi";
            this.tedaviListesi.Size = new System.Drawing.Size(657, 198);
            this.tedaviListesi.TabIndex = 33;
            this.tedaviListesi.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.teshisListesi_CellClick);
            this.tedaviListesi.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tedaviListesi_CellContentClick);
            // 
            // polNoDataGridViewTextBoxColumn
            // 
            this.polNoDataGridViewTextBoxColumn.DataPropertyName = "Pol_No";
            this.polNoDataGridViewTextBoxColumn.HeaderText = "Poliklinik No";
            this.polNoDataGridViewTextBoxColumn.Name = "polNoDataGridViewTextBoxColumn";
            // 
            // drSicilNoDataGridViewTextBoxColumn
            // 
            this.drSicilNoDataGridViewTextBoxColumn.DataPropertyName = "DrSicilNo";
            this.drSicilNoDataGridViewTextBoxColumn.HeaderText = "Dr. Sicil No";
            this.drSicilNoDataGridViewTextBoxColumn.Name = "drSicilNoDataGridViewTextBoxColumn";
            // 
            // hTcNoDataGridViewTextBoxColumn
            // 
            this.hTcNoDataGridViewTextBoxColumn.DataPropertyName = "H_TcNo";
            this.hTcNoDataGridViewTextBoxColumn.HeaderText = "Hasta T.C. No";
            this.hTcNoDataGridViewTextBoxColumn.Name = "hTcNoDataGridViewTextBoxColumn";
            // 
            // tedaviTarihiDataGridViewTextBoxColumn
            // 
            this.tedaviTarihiDataGridViewTextBoxColumn.DataPropertyName = "Tedavi_Tarihi";
            this.tedaviTarihiDataGridViewTextBoxColumn.HeaderText = "Tedavi Tarihi";
            this.tedaviTarihiDataGridViewTextBoxColumn.Name = "tedaviTarihiDataGridViewTextBoxColumn";
            // 
            // tedaviDataGridViewTextBoxColumn
            // 
            this.tedaviDataGridViewTextBoxColumn.DataPropertyName = "Tedavi";
            this.tedaviDataGridViewTextBoxColumn.HeaderText = "Tedavi";
            this.tedaviDataGridViewTextBoxColumn.Name = "tedaviDataGridViewTextBoxColumn";
            // 
            // tedaviSonucuDataGridViewTextBoxColumn
            // 
            this.tedaviSonucuDataGridViewTextBoxColumn.DataPropertyName = "Tedavi_Sonucu";
            this.tedaviSonucuDataGridViewTextBoxColumn.HeaderText = "Tedavi Sonucu";
            this.tedaviSonucuDataGridViewTextBoxColumn.Name = "tedaviSonucuDataGridViewTextBoxColumn";
            // 
            // tedaviBilgileriBindingSource
            // 
            this.tedaviBilgileriBindingSource.DataMember = "Tedavi_Bilgileri";
            this.tedaviBilgileriBindingSource.DataSource = this.hastane_Otomasyonu_VeritabanıDataSet;
            // 
            // hastane_Otomasyonu_VeritabanıDataSet
            // 
            this.hastane_Otomasyonu_VeritabanıDataSet.DataSetName = "Hastane_Otomasyonu_VeritabanıDataSet";
            this.hastane_Otomasyonu_VeritabanıDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Chartreuse;
            this.panel4.Controls.Add(this.label18);
            this.panel4.Location = new System.Drawing.Point(7, 347);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(657, 47);
            this.panel4.TabIndex = 32;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.BackColor = System.Drawing.Color.Chartreuse;
            this.label18.Font = new System.Drawing.Font("Monotype Corsiva", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label18.ForeColor = System.Drawing.Color.Firebrick;
            this.label18.Location = new System.Drawing.Point(198, 5);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(307, 39);
            this.label18.TabIndex = 6;
            this.label18.Text = "TEDAVİ KAYITLARI";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.panel3.Controls.Add(this.DrSicilNoGüncelYazi);
            this.panel3.Controls.Add(this.drSicilNoGüncel);
            this.panel3.Controls.Add(this.txtGüncelSonuc);
            this.panel3.Controls.Add(this.label13);
            this.panel3.Controls.Add(this.txtGüncelTedavi);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.btnDüzenle);
            this.panel3.Controls.Add(this.dtpGüncelTarih);
            this.panel3.Controls.Add(this.btnGüncelle);
            this.panel3.Controls.Add(this.mskGüncelTc);
            this.panel3.Controls.Add(this.btnSil);
            this.panel3.Controls.Add(this.comboBoxGüncelPolno);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.label12);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.btnAra);
            this.panel3.Location = new System.Drawing.Point(362, 12);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(302, 312);
            this.panel3.TabIndex = 31;
            // 
            // DrSicilNoGüncelYazi
            // 
            this.DrSicilNoGüncelYazi.AutoSize = true;
            this.DrSicilNoGüncelYazi.Location = new System.Drawing.Point(156, 256);
            this.DrSicilNoGüncelYazi.Name = "DrSicilNoGüncelYazi";
            this.DrSicilNoGüncelYazi.Size = new System.Drawing.Size(38, 13);
            this.DrSicilNoGüncelYazi.TabIndex = 25;
            this.DrSicilNoGüncelYazi.Text = "Sicilno";
            this.DrSicilNoGüncelYazi.Visible = false;
            // 
            // drSicilNoGüncel
            // 
            this.drSicilNoGüncel.AutoSize = true;
            this.drSicilNoGüncel.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.drSicilNoGüncel.Location = new System.Drawing.Point(6, 251);
            this.drSicilNoGüncel.Name = "drSicilNoGüncel";
            this.drSicilNoGüncel.Size = new System.Drawing.Size(144, 20);
            this.drSicilNoGüncel.TabIndex = 24;
            this.drSicilNoGüncel.Text = "Doktor Sicil Numarası :";
            this.drSicilNoGüncel.Visible = false;
            // 
            // txtGüncelSonuc
            // 
            this.txtGüncelSonuc.BackColor = System.Drawing.Color.LightYellow;
            this.txtGüncelSonuc.Location = new System.Drawing.Point(130, 222);
            this.txtGüncelSonuc.Name = "txtGüncelSonuc";
            this.txtGüncelSonuc.Size = new System.Drawing.Size(128, 20);
            this.txtGüncelSonuc.TabIndex = 13;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label13.Location = new System.Drawing.Point(24, 220);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(106, 20);
            this.label13.TabIndex = 22;
            this.label13.Text = "Tedavi Sonucu :";
            // 
            // txtGüncelTedavi
            // 
            this.txtGüncelTedavi.BackColor = System.Drawing.Color.LightYellow;
            this.txtGüncelTedavi.Location = new System.Drawing.Point(132, 167);
            this.txtGüncelTedavi.Multiline = true;
            this.txtGüncelTedavi.Name = "txtGüncelTedavi";
            this.txtGüncelTedavi.Size = new System.Drawing.Size(126, 47);
            this.txtGüncelTedavi.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(73, 165);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 20);
            this.label7.TabIndex = 21;
            this.label7.Text = "Tedavi :";
            // 
            // btnDüzenle
            // 
            this.btnDüzenle.Location = new System.Drawing.Point(37, 277);
            this.btnDüzenle.Name = "btnDüzenle";
            this.btnDüzenle.Size = new System.Drawing.Size(75, 23);
            this.btnDüzenle.TabIndex = 14;
            this.btnDüzenle.Text = "Düzenle";
            this.toolTip1.SetToolTip(this.btnDüzenle, "Kutuların Kilidini Kaldırır");
            this.btnDüzenle.UseVisualStyleBackColor = true;
            this.btnDüzenle.Click += new System.EventHandler(this.btnDüzenle_Click);
            // 
            // dtpGüncelTarih
            // 
            this.dtpGüncelTarih.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpGüncelTarih.Location = new System.Drawing.Point(132, 73);
            this.dtpGüncelTarih.Name = "dtpGüncelTarih";
            this.dtpGüncelTarih.Size = new System.Drawing.Size(126, 20);
            this.dtpGüncelTarih.TabIndex = 9;
            // 
            // btnGüncelle
            // 
            this.btnGüncelle.Location = new System.Drawing.Point(118, 277);
            this.btnGüncelle.Name = "btnGüncelle";
            this.btnGüncelle.Size = new System.Drawing.Size(75, 23);
            this.btnGüncelle.TabIndex = 15;
            this.btnGüncelle.Text = "Güncelle";
            this.toolTip1.SetToolTip(this.btnGüncelle, "Verileri Günceller");
            this.btnGüncelle.UseVisualStyleBackColor = true;
            this.btnGüncelle.Click += new System.EventHandler(this.btnGüncelle_Click);
            // 
            // mskGüncelTc
            // 
            this.mskGüncelTc.Location = new System.Drawing.Point(132, 47);
            this.mskGüncelTc.Mask = "00000000000";
            this.mskGüncelTc.Name = "mskGüncelTc";
            this.mskGüncelTc.Size = new System.Drawing.Size(126, 20);
            this.mskGüncelTc.TabIndex = 8;
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(199, 277);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(75, 23);
            this.btnSil.TabIndex = 16;
            this.btnSil.Text = "Sil";
            this.toolTip1.SetToolTip(this.btnSil, "Kaydı Siler");
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // comboBoxGüncelPolno
            // 
            this.comboBoxGüncelPolno.BackColor = System.Drawing.Color.LightYellow;
            this.comboBoxGüncelPolno.DataSource = this.poliklinikBilgileriBindingSource;
            this.comboBoxGüncelPolno.DisplayMember = "Pol_No";
            this.comboBoxGüncelPolno.FormattingEnabled = true;
            this.comboBoxGüncelPolno.Location = new System.Drawing.Point(132, 140);
            this.comboBoxGüncelPolno.Name = "comboBoxGüncelPolno";
            this.comboBoxGüncelPolno.Size = new System.Drawing.Size(126, 21);
            this.comboBoxGüncelPolno.TabIndex = 11;
            // 
            // poliklinikBilgileriBindingSource
            // 
            this.poliklinikBilgileriBindingSource.DataMember = "Poliklinik_Bilgileri";
            this.poliklinikBilgileriBindingSource.DataSource = this.hastane_Otomasyonu_VeritabanıDataSet;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(4, 138);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(129, 20);
            this.label4.TabIndex = 15;
            this.label4.Text = "Poliklinik Numarası :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(41, 72);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 20);
            this.label6.TabIndex = 14;
            this.label6.Text = "Tedavi Tarihi :";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label12.Location = new System.Drawing.Point(33, 45);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(99, 20);
            this.label12.TabIndex = 13;
            this.label12.Text = "Hasta T.C. No :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.Maroon;
            this.label5.Location = new System.Drawing.Point(3, 10);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(294, 25);
            this.label5.TabIndex = 5;
            this.label5.Text = "Tedavi Kaydı Ara / Düzenle / Sil";
            // 
            // btnAra
            // 
            this.btnAra.Location = new System.Drawing.Point(157, 99);
            this.btnAra.Name = "btnAra";
            this.btnAra.Size = new System.Drawing.Size(75, 23);
            this.btnAra.TabIndex = 10;
            this.btnAra.Text = "ARA";
            this.toolTip1.SetToolTip(this.btnAra, "Arama işlemi");
            this.btnAra.UseVisualStyleBackColor = true;
            this.btnAra.Click += new System.EventHandler(this.btnAra_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Orange;
            this.panel1.Controls.Add(this.txtSonuc);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.DrSicilNo);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.dtpTarih);
            this.panel1.Controls.Add(this.mskTc);
            this.panel1.Controls.Add(this.comboBoxPolno);
            this.panel1.Controls.Add(this.txtTedavi);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.btnKaydet);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(7, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(300, 312);
            this.panel1.TabIndex = 30;
            // 
            // txtSonuc
            // 
            this.txtSonuc.Location = new System.Drawing.Point(147, 241);
            this.txtSonuc.Name = "txtSonuc";
            this.txtSonuc.Size = new System.Drawing.Size(125, 20);
            this.txtSonuc.TabIndex = 6;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(41, 239);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(106, 20);
            this.label9.TabIndex = 15;
            this.label9.Text = "Tedavi Sonucu :";
            // 
            // DrSicilNo
            // 
            this.DrSicilNo.Location = new System.Drawing.Point(146, 86);
            this.DrSicilNo.Name = "DrSicilNo";
            this.DrSicilNo.Size = new System.Drawing.Size(126, 20);
            this.DrSicilNo.TabIndex = 2;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(3, 84);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(144, 20);
            this.label8.TabIndex = 13;
            this.label8.Text = "Doktor Sicil Numarası :";
            // 
            // dtpTarih
            // 
            this.dtpTarih.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpTarih.Location = new System.Drawing.Point(147, 139);
            this.dtpTarih.Name = "dtpTarih";
            this.dtpTarih.Size = new System.Drawing.Size(126, 20);
            this.dtpTarih.TabIndex = 4;
            // 
            // mskTc
            // 
            this.mskTc.Location = new System.Drawing.Point(147, 113);
            this.mskTc.Mask = "00000000000";
            this.mskTc.Name = "mskTc";
            this.mskTc.Size = new System.Drawing.Size(126, 20);
            this.mskTc.TabIndex = 3;
            // 
            // comboBoxPolno
            // 
            this.comboBoxPolno.DataSource = this.poliklinikBilgileriBindingSource;
            this.comboBoxPolno.DisplayMember = "Pol_No";
            this.comboBoxPolno.FormattingEnabled = true;
            this.comboBoxPolno.Location = new System.Drawing.Point(146, 55);
            this.comboBoxPolno.Name = "comboBoxPolno";
            this.comboBoxPolno.Size = new System.Drawing.Size(126, 21);
            this.comboBoxPolno.TabIndex = 1;
            // 
            // txtTedavi
            // 
            this.txtTedavi.Location = new System.Drawing.Point(147, 168);
            this.txtTedavi.Multiline = true;
            this.txtTedavi.Name = "txtTedavi";
            this.txtTedavi.Size = new System.Drawing.Size(126, 64);
            this.txtTedavi.TabIndex = 5;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.Location = new System.Drawing.Point(90, 168);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(57, 20);
            this.label11.TabIndex = 9;
            this.label11.Text = "Tedavi :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(18, 53);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(129, 20);
            this.label10.TabIndex = 7;
            this.label10.Text = "Poliklinik Numarası :";
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(167, 277);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(75, 23);
            this.btnKaydet.TabIndex = 7;
            this.btnKaydet.Text = "Kaydet";
            this.toolTip1.SetToolTip(this.btnKaydet, "Kayıt işlemi");
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(58, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tedavi Kaydı Oluştur";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(56, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Tedavi Tarihi :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(48, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Hasta T.C. No :";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Hastane_Otomasyon_Uygulaması.Properties.Resources.dc;
            this.pictureBox1.Location = new System.Drawing.Point(665, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(326, 580);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 34;
            this.pictureBox1.TabStop = false;
            // 
            // tedavi_BilgileriTableAdapter
            // 
            this.tedavi_BilgileriTableAdapter.ClearBeforeFill = true;
            // 
            // poliklinik_BilgileriTableAdapter
            // 
            this.poliklinik_BilgileriTableAdapter.ClearBeforeFill = true;
            // 
            // TedaviBilgileri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.DarkTurquoise;
            this.ClientSize = new System.Drawing.Size(969, 610);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.tedaviListesi);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "TedaviBilgileri";
            this.Text = "Tedavi Bilgileri Ve İşlemleri";
            this.Load += new System.EventHandler(this.TedaviBilgileri_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tedaviListesi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tedaviBilgileriBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hastane_Otomasyonu_VeritabanıDataSet)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.poliklinikBilgileriBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView tedaviListesi;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtGüncelTedavi;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnDüzenle;
        private System.Windows.Forms.DateTimePicker dtpGüncelTarih;
        private System.Windows.Forms.Button btnGüncelle;
        private System.Windows.Forms.MaskedTextBox mskGüncelTc;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.ComboBox comboBoxGüncelPolno;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnAra;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DateTimePicker dtpTarih;
        private System.Windows.Forms.MaskedTextBox mskTc;
        private System.Windows.Forms.ComboBox comboBoxPolno;
        private System.Windows.Forms.TextBox txtTedavi;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label DrSicilNoGüncelYazi;
        private System.Windows.Forms.Label drSicilNoGüncel;
        private System.Windows.Forms.TextBox txtGüncelSonuc;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtSonuc;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox DrSicilNo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Hastane_Otomasyonu_VeritabanıDataSet hastane_Otomasyonu_VeritabanıDataSet;
        private System.Windows.Forms.BindingSource tedaviBilgileriBindingSource;
        private Hastane_Otomasyonu_VeritabanıDataSetTableAdapters.Tedavi_BilgileriTableAdapter tedavi_BilgileriTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn polNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn drSicilNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hTcNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tedaviTarihiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tedaviDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tedaviSonucuDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource poliklinikBilgileriBindingSource;
        private Hastane_Otomasyonu_VeritabanıDataSetTableAdapters.Poliklinik_BilgileriTableAdapter poliklinik_BilgileriTableAdapter;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}