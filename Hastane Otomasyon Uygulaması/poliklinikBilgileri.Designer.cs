namespace Hastane_Otomasyon_Uygulaması
{
    partial class poliklinikBilgileri
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(poliklinikBilgileri));
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.polKapasitesi = new System.Windows.Forms.NumericUpDown();
            this.txtPolNoKayit = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.txtPolAdi = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.polNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.polAdıDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hizmetKapasitesiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.poliklinikBilgileriBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hastane_Otomasyonu_VeritabanıDataSet = new Hastane_Otomasyon_Uygulaması.Hastane_Otomasyonu_VeritabanıDataSet();
            this.label4 = new System.Windows.Forms.Label();
            this.poliklinik_BilgileriTableAdapter = new Hastane_Otomasyon_Uygulaması.Hastane_Otomasyonu_VeritabanıDataSetTableAdapters.Poliklinik_BilgileriTableAdapter();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnDüzenle = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.btnGüncelle = new System.Windows.Forms.Button();
            this.kapasiteDüzenle = new System.Windows.Forms.NumericUpDown();
            this.txtGüncelad = new System.Windows.Forms.TextBox();
            this.btnSil = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPolNo = new System.Windows.Forms.TextBox();
            this.btnAra = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.İpucu = new System.Windows.Forms.ToolTip(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.polKapasitesi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.poliklinikBilgileriBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hastane_Otomasyonu_VeritabanıDataSet)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kapasiteDüzenle)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label1.Location = new System.Drawing.Point(40, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(242, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "POLİKLİNİK OLUŞTUR";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.panel1.Controls.Add(this.polKapasitesi);
            this.panel1.Controls.Add(this.txtPolNoKayit);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.btnKaydet);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtPolAdi);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(300, 205);
            this.panel1.TabIndex = 1;
            // 
            // polKapasitesi
            // 
            this.polKapasitesi.Location = new System.Drawing.Point(141, 118);
            this.polKapasitesi.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.polKapasitesi.Name = "polKapasitesi";
            this.polKapasitesi.Size = new System.Drawing.Size(126, 20);
            this.polKapasitesi.TabIndex = 3;
            // 
            // txtPolNoKayit
            // 
            this.txtPolNoKayit.Location = new System.Drawing.Point(141, 61);
            this.txtPolNoKayit.Name = "txtPolNoKayit";
            this.txtPolNoKayit.Size = new System.Drawing.Size(126, 20);
            this.txtPolNoKayit.TabIndex = 1;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(2, 59);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(133, 20);
            this.label10.TabIndex = 7;
            this.label10.Text = "Poliklinik Numarası  :";
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(162, 157);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(75, 23);
            this.btnKaydet.TabIndex = 4;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // txtPolAdi
            // 
            this.txtPolAdi.Location = new System.Drawing.Point(141, 88);
            this.txtPolAdi.Name = "txtPolAdi";
            this.txtPolAdi.Size = new System.Drawing.Size(126, 20);
            this.txtPolAdi.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(11, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Hizmet Kapasitesi :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(41, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Poliklinik Adı :";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.polNoDataGridViewTextBoxColumn,
            this.polAdıDataGridViewTextBoxColumn,
            this.hizmetKapasitesiDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.poliklinikBilgileriBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(344, 41);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(375, 539);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // polNoDataGridViewTextBoxColumn
            // 
            this.polNoDataGridViewTextBoxColumn.DataPropertyName = "Pol_No";
            this.polNoDataGridViewTextBoxColumn.HeaderText = "Poliklinik No";
            this.polNoDataGridViewTextBoxColumn.Name = "polNoDataGridViewTextBoxColumn";
            this.polNoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // polAdıDataGridViewTextBoxColumn
            // 
            this.polAdıDataGridViewTextBoxColumn.DataPropertyName = "Pol_Adı";
            this.polAdıDataGridViewTextBoxColumn.HeaderText = "Poliklinik Adı";
            this.polAdıDataGridViewTextBoxColumn.Name = "polAdıDataGridViewTextBoxColumn";
            // 
            // hizmetKapasitesiDataGridViewTextBoxColumn
            // 
            this.hizmetKapasitesiDataGridViewTextBoxColumn.DataPropertyName = "Hizmet_Kapasitesi";
            this.hizmetKapasitesiDataGridViewTextBoxColumn.FillWeight = 110F;
            this.hizmetKapasitesiDataGridViewTextBoxColumn.HeaderText = "Hizmet Kapasitesi";
            this.hizmetKapasitesiDataGridViewTextBoxColumn.Name = "hizmetKapasitesiDataGridViewTextBoxColumn";
            // 
            // poliklinikBilgileriBindingSource
            // 
            this.poliklinikBilgileriBindingSource.DataMember = "Poliklinik_Bilgileri";
            this.poliklinikBilgileriBindingSource.DataSource = this.hastane_Otomasyonu_VeritabanıDataSet;
            // 
            // hastane_Otomasyonu_VeritabanıDataSet
            // 
            this.hastane_Otomasyonu_VeritabanıDataSet.DataSetName = "Hastane_Otomasyonu_VeritabanıDataSet";
            this.hastane_Otomasyonu_VeritabanıDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.FloralWhite;
            this.label4.Location = new System.Drawing.Point(60, 5);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(223, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "POLİKLİNİK LİSTESİ";
            // 
            // poliklinik_BilgileriTableAdapter
            // 
            this.poliklinik_BilgileriTableAdapter.ClearBeforeFill = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.panel2.Controls.Add(this.btnDüzenle);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.btnGüncelle);
            this.panel2.Controls.Add(this.kapasiteDüzenle);
            this.panel2.Controls.Add(this.txtGüncelad);
            this.panel2.Controls.Add(this.btnSil);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Location = new System.Drawing.Point(12, 416);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(300, 164);
            this.panel2.TabIndex = 4;
            // 
            // btnDüzenle
            // 
            this.btnDüzenle.Location = new System.Drawing.Point(30, 125);
            this.btnDüzenle.Name = "btnDüzenle";
            this.btnDüzenle.Size = new System.Drawing.Size(75, 23);
            this.btnDüzenle.TabIndex = 9;
            this.btnDüzenle.Text = "Düzenle";
            this.İpucu.SetToolTip(this.btnDüzenle, "Düzenlemek İçin Kilitleri Açar");
            this.btnDüzenle.UseVisualStyleBackColor = true;
            this.btnDüzenle.Click += new System.EventHandler(this.btnDüzenle_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Monotype Corsiva", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label9.Location = new System.Drawing.Point(13, 14);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(284, 24);
            this.label9.TabIndex = 10;
            this.label9.Text = "POLİKLİNİK DÜZENLE / SİL";
            // 
            // btnGüncelle
            // 
            this.btnGüncelle.Location = new System.Drawing.Point(111, 125);
            this.btnGüncelle.Name = "btnGüncelle";
            this.btnGüncelle.Size = new System.Drawing.Size(75, 23);
            this.btnGüncelle.TabIndex = 10;
            this.btnGüncelle.Text = "Güncelle";
            this.İpucu.SetToolTip(this.btnGüncelle, "Düzenlenmiş Verileri Kaydeder");
            this.btnGüncelle.UseVisualStyleBackColor = true;
            this.btnGüncelle.Click += new System.EventHandler(this.btnGüncelle_Click);
            // 
            // kapasiteDüzenle
            // 
            this.kapasiteDüzenle.Location = new System.Drawing.Point(150, 81);
            this.kapasiteDüzenle.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.kapasiteDüzenle.Name = "kapasiteDüzenle";
            this.kapasiteDüzenle.Size = new System.Drawing.Size(117, 20);
            this.kapasiteDüzenle.TabIndex = 8;
            // 
            // txtGüncelad
            // 
            this.txtGüncelad.Location = new System.Drawing.Point(150, 51);
            this.txtGüncelad.Name = "txtGüncelad";
            this.txtGüncelad.Size = new System.Drawing.Size(117, 20);
            this.txtGüncelad.TabIndex = 7;
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(192, 125);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(75, 23);
            this.btnSil.TabIndex = 11;
            this.btnSil.Text = "Sil";
            this.İpucu.SetToolTip(this.btnSil, "Bütün Kaydı Siler");
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(20, 78);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(124, 20);
            this.label7.TabIndex = 6;
            this.label7.Text = "Hizmet Kapasitesi :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(50, 49);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(94, 20);
            this.label8.TabIndex = 5;
            this.label8.Text = "Poliklinik Adı :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label5.Location = new System.Drawing.Point(54, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(192, 25);
            this.label5.TabIndex = 5;
            this.label5.Text = "POLİKLİNİK ARA ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(11, 54);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(133, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "Poliklinik Numarası  :";
            // 
            // txtPolNo
            // 
            this.txtPolNo.Location = new System.Drawing.Point(150, 56);
            this.txtPolNo.Name = "txtPolNo";
            this.txtPolNo.Size = new System.Drawing.Size(117, 20);
            this.txtPolNo.TabIndex = 5;
            // 
            // btnAra
            // 
            this.btnAra.Location = new System.Drawing.Point(171, 92);
            this.btnAra.Name = "btnAra";
            this.btnAra.Size = new System.Drawing.Size(75, 23);
            this.btnAra.TabIndex = 6;
            this.btnAra.Text = "ARA";
            this.İpucu.SetToolTip(this.btnAra, "Arama işlemi");
            this.btnAra.UseVisualStyleBackColor = true;
            this.btnAra.Click += new System.EventHandler(this.btnAra_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Cyan;
            this.panel3.Controls.Add(this.txtPolNo);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.btnAra);
            this.panel3.Location = new System.Drawing.Point(12, 248);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(300, 132);
            this.panel3.TabIndex = 9;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.PaleVioletRed;
            this.panel4.Controls.Add(this.label4);
            this.panel4.Location = new System.Drawing.Point(344, 9);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(375, 33);
            this.panel4.TabIndex = 10;
            // 
            // poliklinikBilgileri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(731, 590);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "poliklinikBilgileri";
            this.Text = "Poliklinik İşlemleri";
            this.Load += new System.EventHandler(this.poliklinikBilgileri_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.polKapasitesi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.poliklinikBilgileriBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hastane_Otomasyonu_VeritabanıDataSet)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kapasiteDüzenle)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.TextBox txtPolAdi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label4;
        private Hastane_Otomasyonu_VeritabanıDataSet hastane_Otomasyonu_VeritabanıDataSet;
        private System.Windows.Forms.BindingSource poliklinikBilgileriBindingSource;
        private Hastane_Otomasyonu_VeritabanıDataSetTableAdapters.Poliklinik_BilgileriTableAdapter poliklinik_BilgileriTableAdapter;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtPolNo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnGüncelle;
        private System.Windows.Forms.NumericUpDown kapasiteDüzenle;
        private System.Windows.Forms.Button btnAra;
        private System.Windows.Forms.TextBox txtGüncelad;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox txtPolNoKayit;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.NumericUpDown polKapasitesi;
        private System.Windows.Forms.Button btnDüzenle;
        private System.Windows.Forms.ToolTip İpucu;
        private System.Windows.Forms.DataGridViewTextBoxColumn polNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn polAdıDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hizmetKapasitesiDataGridViewTextBoxColumn;
    }
}