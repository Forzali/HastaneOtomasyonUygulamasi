namespace Hastane_Otomasyon_Uygulaması
{
    partial class DoktorBilgileri
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DoktorBilgileri));
            this.panel3 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.txtDrSicilno = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnAra = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtGüncelMail = new System.Windows.Forms.TextBox();
            this.mskGüncelTel = new System.Windows.Forms.MaskedTextBox();
            this.comboBoxGüncelCinsiyet = new System.Windows.Forms.ComboBox();
            this.txtGüncelSoyad = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.txtGüncelAd = new System.Windows.Forms.TextBox();
            this.txtGüncelUzmanlik = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.btnDüzenle = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.btnGüncelle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.mskTel = new System.Windows.Forms.MaskedTextBox();
            this.comboBoxCinsiyet = new System.Windows.Forms.ComboBox();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtad = new System.Windows.Forms.TextBox();
            this.txtSicilno = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtUzmanlik = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.doktorListesi = new System.Windows.Forms.DataGridView();
            this.sicilNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uzmanlikAlaniDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soyadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cinsiyetDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.doktorBilgileriBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hastane_Otomasyonu_VeritabanıDataSet = new Hastane_Otomasyon_Uygulaması.Hastane_Otomasyonu_VeritabanıDataSet();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label18 = new System.Windows.Forms.Label();
            this.doktor_BilgileriTableAdapter = new Hastane_Otomasyon_Uygulaması.Hastane_Otomasyonu_VeritabanıDataSetTableAdapters.Doktor_BilgileriTableAdapter();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ipucu = new System.Windows.Forms.ToolTip(this.components);
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.doktorListesi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.doktorBilgileriBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hastane_Otomasyonu_VeritabanıDataSet)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.txtDrSicilno);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.btnAra);
            this.panel3.Location = new System.Drawing.Point(310, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(300, 132);
            this.panel3.TabIndex = 19;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(3, 54);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(144, 20);
            this.label6.TabIndex = 28;
            this.label6.Text = "Doktor Sicil Numarası :";
            // 
            // txtDrSicilno
            // 
            this.txtDrSicilno.Location = new System.Drawing.Point(150, 56);
            this.txtDrSicilno.Name = "txtDrSicilno";
            this.txtDrSicilno.Size = new System.Drawing.Size(117, 20);
            this.txtDrSicilno.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(103, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 25);
            this.label5.TabIndex = 5;
            this.label5.Text = "Doktor Ara";
            // 
            // btnAra
            // 
            this.btnAra.Location = new System.Drawing.Point(171, 92);
            this.btnAra.Name = "btnAra";
            this.btnAra.Size = new System.Drawing.Size(75, 23);
            this.btnAra.TabIndex = 10;
            this.btnAra.Text = "ARA";
            this.ipucu.SetToolTip(this.btnAra, "Doktor Sicil Numarası üzerinden arama işlemi yapar");
            this.btnAra.UseVisualStyleBackColor = true;
            this.btnAra.Click += new System.EventHandler(this.btnAra_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkOrchid;
            this.panel2.Controls.Add(this.txtGüncelMail);
            this.panel2.Controls.Add(this.mskGüncelTel);
            this.panel2.Controls.Add(this.comboBoxGüncelCinsiyet);
            this.panel2.Controls.Add(this.txtGüncelSoyad);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label14);
            this.panel2.Controls.Add(this.label15);
            this.panel2.Controls.Add(this.txtGüncelAd);
            this.panel2.Controls.Add(this.txtGüncelUzmanlik);
            this.panel2.Controls.Add(this.label16);
            this.panel2.Controls.Add(this.label17);
            this.panel2.Controls.Add(this.btnDüzenle);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.btnGüncelle);
            this.panel2.Controls.Add(this.btnSil);
            this.panel2.Location = new System.Drawing.Point(616, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(300, 315);
            this.panel2.TabIndex = 18;
            // 
            // txtGüncelMail
            // 
            this.txtGüncelMail.Location = new System.Drawing.Point(121, 206);
            this.txtGüncelMail.Name = "txtGüncelMail";
            this.txtGüncelMail.Size = new System.Drawing.Size(126, 20);
            this.txtGüncelMail.TabIndex = 16;
            // 
            // mskGüncelTel
            // 
            this.mskGüncelTel.Location = new System.Drawing.Point(121, 177);
            this.mskGüncelTel.Mask = "00000000000";
            this.mskGüncelTel.Name = "mskGüncelTel";
            this.mskGüncelTel.Size = new System.Drawing.Size(126, 20);
            this.mskGüncelTel.TabIndex = 15;
            // 
            // comboBoxGüncelCinsiyet
            // 
            this.comboBoxGüncelCinsiyet.DisplayMember = "sehir";
            this.comboBoxGüncelCinsiyet.FormattingEnabled = true;
            this.comboBoxGüncelCinsiyet.Items.AddRange(new object[] {
            "Bay",
            "Bayan"});
            this.comboBoxGüncelCinsiyet.Location = new System.Drawing.Point(121, 151);
            this.comboBoxGüncelCinsiyet.Name = "comboBoxGüncelCinsiyet";
            this.comboBoxGüncelCinsiyet.Size = new System.Drawing.Size(127, 21);
            this.comboBoxGüncelCinsiyet.TabIndex = 14;
            // 
            // txtGüncelSoyad
            // 
            this.txtGüncelSoyad.Location = new System.Drawing.Point(121, 124);
            this.txtGüncelSoyad.Name = "txtGüncelSoyad";
            this.txtGüncelSoyad.Size = new System.Drawing.Size(126, 20);
            this.txtGüncelSoyad.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(65, 204);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 20);
            this.label7.TabIndex = 35;
            this.label7.Text = "E-Mail :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(58, 175);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 20);
            this.label8.TabIndex = 34;
            this.label8.Text = "Telefon :";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label14.Location = new System.Drawing.Point(58, 151);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(64, 20);
            this.label14.TabIndex = 33;
            this.label14.Text = "Cinsiyet :";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label15.Location = new System.Drawing.Point(63, 122);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(59, 20);
            this.label15.TabIndex = 32;
            this.label15.Text = "Soyadı :";
            // 
            // txtGüncelAd
            // 
            this.txtGüncelAd.Location = new System.Drawing.Point(121, 94);
            this.txtGüncelAd.Name = "txtGüncelAd";
            this.txtGüncelAd.Size = new System.Drawing.Size(126, 20);
            this.txtGüncelAd.TabIndex = 12;
            // 
            // txtGüncelUzmanlik
            // 
            this.txtGüncelUzmanlik.Location = new System.Drawing.Point(121, 65);
            this.txtGüncelUzmanlik.Name = "txtGüncelUzmanlik";
            this.txtGüncelUzmanlik.Size = new System.Drawing.Size(126, 20);
            this.txtGüncelUzmanlik.TabIndex = 11;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label16.Location = new System.Drawing.Point(85, 92);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(37, 20);
            this.label16.TabIndex = 29;
            this.label16.Text = "Adı :";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label17.Location = new System.Drawing.Point(18, 63);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(104, 20);
            this.label17.TabIndex = 28;
            this.label17.Text = "Uzmanlık Alanı :";
            // 
            // btnDüzenle
            // 
            this.btnDüzenle.Location = new System.Drawing.Point(40, 254);
            this.btnDüzenle.Name = "btnDüzenle";
            this.btnDüzenle.Size = new System.Drawing.Size(75, 23);
            this.btnDüzenle.TabIndex = 17;
            this.btnDüzenle.Text = "Düzenle";
            this.ipucu.SetToolTip(this.btnDüzenle, "Bilgileri Düzenleyip Güncellemek için Kilitleri Açar");
            this.btnDüzenle.UseVisualStyleBackColor = true;
            this.btnDüzenle.Click += new System.EventHandler(this.btnDüzenle_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Monotype Corsiva", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(26, 13);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(251, 24);
            this.label9.TabIndex = 10;
            this.label9.Text = "Doktor Bilgileri Düzenle / Sil";
            // 
            // btnGüncelle
            // 
            this.btnGüncelle.Location = new System.Drawing.Point(121, 254);
            this.btnGüncelle.Name = "btnGüncelle";
            this.btnGüncelle.Size = new System.Drawing.Size(75, 23);
            this.btnGüncelle.TabIndex = 18;
            this.btnGüncelle.Text = "Güncelle";
            this.ipucu.SetToolTip(this.btnGüncelle, "Güncel Verileri Kaydeder");
            this.btnGüncelle.UseVisualStyleBackColor = true;
            this.btnGüncelle.Click += new System.EventHandler(this.btnGüncelle_Click);
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(202, 254);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(75, 23);
            this.btnSil.TabIndex = 19;
            this.btnSil.Text = "Sil";
            this.ipucu.SetToolTip(this.btnSil, "Doktor Bilgilerini Siler");
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel1.Controls.Add(this.txtMail);
            this.panel1.Controls.Add(this.mskTel);
            this.panel1.Controls.Add(this.comboBoxCinsiyet);
            this.panel1.Controls.Add(this.txtSoyad);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.txtad);
            this.panel1.Controls.Add(this.txtSicilno);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.btnKaydet);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtUzmanlik);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(4, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(300, 315);
            this.panel1.TabIndex = 17;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // txtMail
            // 
            this.txtMail.Location = new System.Drawing.Point(146, 223);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(126, 20);
            this.txtMail.TabIndex = 7;
            // 
            // mskTel
            // 
            this.mskTel.Location = new System.Drawing.Point(146, 194);
            this.mskTel.Mask = "00000000000";
            this.mskTel.Name = "mskTel";
            this.mskTel.Size = new System.Drawing.Size(126, 20);
            this.mskTel.TabIndex = 6;
            // 
            // comboBoxCinsiyet
            // 
            this.comboBoxCinsiyet.DisplayMember = "sehir";
            this.comboBoxCinsiyet.FormattingEnabled = true;
            this.comboBoxCinsiyet.Items.AddRange(new object[] {
            "Bay",
            "Bayan"});
            this.comboBoxCinsiyet.Location = new System.Drawing.Point(146, 168);
            this.comboBoxCinsiyet.Name = "comboBoxCinsiyet";
            this.comboBoxCinsiyet.Size = new System.Drawing.Size(127, 21);
            this.comboBoxCinsiyet.TabIndex = 5;
            // 
            // txtSoyad
            // 
            this.txtSoyad.Location = new System.Drawing.Point(146, 141);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(126, 20);
            this.txtSoyad.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(90, 221);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 20);
            this.label4.TabIndex = 15;
            this.label4.Text = "E-Mail :";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label13.Location = new System.Drawing.Point(83, 192);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(61, 20);
            this.label13.TabIndex = 11;
            this.label13.Text = "Telefon :";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label12.Location = new System.Drawing.Point(83, 168);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(64, 20);
            this.label12.TabIndex = 10;
            this.label12.Text = "Cinsiyet :";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.Location = new System.Drawing.Point(88, 139);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(59, 20);
            this.label11.TabIndex = 9;
            this.label11.Text = "Soyadı :";
            // 
            // txtad
            // 
            this.txtad.Location = new System.Drawing.Point(146, 111);
            this.txtad.Name = "txtad";
            this.txtad.Size = new System.Drawing.Size(126, 20);
            this.txtad.TabIndex = 3;
            // 
            // txtSicilno
            // 
            this.txtSicilno.Location = new System.Drawing.Point(146, 55);
            this.txtSicilno.Name = "txtSicilno";
            this.txtSicilno.Size = new System.Drawing.Size(126, 20);
            this.txtSicilno.TabIndex = 1;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(3, 52);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(144, 20);
            this.label10.TabIndex = 7;
            this.label10.Text = "Doktor Sicil Numarası :";
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(174, 254);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(75, 23);
            this.btnKaydet.TabIndex = 8;
            this.btnKaydet.Text = "Kaydet";
            this.ipucu.SetToolTip(this.btnKaydet, "Doktor Bilgilerini Kaydeder");
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.GhostWhite;
            this.label1.Location = new System.Drawing.Point(51, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(198, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Doktor Kaydı Oluştur";
            // 
            // txtUzmanlik
            // 
            this.txtUzmanlik.Location = new System.Drawing.Point(146, 82);
            this.txtUzmanlik.Name = "txtUzmanlik";
            this.txtUzmanlik.Size = new System.Drawing.Size(126, 20);
            this.txtUzmanlik.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(110, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Adı :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(43, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Uzmanlık Alanı :";
            // 
            // doktorListesi
            // 
            this.doktorListesi.AutoGenerateColumns = false;
            this.doktorListesi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.doktorListesi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.doktorListesi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sicilNoDataGridViewTextBoxColumn,
            this.uzmanlikAlaniDataGridViewTextBoxColumn,
            this.adDataGridViewTextBoxColumn,
            this.soyadDataGridViewTextBoxColumn,
            this.cinsiyetDataGridViewTextBoxColumn,
            this.telefonDataGridViewTextBoxColumn,
            this.mailDataGridViewTextBoxColumn});
            this.doktorListesi.DataSource = this.doktorBilgileriBindingSource;
            this.doktorListesi.Location = new System.Drawing.Point(4, 400);
            this.doktorListesi.Name = "doktorListesi";
            this.doktorListesi.Size = new System.Drawing.Size(911, 157);
            this.doktorListesi.TabIndex = 20;
            this.doktorListesi.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.doktorListesi_CellClick);
            // 
            // sicilNoDataGridViewTextBoxColumn
            // 
            this.sicilNoDataGridViewTextBoxColumn.DataPropertyName = "SicilNo";
            this.sicilNoDataGridViewTextBoxColumn.HeaderText = "Sicil Numarası";
            this.sicilNoDataGridViewTextBoxColumn.Name = "sicilNoDataGridViewTextBoxColumn";
            // 
            // uzmanlikAlaniDataGridViewTextBoxColumn
            // 
            this.uzmanlikAlaniDataGridViewTextBoxColumn.DataPropertyName = "Uzmanlik_Alani";
            this.uzmanlikAlaniDataGridViewTextBoxColumn.HeaderText = "Uzmanlık Alanı";
            this.uzmanlikAlaniDataGridViewTextBoxColumn.Name = "uzmanlikAlaniDataGridViewTextBoxColumn";
            // 
            // adDataGridViewTextBoxColumn
            // 
            this.adDataGridViewTextBoxColumn.DataPropertyName = "Ad";
            this.adDataGridViewTextBoxColumn.HeaderText = "Doktor Adı";
            this.adDataGridViewTextBoxColumn.Name = "adDataGridViewTextBoxColumn";
            // 
            // soyadDataGridViewTextBoxColumn
            // 
            this.soyadDataGridViewTextBoxColumn.DataPropertyName = "Soyad";
            this.soyadDataGridViewTextBoxColumn.HeaderText = "Doktor Soyadı";
            this.soyadDataGridViewTextBoxColumn.Name = "soyadDataGridViewTextBoxColumn";
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
            // mailDataGridViewTextBoxColumn
            // 
            this.mailDataGridViewTextBoxColumn.DataPropertyName = "Mail";
            this.mailDataGridViewTextBoxColumn.HeaderText = "E-Mail";
            this.mailDataGridViewTextBoxColumn.Name = "mailDataGridViewTextBoxColumn";
            // 
            // doktorBilgileriBindingSource
            // 
            this.doktorBilgileriBindingSource.DataMember = "Doktor_Bilgileri";
            this.doktorBilgileriBindingSource.DataSource = this.hastane_Otomasyonu_VeritabanıDataSet;
            // 
            // hastane_Otomasyonu_VeritabanıDataSet
            // 
            this.hastane_Otomasyonu_VeritabanıDataSet.DataSetName = "Hastane_Otomasyonu_VeritabanıDataSet";
            this.hastane_Otomasyonu_VeritabanıDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Brown;
            this.panel4.Controls.Add(this.label18);
            this.panel4.Location = new System.Drawing.Point(4, 353);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(911, 47);
            this.panel4.TabIndex = 22;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Monotype Corsiva", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label18.ForeColor = System.Drawing.Color.White;
            this.label18.Location = new System.Drawing.Point(245, 5);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(396, 39);
            this.label18.TabIndex = 6;
            this.label18.Text = "KAYITLI DOKTOR LİSTESİ";
            // 
            // doktor_BilgileriTableAdapter
            // 
            this.doktor_BilgileriTableAdapter.ClearBeforeFill = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Hastane_Otomasyon_Uygulaması.Properties.Resources._3doktor;
            this.pictureBox1.Location = new System.Drawing.Point(228, 103);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(477, 284);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            // 
            // DoktorBilgileri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(919, 569);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.doktorListesi);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "DoktorBilgileri";
            this.Text = "Doktor Bilgileri";
            this.Load += new System.EventHandler(this.DoktorBilgileri_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.doktorListesi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.doktorBilgileriBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hastane_Otomasyonu_VeritabanıDataSet)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtDrSicilno;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnAra;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnDüzenle;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnGüncelle;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtad;
        private System.Windows.Forms.TextBox txtSicilno;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtUzmanlik;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.MaskedTextBox mskTel;
        private System.Windows.Forms.ComboBox comboBoxCinsiyet;
        private System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtGüncelMail;
        private System.Windows.Forms.MaskedTextBox mskGüncelTel;
        private System.Windows.Forms.ComboBox comboBoxGüncelCinsiyet;
        private System.Windows.Forms.TextBox txtGüncelSoyad;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtGüncelAd;
        private System.Windows.Forms.TextBox txtGüncelUzmanlik;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView doktorListesi;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label18;
        private Hastane_Otomasyonu_VeritabanıDataSet hastane_Otomasyonu_VeritabanıDataSet;
        private System.Windows.Forms.BindingSource doktorBilgileriBindingSource;
        private Hastane_Otomasyonu_VeritabanıDataSetTableAdapters.Doktor_BilgileriTableAdapter doktor_BilgileriTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn sicilNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn uzmanlikAlaniDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn soyadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cinsiyetDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefonDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mailDataGridViewTextBoxColumn;
        private System.Windows.Forms.ToolTip ipucu;
    }
}