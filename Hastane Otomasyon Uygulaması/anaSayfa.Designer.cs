namespace Hastane_Otomasyon_Uygulaması
{
    partial class anaSayfa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(anaSayfa));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.hastaKayıtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hastaEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hastaKayıtListesiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hastaTeşhisBilgisiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hastaTedaviBilgisiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.doktorBilgileriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.polikliniklerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.poliklinikEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hastaneHakkındaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tarihSaat = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblHastaSayi = new System.Windows.Forms.Label();
            this.lblTedavi = new System.Windows.Forms.Label();
            this.lbldoktor = new System.Windows.Forms.Label();
            this.lblPolsay = new System.Windows.Forms.Label();
            this.lblTarih = new System.Windows.Forms.Label();
            this.lblSaat = new System.Windows.Forms.Label();
            this.lstHasta = new System.Windows.Forms.DataGridView();
            this.tcNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soyadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dogumTarihiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cinsiyetDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adresDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ilDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ilceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hastaBilgileriBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hastane_Otomasyonu_VeritabanıDataSet = new Hastane_Otomasyon_Uygulaması.Hastane_Otomasyonu_VeritabanıDataSet();
            this.hasta_BilgileriTableAdapter = new Hastane_Otomasyon_Uygulaması.Hastane_Otomasyonu_VeritabanıDataSetTableAdapters.Hasta_BilgileriTableAdapter();
            this.lstPol = new System.Windows.Forms.DataGridView();
            this.polNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.polAdıDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hizmetKapasitesiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.poliklinikBilgileriBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.poliklinik_BilgileriTableAdapter = new Hastane_Otomasyon_Uygulaması.Hastane_Otomasyonu_VeritabanıDataSetTableAdapters.Poliklinik_BilgileriTableAdapter();
            this.lstDoktor = new System.Windows.Forms.DataGridView();
            this.sicilNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uzmanlikAlaniDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soyadDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cinsiyetDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefonDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.doktorBilgileriBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.doktor_BilgileriTableAdapter = new Hastane_Otomasyon_Uygulaması.Hastane_Otomasyonu_VeritabanıDataSetTableAdapters.Doktor_BilgileriTableAdapter();
            this.tedaviBilgileriBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tedavi_BilgileriTableAdapter = new Hastane_Otomasyon_Uygulaması.Hastane_Otomasyonu_VeritabanıDataSetTableAdapters.Tedavi_BilgileriTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.tarih = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lstHasta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hastaBilgileriBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hastane_Otomasyonu_VeritabanıDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lstPol)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.poliklinikBilgileriBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lstDoktor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.doktorBilgileriBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tedaviBilgileriBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tarih)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hastaKayıtToolStripMenuItem,
            this.hastaTeşhisBilgisiToolStripMenuItem,
            this.hastaTedaviBilgisiToolStripMenuItem,
            this.doktorBilgileriToolStripMenuItem,
            this.polikliniklerToolStripMenuItem,
            this.hastaneHakkındaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(678, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // hastaKayıtToolStripMenuItem
            // 
            this.hastaKayıtToolStripMenuItem.AutoToolTip = true;
            this.hastaKayıtToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hastaEkleToolStripMenuItem,
            this.hastaKayıtListesiToolStripMenuItem});
            this.hastaKayıtToolStripMenuItem.Name = "hastaKayıtToolStripMenuItem";
            this.hastaKayıtToolStripMenuItem.Size = new System.Drawing.Size(83, 20);
            this.hastaKayıtToolStripMenuItem.Text = "Hasta Bilgisi";
            this.hastaKayıtToolStripMenuItem.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            this.hastaKayıtToolStripMenuItem.ToolTipText = "Hasta Kayıt İşlemleri Formunu Açar";
            // 
            // hastaEkleToolStripMenuItem
            // 
            this.hastaEkleToolStripMenuItem.Name = "hastaEkleToolStripMenuItem";
            this.hastaEkleToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.hastaEkleToolStripMenuItem.Text = "Hasta Kayıt Ekle";
            this.hastaEkleToolStripMenuItem.Click += new System.EventHandler(this.hastaEkleToolStripMenuItem_Click);
            // 
            // hastaKayıtListesiToolStripMenuItem
            // 
            this.hastaKayıtListesiToolStripMenuItem.Name = "hastaKayıtListesiToolStripMenuItem";
            this.hastaKayıtListesiToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.hastaKayıtListesiToolStripMenuItem.Text = "Kayıt Ara/Düzenle/Sil";
            this.hastaKayıtListesiToolStripMenuItem.Click += new System.EventHandler(this.hastaKayıtListesiToolStripMenuItem_Click);
            // 
            // hastaTeşhisBilgisiToolStripMenuItem
            // 
            this.hastaTeşhisBilgisiToolStripMenuItem.Name = "hastaTeşhisBilgisiToolStripMenuItem";
            this.hastaTeşhisBilgisiToolStripMenuItem.Size = new System.Drawing.Size(117, 20);
            this.hastaTeşhisBilgisiToolStripMenuItem.Text = "Hasta Teşhis Bilgisi";
            this.hastaTeşhisBilgisiToolStripMenuItem.ToolTipText = "Hasta Teşhis Bilgisi Girme ve Görme işlemleri";
            this.hastaTeşhisBilgisiToolStripMenuItem.Click += new System.EventHandler(this.hastaTeşhisBilgisiToolStripMenuItem_Click);
            // 
            // hastaTedaviBilgisiToolStripMenuItem
            // 
            this.hastaTedaviBilgisiToolStripMenuItem.Name = "hastaTedaviBilgisiToolStripMenuItem";
            this.hastaTedaviBilgisiToolStripMenuItem.Size = new System.Drawing.Size(119, 20);
            this.hastaTedaviBilgisiToolStripMenuItem.Text = "Hasta Tedavi Bilgisi";
            this.hastaTedaviBilgisiToolStripMenuItem.Click += new System.EventHandler(this.hastaTedaviBilgisiToolStripMenuItem_Click);
            // 
            // doktorBilgileriToolStripMenuItem
            // 
            this.doktorBilgileriToolStripMenuItem.Name = "doktorBilgileriToolStripMenuItem";
            this.doktorBilgileriToolStripMenuItem.Size = new System.Drawing.Size(97, 20);
            this.doktorBilgileriToolStripMenuItem.Text = "Doktor Bilgileri";
            this.doktorBilgileriToolStripMenuItem.Click += new System.EventHandler(this.doktorBilgileriToolStripMenuItem_Click);
            // 
            // polikliniklerToolStripMenuItem
            // 
            this.polikliniklerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.poliklinikEkleToolStripMenuItem});
            this.polikliniklerToolStripMenuItem.Name = "polikliniklerToolStripMenuItem";
            this.polikliniklerToolStripMenuItem.Size = new System.Drawing.Size(80, 20);
            this.polikliniklerToolStripMenuItem.Text = "Poliklinikler";
            // 
            // poliklinikEkleToolStripMenuItem
            // 
            this.poliklinikEkleToolStripMenuItem.Name = "poliklinikEkleToolStripMenuItem";
            this.poliklinikEkleToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.poliklinikEkleToolStripMenuItem.Text = "Oluştur/Düzenle/Sil";
            this.poliklinikEkleToolStripMenuItem.Click += new System.EventHandler(this.poliklinikEkleToolStripMenuItem_Click);
            // 
            // hastaneHakkındaToolStripMenuItem
            // 
            this.hastaneHakkındaToolStripMenuItem.Name = "hastaneHakkındaToolStripMenuItem";
            this.hastaneHakkındaToolStripMenuItem.Size = new System.Drawing.Size(115, 20);
            this.hastaneHakkındaToolStripMenuItem.Text = "Hastane Hakkında";
            this.hastaneHakkındaToolStripMenuItem.Click += new System.EventHandler(this.hastaneHakkındaToolStripMenuItem_Click);
            // 
            // tarihSaat
            // 
            this.tarihSaat.Tick += new System.EventHandler(this.tarihSaat_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(64, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Kayıtlı Hasta Sayısı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Monotype Corsiva", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(64, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Günlük Tedavi Sayısı";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(69, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 22);
            this.label3.TabIndex = 6;
            this.label3.Text = "Doktor Sayısı";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Monotype Corsiva", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(70, 227);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Poliklinik Sayısı";
            // 
            // lblHastaSayi
            // 
            this.lblHastaSayi.AutoSize = true;
            this.lblHastaSayi.BackColor = System.Drawing.Color.Transparent;
            this.lblHastaSayi.Font = new System.Drawing.Font("Monotype Corsiva", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblHastaSayi.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblHastaSayi.Location = new System.Drawing.Point(102, 36);
            this.lblHastaSayi.Name = "lblHastaSayi";
            this.lblHastaSayi.Size = new System.Drawing.Size(35, 17);
            this.lblHastaSayi.TabIndex = 8;
            this.lblHastaSayi.Text = "Sayı";
            // 
            // lblTedavi
            // 
            this.lblTedavi.AutoSize = true;
            this.lblTedavi.BackColor = System.Drawing.Color.Transparent;
            this.lblTedavi.Font = new System.Drawing.Font("Monotype Corsiva", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTedavi.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblTedavi.Location = new System.Drawing.Point(101, 111);
            this.lblTedavi.Name = "lblTedavi";
            this.lblTedavi.Size = new System.Drawing.Size(35, 17);
            this.lblTedavi.TabIndex = 9;
            this.lblTedavi.Text = "Sayı";
            // 
            // lbldoktor
            // 
            this.lbldoktor.AutoSize = true;
            this.lbldoktor.BackColor = System.Drawing.Color.Transparent;
            this.lbldoktor.Font = new System.Drawing.Font("Monotype Corsiva", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbldoktor.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbldoktor.Location = new System.Drawing.Point(100, 184);
            this.lbldoktor.Name = "lbldoktor";
            this.lbldoktor.Size = new System.Drawing.Size(35, 17);
            this.lbldoktor.TabIndex = 10;
            this.lbldoktor.Text = "Sayı";
            // 
            // lblPolsay
            // 
            this.lblPolsay.AutoSize = true;
            this.lblPolsay.BackColor = System.Drawing.Color.Transparent;
            this.lblPolsay.Font = new System.Drawing.Font("Monotype Corsiva", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPolsay.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblPolsay.Location = new System.Drawing.Point(98, 257);
            this.lblPolsay.Name = "lblPolsay";
            this.lblPolsay.Size = new System.Drawing.Size(35, 17);
            this.lblPolsay.TabIndex = 11;
            this.lblPolsay.Text = "Sayı";
            // 
            // lblTarih
            // 
            this.lblTarih.AutoSize = true;
            this.lblTarih.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTarih.Location = new System.Drawing.Point(440, 127);
            this.lblTarih.Name = "lblTarih";
            this.lblTarih.Size = new System.Drawing.Size(47, 19);
            this.lblTarih.TabIndex = 13;
            this.lblTarih.Text = "Tarih";
            // 
            // lblSaat
            // 
            this.lblSaat.AutoSize = true;
            this.lblSaat.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSaat.Location = new System.Drawing.Point(489, 155);
            this.lblSaat.Name = "lblSaat";
            this.lblSaat.Size = new System.Drawing.Size(41, 19);
            this.lblSaat.TabIndex = 14;
            this.lblSaat.Text = "Saat";
            // 
            // lstHasta
            // 
            this.lstHasta.AutoGenerateColumns = false;
            this.lstHasta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.lstHasta.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tcNoDataGridViewTextBoxColumn,
            this.adDataGridViewTextBoxColumn,
            this.soyadDataGridViewTextBoxColumn,
            this.dogumTarihiDataGridViewTextBoxColumn,
            this.cinsiyetDataGridViewTextBoxColumn,
            this.telefonDataGridViewTextBoxColumn,
            this.adresDataGridViewTextBoxColumn,
            this.ilDataGridViewTextBoxColumn,
            this.ilceDataGridViewTextBoxColumn});
            this.lstHasta.DataSource = this.hastaBilgileriBindingSource;
            this.lstHasta.Location = new System.Drawing.Point(372, 292);
            this.lstHasta.Name = "lstHasta";
            this.lstHasta.Size = new System.Drawing.Size(31, 19);
            this.lstHasta.TabIndex = 16;
            this.lstHasta.Visible = false;
            // 
            // tcNoDataGridViewTextBoxColumn
            // 
            this.tcNoDataGridViewTextBoxColumn.DataPropertyName = "Tc_No";
            this.tcNoDataGridViewTextBoxColumn.HeaderText = "Tc_No";
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
            this.dogumTarihiDataGridViewTextBoxColumn.HeaderText = "Dogum_Tarihi";
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
            this.ilceDataGridViewTextBoxColumn.HeaderText = "ilce";
            this.ilceDataGridViewTextBoxColumn.Name = "ilceDataGridViewTextBoxColumn";
            // 
            // hastaBilgileriBindingSource
            // 
            this.hastaBilgileriBindingSource.DataMember = "Hasta_Bilgileri";
            this.hastaBilgileriBindingSource.DataSource = this.hastane_Otomasyonu_VeritabanıDataSet;
            // 
            // hastane_Otomasyonu_VeritabanıDataSet
            // 
            this.hastane_Otomasyonu_VeritabanıDataSet.DataSetName = "Hastane_Otomasyonu_VeritabanıDataSet";
            this.hastane_Otomasyonu_VeritabanıDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // hasta_BilgileriTableAdapter
            // 
            this.hasta_BilgileriTableAdapter.ClearBeforeFill = true;
            // 
            // lstPol
            // 
            this.lstPol.AutoGenerateColumns = false;
            this.lstPol.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.lstPol.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.polNoDataGridViewTextBoxColumn,
            this.polAdıDataGridViewTextBoxColumn,
            this.hizmetKapasitesiDataGridViewTextBoxColumn});
            this.lstPol.DataSource = this.poliklinikBilgileriBindingSource;
            this.lstPol.Location = new System.Drawing.Point(408, 292);
            this.lstPol.Name = "lstPol";
            this.lstPol.Size = new System.Drawing.Size(34, 19);
            this.lstPol.TabIndex = 17;
            this.lstPol.Visible = false;
            // 
            // polNoDataGridViewTextBoxColumn
            // 
            this.polNoDataGridViewTextBoxColumn.DataPropertyName = "Pol_No";
            this.polNoDataGridViewTextBoxColumn.HeaderText = "Pol_No";
            this.polNoDataGridViewTextBoxColumn.Name = "polNoDataGridViewTextBoxColumn";
            this.polNoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // polAdıDataGridViewTextBoxColumn
            // 
            this.polAdıDataGridViewTextBoxColumn.DataPropertyName = "Pol_Adı";
            this.polAdıDataGridViewTextBoxColumn.HeaderText = "Pol_Adı";
            this.polAdıDataGridViewTextBoxColumn.Name = "polAdıDataGridViewTextBoxColumn";
            // 
            // hizmetKapasitesiDataGridViewTextBoxColumn
            // 
            this.hizmetKapasitesiDataGridViewTextBoxColumn.DataPropertyName = "Hizmet_Kapasitesi";
            this.hizmetKapasitesiDataGridViewTextBoxColumn.HeaderText = "Hizmet_Kapasitesi";
            this.hizmetKapasitesiDataGridViewTextBoxColumn.Name = "hizmetKapasitesiDataGridViewTextBoxColumn";
            // 
            // poliklinikBilgileriBindingSource
            // 
            this.poliklinikBilgileriBindingSource.DataMember = "Poliklinik_Bilgileri";
            this.poliklinikBilgileriBindingSource.DataSource = this.hastane_Otomasyonu_VeritabanıDataSet;
            // 
            // poliklinik_BilgileriTableAdapter
            // 
            this.poliklinik_BilgileriTableAdapter.ClearBeforeFill = true;
            // 
            // lstDoktor
            // 
            this.lstDoktor.AutoGenerateColumns = false;
            this.lstDoktor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.lstDoktor.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sicilNoDataGridViewTextBoxColumn,
            this.uzmanlikAlaniDataGridViewTextBoxColumn,
            this.adDataGridViewTextBoxColumn1,
            this.soyadDataGridViewTextBoxColumn1,
            this.cinsiyetDataGridViewTextBoxColumn1,
            this.telefonDataGridViewTextBoxColumn1,
            this.mailDataGridViewTextBoxColumn});
            this.lstDoktor.DataSource = this.doktorBilgileriBindingSource;
            this.lstDoktor.Location = new System.Drawing.Point(448, 292);
            this.lstDoktor.Name = "lstDoktor";
            this.lstDoktor.Size = new System.Drawing.Size(39, 19);
            this.lstDoktor.TabIndex = 18;
            this.lstDoktor.Visible = false;
            // 
            // sicilNoDataGridViewTextBoxColumn
            // 
            this.sicilNoDataGridViewTextBoxColumn.DataPropertyName = "SicilNo";
            this.sicilNoDataGridViewTextBoxColumn.HeaderText = "SicilNo";
            this.sicilNoDataGridViewTextBoxColumn.Name = "sicilNoDataGridViewTextBoxColumn";
            // 
            // uzmanlikAlaniDataGridViewTextBoxColumn
            // 
            this.uzmanlikAlaniDataGridViewTextBoxColumn.DataPropertyName = "Uzmanlik_Alani";
            this.uzmanlikAlaniDataGridViewTextBoxColumn.HeaderText = "Uzmanlik_Alani";
            this.uzmanlikAlaniDataGridViewTextBoxColumn.Name = "uzmanlikAlaniDataGridViewTextBoxColumn";
            // 
            // adDataGridViewTextBoxColumn1
            // 
            this.adDataGridViewTextBoxColumn1.DataPropertyName = "Ad";
            this.adDataGridViewTextBoxColumn1.HeaderText = "Ad";
            this.adDataGridViewTextBoxColumn1.Name = "adDataGridViewTextBoxColumn1";
            // 
            // soyadDataGridViewTextBoxColumn1
            // 
            this.soyadDataGridViewTextBoxColumn1.DataPropertyName = "Soyad";
            this.soyadDataGridViewTextBoxColumn1.HeaderText = "Soyad";
            this.soyadDataGridViewTextBoxColumn1.Name = "soyadDataGridViewTextBoxColumn1";
            // 
            // cinsiyetDataGridViewTextBoxColumn1
            // 
            this.cinsiyetDataGridViewTextBoxColumn1.DataPropertyName = "Cinsiyet";
            this.cinsiyetDataGridViewTextBoxColumn1.HeaderText = "Cinsiyet";
            this.cinsiyetDataGridViewTextBoxColumn1.Name = "cinsiyetDataGridViewTextBoxColumn1";
            // 
            // telefonDataGridViewTextBoxColumn1
            // 
            this.telefonDataGridViewTextBoxColumn1.DataPropertyName = "Telefon";
            this.telefonDataGridViewTextBoxColumn1.HeaderText = "Telefon";
            this.telefonDataGridViewTextBoxColumn1.Name = "telefonDataGridViewTextBoxColumn1";
            // 
            // mailDataGridViewTextBoxColumn
            // 
            this.mailDataGridViewTextBoxColumn.DataPropertyName = "Mail";
            this.mailDataGridViewTextBoxColumn.HeaderText = "Mail";
            this.mailDataGridViewTextBoxColumn.Name = "mailDataGridViewTextBoxColumn";
            // 
            // doktorBilgileriBindingSource
            // 
            this.doktorBilgileriBindingSource.DataMember = "Doktor_Bilgileri";
            this.doktorBilgileriBindingSource.DataSource = this.hastane_Otomasyonu_VeritabanıDataSet;
            // 
            // doktor_BilgileriTableAdapter
            // 
            this.doktor_BilgileriTableAdapter.ClearBeforeFill = true;
            // 
            // tedaviBilgileriBindingSource
            // 
            this.tedaviBilgileriBindingSource.DataMember = "Tedavi_Bilgileri";
            this.tedaviBilgileriBindingSource.DataSource = this.hastane_Otomasyonu_VeritabanıDataSet;
            // 
            // tedavi_BilgileriTableAdapter
            // 
            this.tedavi_BilgileriTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(493, 292);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(37, 19);
            this.dataGridView1.TabIndex = 20;
            this.dataGridView1.Visible = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Hastane_Otomasyon_Uygulaması.Properties.Resources.pngguru_com;
            this.pictureBox3.Location = new System.Drawing.Point(371, 291);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(311, 188);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 15;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Hastane_Otomasyon_Uygulaması.Properties.Resources.ppngguru_com;
            this.pictureBox2.Location = new System.Drawing.Point(0, 24);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(371, 456);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // tarih
            // 
            this.tarih.BackColor = System.Drawing.Color.Transparent;
            this.tarih.Image = global::Hastane_Otomasyon_Uygulaması.Properties.Resources.pngguru_com__8_;
            this.tarih.Location = new System.Drawing.Point(367, 24);
            this.tarih.Name = "tarih";
            this.tarih.Size = new System.Drawing.Size(311, 275);
            this.tarih.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.tarih.TabIndex = 12;
            this.tarih.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::Hastane_Otomasyon_Uygulaması.Properties.Resources.e__4____Kopya;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.lblHastaSayi);
            this.panel1.Controls.Add(this.lblTedavi);
            this.panel1.Controls.Add(this.lbldoktor);
            this.panel1.Controls.Add(this.lblPolsay);
            this.panel1.Location = new System.Drawing.Point(160, 71);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(211, 287);
            this.panel1.TabIndex = 21;
            // 
            // anaSayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(678, 479);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lstDoktor);
            this.Controls.Add(this.lstPol);
            this.Controls.Add(this.lstHasta);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.lblSaat);
            this.Controls.Add(this.lblTarih);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.tarih);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "anaSayfa";
            this.Text = "Hastane Otomasyon Uygulaması";
            this.Load += new System.EventHandler(this.anaSayfa_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lstHasta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hastaBilgileriBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hastane_Otomasyonu_VeritabanıDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lstPol)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.poliklinikBilgileriBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lstDoktor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.doktorBilgileriBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tedaviBilgileriBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tarih)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem hastaKayıtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem doktorBilgileriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hastaTeşhisBilgisiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hastaTedaviBilgisiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hastaneHakkındaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem polikliniklerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hastaEkleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hastaKayıtListesiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem poliklinikEkleToolStripMenuItem;
        private System.Windows.Forms.Timer tarihSaat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox tarih;
        private System.Windows.Forms.Label lblTarih;
        private System.Windows.Forms.Label lblSaat;
        private Hastane_Otomasyonu_VeritabanıDataSet hastane_Otomasyonu_VeritabanıDataSet;
        private System.Windows.Forms.BindingSource hastaBilgileriBindingSource;
        private Hastane_Otomasyonu_VeritabanıDataSetTableAdapters.Hasta_BilgileriTableAdapter hasta_BilgileriTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn tcNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn soyadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dogumTarihiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cinsiyetDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefonDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adresDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ilDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ilceDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource poliklinikBilgileriBindingSource;
        private Hastane_Otomasyonu_VeritabanıDataSetTableAdapters.Poliklinik_BilgileriTableAdapter poliklinik_BilgileriTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn polNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn polAdıDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hizmetKapasitesiDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource doktorBilgileriBindingSource;
        private Hastane_Otomasyonu_VeritabanıDataSetTableAdapters.Doktor_BilgileriTableAdapter doktor_BilgileriTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn sicilNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn uzmanlikAlaniDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn soyadDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn cinsiyetDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefonDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn mailDataGridViewTextBoxColumn;
        public System.Windows.Forms.PictureBox pictureBox3;
        public System.Windows.Forms.DataGridView lstHasta;
        public System.Windows.Forms.DataGridView lstDoktor;
        public System.Windows.Forms.PictureBox pictureBox2;
        public System.Windows.Forms.Label lblHastaSayi;
        public System.Windows.Forms.Label lblTedavi;
        public System.Windows.Forms.Label lbldoktor;
        public System.Windows.Forms.Label lblPolsay;
        public System.Windows.Forms.DataGridView lstPol;
        private System.Windows.Forms.BindingSource tedaviBilgileriBindingSource;
        private Hastane_Otomasyonu_VeritabanıDataSetTableAdapters.Tedavi_BilgileriTableAdapter tedavi_BilgileriTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel1;
    }
}

