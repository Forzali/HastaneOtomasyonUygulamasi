using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Hastane_Otomasyon_Uygulaması
{
    public partial class teshisBilgileri : Form
    {
        public teshisBilgileri()
        {
            InitializeComponent();
        }

        SqlBaglantim bgl = new SqlBaglantim();

        private void teshisBilgileri_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'hastane_Otomasyonu_VeritabanıDataSet.Teshis_Bilgileri' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.teshis_BilgileriTableAdapter.Fill(this.hastane_Otomasyonu_VeritabanıDataSet.Teshis_Bilgileri);
            // TODO: Bu kod satırı 'hastane_Otomasyonu_VeritabanıDataSet.Poliklinik_Bilgileri' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.poliklinik_BilgileriTableAdapter.Fill(this.hastane_Otomasyonu_VeritabanıDataSet.Poliklinik_Bilgileri);
            btnDüzenle.Enabled = false;
            btnGüncelle.Enabled = false;
            btnSil.Enabled = false;
            txtGüncelTeshis.Enabled = false;
            comboBoxPolno.Text = "Seçiniz...";
            comboBoxGüncelPolno.Text = "Seçilmedi...";
            comboBoxGüncelPolno.Enabled = false;
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (mskTc.Text.Length<11)
            {
                MessageBox.Show("T.C. Numaranız 11 Haneden eksik olamaz !");
            }
            else 
            { 
                try
                {
                SqlCommand komutkaydet = new SqlCommand("insert into Teshis_Bilgileri (Pol_No,H_tcNo,Teshis_Tarihi,Teshis) values (@p0,@p1,@p2,@p3)", bgl.baglanti());
                komutkaydet.Parameters.AddWithValue("@p0", comboBoxPolno.Text);
                komutkaydet.Parameters.AddWithValue("@p1", mskTc.Text); //Formdaki TextBox,ComboBox,maskedbox'a girilen veriler sql servere aktarılıyor
                komutkaydet.Parameters.AddWithValue("@p2", dtpTarih.Text);
                komutkaydet.Parameters.AddWithValue("@p3", txtTeshis.Text);
                komutkaydet.ExecuteNonQuery();
                bgl.baglanti().Close();
                MessageBox.Show("Teşhis Bilgileri Başarıyla Kaydedildi!", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.teshis_BilgileriTableAdapter.Fill(this.hastane_Otomasyonu_VeritabanıDataSet.Teshis_Bilgileri); //Listeyi Günceller
                comboBoxPolno.Text = "Seçiniz...";
                mskTc.Clear();
                dtpTarih.Value = DateTime.Now;
                txtTeshis.Clear();
                }
                catch (Exception)
                {
                MessageBox.Show("Teşhis Kaydı Başarısız Oldu ! \n Bu T.C. Numarasına Kayıtlı Bir Hasta Bulunmamaktadır!", "Kayıt Hatası", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
             }
        }

        private void btnDüzenle_Click_1(object sender, EventArgs e)
        {
            btnGüncelle.Enabled = true;
            comboBoxGüncelPolno.Enabled = true;
            txtGüncelTeshis.Enabled = true;
            btnSil.Enabled = false;
        }

        private void btnAra_Click_1(object sender, EventArgs e)
        {
            SqlCommand ara = new SqlCommand("select * From Teshis_Bilgileri where H_tcNo like '%" + mskGüncelTc.Text + "%' and Teshis_Tarihi like '%" + dtpGüncelTarih.Text + "%'", bgl.baglanti());
            SqlDataReader oku = ara.ExecuteReader();
            while (oku.Read())
            {
                comboBoxGüncelPolno.Text = oku["Pol_No"].ToString();
                txtGüncelTeshis.Text = oku["Teshis"].ToString();
            }
            bgl.baglanti().Close();
            MessageBox.Show(mskGüncelTc.Text + " T.C. Numaralı Hastanın:\nTeşhis Bilgileri Aşağıdaki Bölüme Getirilmiştir.\n Eğer Bölümler Boşsa Böyle Bir Teşhis Kaydı Bulunmamaktadır !", "BİLGİLENDİRME", MessageBoxButtons.OK, MessageBoxIcon.Information);
            btnDüzenle.Enabled = true;
            btnSil.Enabled = true;
        }

        private void btnGüncelle_Click_1(object sender, EventArgs e)
        {
            try
            {
                SqlCommand güncelle = new SqlCommand("update Teshis_Bilgileri set Pol_No=@p1,Teshis_Tarihi=@p3,Teshis=@p4 where H_tcNo like '%" + mskGüncelTc.Text + "%' and Teshis_Tarihi like '%" + dtpGüncelTarih.Text + "%'", bgl.baglanti());
                güncelle.Parameters.AddWithValue("@p1", comboBoxGüncelPolno.Text);
                güncelle.Parameters.AddWithValue("@p2", dtpGüncelTarih.Text);
                güncelle.Parameters.AddWithValue("@p3", dtpGüncelTarih.Text);
                güncelle.Parameters.AddWithValue("@p4", txtGüncelTeshis.Text);
                güncelle.ExecuteNonQuery();
                bgl.baglanti().Close();
                MessageBox.Show("Güncelleme İşlemi Başarılı !", "Güncelleme Bilgisi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnDüzenle.Enabled = false;
                btnGüncelle.Enabled = false;
                btnSil.Enabled = false;
                txtGüncelTeshis.Enabled = false;
                comboBoxGüncelPolno.Text = "Seçilmedi...";
                comboBoxGüncelPolno.Enabled = false;
                mskGüncelTc.Clear();
                dtpGüncelTarih.Value = DateTime.Now;
                txtGüncelTeshis.Clear();
                this.teshis_BilgileriTableAdapter.Fill(this.hastane_Otomasyonu_VeritabanıDataSet.Teshis_Bilgileri); //Listeyi Günceller
            }
            catch
            {
                MessageBox.Show("Güncelleme İşlemi Başarısız Oldu ! \n Lütfen Boş Alan Bırakmayın ", "Güncelleme Hatası", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSil_Click_1(object sender, EventArgs e)
        {
            try
            {
                SqlCommand komutsil = new SqlCommand("delete from Teshis_Bilgileri where H_tcNo like '%" + mskGüncelTc.Text + "%' and Teshis_Tarihi like '%" + dtpGüncelTarih.Text + "%'", bgl.baglanti());
                komutsil.ExecuteNonQuery();
                bgl.baglanti().Close();
                MessageBox.Show("Silme İşlemi Gerçekleşti", "BİLGİLENDİRME", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.teshis_BilgileriTableAdapter.Fill(this.hastane_Otomasyonu_VeritabanıDataSet.Teshis_Bilgileri); //Listeyi Günceller
                btnDüzenle.Enabled = false;
                btnGüncelle.Enabled = false;
                btnSil.Enabled = false;
                txtGüncelTeshis.Enabled = false;
                comboBoxGüncelPolno.Text = "Seçilmedi...";
                comboBoxGüncelPolno.Enabled = false;
                mskGüncelTc.Clear();
                dtpGüncelTarih.Value = DateTime.Now;
                txtGüncelTeshis.Clear();
            }
            catch (Exception)
            {
                MessageBox.Show("Bir Hata Oluştu...", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void teshisListesi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen;
            string Poliklinikno, tcno, tarih, teshis; //datagridviewde seçilen satırdaki veriler buraya atanacak
            secilen = teshisListesi.SelectedCells[0].RowIndex;
            Poliklinikno = teshisListesi.Rows[secilen].Cells[0].Value.ToString();
            tcno = teshisListesi.Rows[secilen].Cells[1].Value.ToString();
            tarih = teshisListesi.Rows[secilen].Cells[2].Value.ToString();
            teshis = teshisListesi.Rows[secilen].Cells[3].Value.ToString();
            //atanan verileri gerekli yerlere yazdırma işlemi
            mskGüncelTc.Text = tcno;
            dtpGüncelTarih.Text =tarih;
            comboBoxGüncelPolno.Text = Poliklinikno;
            txtGüncelTeshis.Text = teshis;
            btnDüzenle.Enabled = true;
            btnSil.Enabled = true;
        }
    }
}
