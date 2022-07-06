namespace Hastane_Otomasyon_Uygulaması
{
    partial class teshisBilgileri
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(teshisBilgileri));
            this.poliklinikBilgileriBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.hastane_Otomasyonu_VeritabanıDataSet = new Hastane_Otomasyon_Uygulaması.Hastane_Otomasyonu_VeritabanıDataSet();
            this.poliklinikBilgileriBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.poliklinik_BilgileriTableAdapter = new Hastane_Otomasyon_Uygulaması.Hastane_Otomasyonu_VeritabanıDataSetTableAdapters.Poliklinik_BilgileriTableAdapter();
            this.fKTeshisBilgileriPoliklinikBilgileriBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel4 = new System.Windows.Forms.Panel();
            this.label18 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtGüncelTeshis = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnDüzenle = new System.Windows.Forms.Button();
            this.dtpGüncelTarih = new System.Windows.Forms.DateTimePicker();
            this.btnGüncelle = new System.Windows.Forms.Button();
            this.mskGüncelTc = new System.Windows.Forms.MaskedTextBox();
            this.btnSil = new System.Windows.Forms.Button();
            this.comboBoxGüncelPolno = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnAra = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dtpTarih = new System.Windows.Forms.DateTimePicker();
            this.mskTc = new System.Windows.Forms.MaskedTextBox();
            this.comboBoxPolno = new System.Windows.Forms.ComboBox();
            this.txtTeshis = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.teshisListesi = new System.Windows.Forms.DataGridView();
            this.polNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.htcNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.teshisTarihiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.teshisDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.teshisBilgileriBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.teshis_BilgileriTableAdapter = new Hastane_Otomasyon_Uygulaması.Hastane_Otomasyonu_VeritabanıDataSetTableAdapters.Teshis_BilgileriTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.poliklinikBilgileriBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hastane_Otomasyonu_VeritabanıDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.poliklinikBilgileriBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKTeshisBilgileriPoliklinikBilgileriBindingSource)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.teshisListesi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teshisBilgileriBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // poliklinikBilgileriBindingSource1
            // 
            this.poliklinikBilgileriBindingSource1.DataMember = "Poliklinik_Bilgileri";
            this.poliklinikBilgileriBindingSource1.DataSource = this.hastane_Otomasyonu_VeritabanıDataSet;
            // 
            // hastane_Otomasyonu_VeritabanıDataSet
            // 
            this.hastane_Otomasyonu_VeritabanıDataSet.DataSetName = "Hastane_Otomasyonu_VeritabanıDataSet";
            this.hastane_Otomasyonu_VeritabanıDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // fKTeshisBilgileriPoliklinikBilgileriBindingSource
            // 
            this.fKTeshisBilgileriPoliklinikBilgileriBindingSource.DataMember = "FK_Teshis_Bilgileri_Poliklinik_Bilgileri";
            this.fKTeshisBilgileriPoliklinikBilgileriBindingSource.DataSource = this.poliklinikBilgileriBindingSource;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Orange;
            this.panel4.Controls.Add(this.label18);
            this.panel4.Location = new System.Drawing.Point(7, 283);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(608, 47);
            this.panel4.TabIndex = 28;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Monotype Corsiva", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label18.ForeColor = System.Drawing.Color.White;
            this.label18.Location = new System.Drawing.Point(160, 3);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(297, 39);
            this.label18.TabIndex = 6;
            this.label18.Text = "TEŞHİS KAYITLARI";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel3.Controls.Add(this.txtGüncelTeshis);
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
            this.panel3.Location = new System.Drawing.Point(313, 7);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(302, 259);
            this.panel3.TabIndex = 25;
            // 
            // txtGüncelTeshis
            // 
            this.txtGüncelTeshis.BackColor = System.Drawing.Color.Bisque;
            this.txtGüncelTeshis.Location = new System.Drawing.Point(132, 174);
            this.txtGüncelTeshis.Multiline = true;
            this.txtGüncelTeshis.Name = "txtGüncelTeshis";
            this.txtGüncelTeshis.Size = new System.Drawing.Size(126, 47);
            this.txtGüncelTeshis.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(73, 172);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 20);
            this.label7.TabIndex = 21;
            this.label7.Text = "Teşhis :";
            // 
            // btnDüzenle
            // 
            this.btnDüzenle.Location = new System.Drawing.Point(37, 227);
            this.btnDüzenle.Name = "btnDüzenle";
            this.btnDüzenle.Size = new System.Drawing.Size(75, 23);
            this.btnDüzenle.TabIndex = 11;
            this.btnDüzenle.Text = "Düzenle";
            this.btnDüzenle.UseVisualStyleBackColor = true;
            this.btnDüzenle.Click += new System.EventHandler(this.btnDüzenle_Click_1);
            // 
            // dtpGüncelTarih
            // 
            this.dtpGüncelTarih.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpGüncelTarih.Location = new System.Drawing.Point(132, 84);
            this.dtpGüncelTarih.Name = "dtpGüncelTarih";
            this.dtpGüncelTarih.Size = new System.Drawing.Size(126, 20);
            this.dtpGüncelTarih.TabIndex = 7;
            // 
            // btnGüncelle
            // 
            this.btnGüncelle.Location = new System.Drawing.Point(118, 227);
            this.btnGüncelle.Name = "btnGüncelle";
            this.btnGüncelle.Size = new System.Drawing.Size(75, 23);
            this.btnGüncelle.TabIndex = 12;
            this.btnGüncelle.Text = "Güncelle";
            this.btnGüncelle.UseVisualStyleBackColor = true;
            this.btnGüncelle.Click += new System.EventHandler(this.btnGüncelle_Click_1);
            // 
            // mskGüncelTc
            // 
            this.mskGüncelTc.Location = new System.Drawing.Point(132, 58);
            this.mskGüncelTc.Mask = "00000000000";
            this.mskGüncelTc.Name = "mskGüncelTc";
            this.mskGüncelTc.Size = new System.Drawing.Size(126, 20);
            this.mskGüncelTc.TabIndex = 6;
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(199, 227);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(75, 23);
            this.btnSil.TabIndex = 13;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click_1);
            // 
            // comboBoxGüncelPolno
            // 
            this.comboBoxGüncelPolno.BackColor = System.Drawing.Color.Bisque;
            this.comboBoxGüncelPolno.DataSource = this.poliklinikBilgileriBindingSource;
            this.comboBoxGüncelPolno.DisplayMember = "Pol_No";
            this.comboBoxGüncelPolno.FormattingEnabled = true;
            this.comboBoxGüncelPolno.Location = new System.Drawing.Point(132, 147);
            this.comboBoxGüncelPolno.Name = "comboBoxGüncelPolno";
            this.comboBoxGüncelPolno.Size = new System.Drawing.Size(126, 21);
            this.comboBoxGüncelPolno.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(4, 145);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(129, 20);
            this.label4.TabIndex = 15;
            this.label4.Text = "Poliklinik Numarası :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(41, 83);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 20);
            this.label6.TabIndex = 14;
            this.label6.Text = "Teşhis Tarihi :";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label12.Location = new System.Drawing.Point(33, 56);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(99, 20);
            this.label12.TabIndex = 13;
            this.label12.Text = "Hasta T.C. No :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(3, 10);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(290, 25);
            this.label5.TabIndex = 5;
            this.label5.Text = "Teşhis Kaydı Ara / Düzenle / Sil";
            // 
            // btnAra
            // 
            this.btnAra.Location = new System.Drawing.Point(157, 111);
            this.btnAra.Name = "btnAra";
            this.btnAra.Size = new System.Drawing.Size(75, 23);
            this.btnAra.TabIndex = 8;
            this.btnAra.Text = "ARA";
            this.btnAra.UseVisualStyleBackColor = true;
            this.btnAra.Click += new System.EventHandler(this.btnAra_Click_1);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.panel1.Controls.Add(this.dtpTarih);
            this.panel1.Controls.Add(this.mskTc);
            this.panel1.Controls.Add(this.comboBoxPolno);
            this.panel1.Controls.Add(this.txtTeshis);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.btnKaydet);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(7, 7);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(300, 259);
            this.panel1.TabIndex = 23;
            // 
            // dtpTarih
            // 
            this.dtpTarih.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpTarih.Location = new System.Drawing.Point(146, 110);
            this.dtpTarih.Name = "dtpTarih";
            this.dtpTarih.Size = new System.Drawing.Size(126, 20);
            this.dtpTarih.TabIndex = 3;
            // 
            // mskTc
            // 
            this.mskTc.Location = new System.Drawing.Point(146, 84);
            this.mskTc.Mask = "00000000000";
            this.mskTc.Name = "mskTc";
            this.mskTc.Size = new System.Drawing.Size(126, 20);
            this.mskTc.TabIndex = 2;
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
            // txtTeshis
            // 
            this.txtTeshis.Location = new System.Drawing.Point(146, 139);
            this.txtTeshis.Multiline = true;
            this.txtTeshis.Name = "txtTeshis";
            this.txtTeshis.Size = new System.Drawing.Size(126, 64);
            this.txtTeshis.TabIndex = 4;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.Location = new System.Drawing.Point(89, 139);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(56, 20);
            this.label11.TabIndex = 9;
            this.label11.Text = "Teşhis :";
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
            this.btnKaydet.Location = new System.Drawing.Point(167, 221);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(75, 23);
            this.btnKaydet.TabIndex = 5;
            this.btnKaydet.Text = "Kaydet";
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
            this.label1.Size = new System.Drawing.Size(191, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Teşhis Kaydı Oluştur";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(55, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Teşhis Tarihi :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(47, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Hasta T.C. No :";
            // 
            // teshisListesi
            // 
            this.teshisListesi.AutoGenerateColumns = false;
            this.teshisListesi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.teshisListesi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.teshisListesi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.polNoDataGridViewTextBoxColumn,
            this.htcNoDataGridViewTextBoxColumn,
            this.teshisTarihiDataGridViewTextBoxColumn,
            this.teshisDataGridViewTextBoxColumn});
            this.teshisListesi.DataSource = this.teshisBilgileriBindingSource;
            this.teshisListesi.Location = new System.Drawing.Point(7, 330);
            this.teshisListesi.Name = "teshisListesi";
            this.teshisListesi.Size = new System.Drawing.Size(608, 150);
            this.teshisListesi.TabIndex = 29;
            this.teshisListesi.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.teshisListesi_CellClick);
            // 
            // polNoDataGridViewTextBoxColumn
            // 
            this.polNoDataGridViewTextBoxColumn.DataPropertyName = "Pol_No";
            this.polNoDataGridViewTextBoxColumn.HeaderText = "Poliklinik Numarası";
            this.polNoDataGridViewTextBoxColumn.Name = "polNoDataGridViewTextBoxColumn";
            // 
            // htcNoDataGridViewTextBoxColumn
            // 
            this.htcNoDataGridViewTextBoxColumn.DataPropertyName = "H_tcNo";
            this.htcNoDataGridViewTextBoxColumn.HeaderText = "Hasta T.C. Numarası";
            this.htcNoDataGridViewTextBoxColumn.Name = "htcNoDataGridViewTextBoxColumn";
            // 
            // teshisTarihiDataGridViewTextBoxColumn
            // 
            this.teshisTarihiDataGridViewTextBoxColumn.DataPropertyName = "Teshis_Tarihi";
            this.teshisTarihiDataGridViewTextBoxColumn.HeaderText = "Teşhis Tarihi";
            this.teshisTarihiDataGridViewTextBoxColumn.Name = "teshisTarihiDataGridViewTextBoxColumn";
            // 
            // teshisDataGridViewTextBoxColumn
            // 
            this.teshisDataGridViewTextBoxColumn.DataPropertyName = "Teshis";
            this.teshisDataGridViewTextBoxColumn.HeaderText = "Teşhis";
            this.teshisDataGridViewTextBoxColumn.Name = "teshisDataGridViewTextBoxColumn";
            // 
            // teshisBilgileriBindingSource
            // 
            this.teshisBilgileriBindingSource.DataMember = "Teshis_Bilgileri";
            this.teshisBilgileriBindingSource.DataSource = this.hastane_Otomasyonu_VeritabanıDataSet;
            // 
            // teshis_BilgileriTableAdapter
            // 
            this.teshis_BilgileriTableAdapter.ClearBeforeFill = true;
            // 
            // teshisBilgileri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(623, 492);
            this.Controls.Add(this.teshisListesi);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "teshisBilgileri";
            this.Text = "Hasta Teşhis Bilgisi Ekleme/Arama/Güncelleme/Silme";
            this.Load += new System.EventHandler(this.teshisBilgileri_Load);
            ((System.ComponentModel.ISupportInitialize)(this.poliklinikBilgileriBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hastane_Otomasyonu_VeritabanıDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.poliklinikBilgileriBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKTeshisBilgileriPoliklinikBilgileriBindingSource)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.teshisListesi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teshisBilgileriBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Hastane_Otomasyonu_VeritabanıDataSet hastane_Otomasyonu_VeritabanıDataSet;
        private System.Windows.Forms.BindingSource poliklinikBilgileriBindingSource;
        private Hastane_Otomasyonu_VeritabanıDataSetTableAdapters.Poliklinik_BilgileriTableAdapter poliklinik_BilgileriTableAdapter;
        private System.Windows.Forms.BindingSource fKTeshisBilgileriPoliklinikBilgileriBindingSource;
        private System.Windows.Forms.BindingSource poliklinikBilgileriBindingSource1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnAra;
        private System.Windows.Forms.Button btnDüzenle;
        private System.Windows.Forms.Button btnGüncelle;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtTeshis;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtGüncelTeshis;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dtpGüncelTarih;
        private System.Windows.Forms.MaskedTextBox mskGüncelTc;
        private System.Windows.Forms.ComboBox comboBoxGüncelPolno;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DateTimePicker dtpTarih;
        private System.Windows.Forms.MaskedTextBox mskTc;
        private System.Windows.Forms.ComboBox comboBoxPolno;
        private System.Windows.Forms.DataGridView teshisListesi;
        private System.Windows.Forms.BindingSource teshisBilgileriBindingSource;
        private Hastane_Otomasyonu_VeritabanıDataSetTableAdapters.Teshis_BilgileriTableAdapter teshis_BilgileriTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn polNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn htcNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn teshisTarihiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn teshisDataGridViewTextBoxColumn;
    }
}