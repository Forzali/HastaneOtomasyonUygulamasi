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
    public partial class HastaneBilgileri : Form
    {
        public HastaneBilgileri()
        {
            InitializeComponent();
        }
        SqlBaglantim bgl = new SqlBaglantim();

        private void HastaneBilgileri_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'hastane_Otomasyonu_VeritabanıDataSet.ilceler' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.ilcelerTableAdapter.Fill(this.hastane_Otomasyonu_VeritabanıDataSet.ilceler);
            // TODO: Bu kod satırı 'hastane_Otomasyonu_VeritabanıDataSet.iller' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.illerTableAdapter.Fill(this.hastane_Otomasyonu_VeritabanıDataSet.iller);
            // TODO: Bu kod satırı 'hastane_Otomasyonu_VeritabanıDataSet.Hastane_Bilgisi' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.hastane_BilgisiTableAdapter.Fill(this.hastane_Otomasyonu_VeritabanıDataSet.Hastane_Bilgisi);

            comboBoxil.Text = "Seçiniz...";
            comboBoxilce.Text = "Seçiniz...";
            comboBoxGüncelil.Text = "Seçilmedi...";
            comboBoxGüncelilce.Text = "Seçilmedi...";
            txtGüncelAd.Enabled = false;
            txtGüncelTür.Enabled = false;
            comboBoxGüncelil.Enabled = false;
            comboBoxGüncelilce.Enabled = false;
            txtGüncelAdres.Enabled = false;
            btnDüzenle.Enabled = false;
            btnGüncelle.Enabled = false;
            btnSil.Enabled = false;
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand komutkaydet = new SqlCommand("insert into Hastane_Bilgisi (Hastane_ıd,H_Adi,H_Türü,il,ilce,mah_cad) values (@p0,@p1,@p2,@p3,@p4,@p5)", bgl.baglanti());
                komutkaydet.Parameters.AddWithValue("@p0", txtHastaneid.Text);
                komutkaydet.Parameters.AddWithValue("@p1", txtHastaneAdi.Text); //Formdaki TextBox,ComboBox,maskedbox'a girilen veriler sql servere aktarılıyor
                komutkaydet.Parameters.AddWithValue("@p2", txtTür.Text);
                komutkaydet.Parameters.AddWithValue("@p3", comboBoxil.Text);
                komutkaydet.Parameters.AddWithValue("@p4", comboBoxilce.Text);
                komutkaydet.Parameters.AddWithValue("@p5", txtAdres.Text);
                komutkaydet.ExecuteNonQuery();
                bgl.baglanti().Close();
                MessageBox.Show("Hastane Bilgileri Başarıyla Kaydedildi. \n Hastane ID: "+txtHastaneid.Text+"\nHastane Adı : "+txtHastaneAdi.Text+"", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.hastane_BilgisiTableAdapter.Fill(this.hastane_Otomasyonu_VeritabanıDataSet.Hastane_Bilgisi); //Listeyi Günceller
                txtHastaneid.Clear();
                txtHastaneAdi.Clear();
                txtTür.Clear();
                comboBoxil.Text = "Seçiniz...";
                comboBoxilce.Text = "Seçiniz...";
                txtAdres.Clear();
            }
            catch (Exception)
            {
                MessageBox.Show("Hastane Bilgileri Kaydı Başarısız Oldu ! \n Lütfen Boş Bölüm Bırakmayınız.", "Kayıt Hatası", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            SqlCommand ara = new SqlCommand("select * From Hastane_Bilgisi where Hastane_ıd like '%" + txtHastaneNo.Text + "%'", bgl.baglanti());
            SqlDataReader oku = ara.ExecuteReader();
            while (oku.Read())
            {
                txtGüncelAd.Text = oku["H_Adi"].ToString();
                txtGüncelTür.Text = oku["H_Türü"].ToString();
                comboBoxGüncelil.Text = oku["il"].ToString();
                comboBoxGüncelilce.Text = oku["ilce"].ToString();
                txtGüncelAdres.Text = oku["mah_cad"].ToString();
            }
            bgl.baglanti().Close();
            MessageBox.Show(txtHastaneNo.Text + " ID Numaralı Hastanenin:\n Adı: "+txtGüncelAd.Text+"\nBilgileri = Sağdaki Mor Bölüme Getirilmiştir.\n Eğer Bölümler Boşsa Böyle Bir Hastane Kaydı Bulunmamaktadır !", "BİLGİLENDİRME", MessageBoxButtons.OK, MessageBoxIcon.Information);
            btnDüzenle.Enabled = true;
            btnSil.Enabled = true;
        }

        private void btnDüzenle_Click(object sender, EventArgs e)
        {
            txtGüncelAd.Enabled = true;
            txtGüncelTür.Enabled = true;
            comboBoxGüncelil.Enabled = true;
            comboBoxGüncelilce.Enabled = true;
            txtGüncelAdres.Enabled = true;
            btnGüncelle.Enabled = true;
        }

        private void btnGüncelle_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand güncelle = new SqlCommand("update Hastane_Bilgisi set H_Adi=@p1,H_Türü=@p3,il=@p4,ilce=@p5,mah_cad=@p6 where Hastane_ıd=@p2", bgl.baglanti());
                güncelle.Parameters.AddWithValue("@p1", txtGüncelAd.Text);
                güncelle.Parameters.AddWithValue("@p2", txtHastaneNo.Text);
                güncelle.Parameters.AddWithValue("@p3", txtGüncelTür.Text);
                güncelle.Parameters.AddWithValue("@p4", comboBoxGüncelil.Text);
                güncelle.Parameters.AddWithValue("@p5", comboBoxGüncelilce.Text);
                güncelle.Parameters.AddWithValue("@p6", txtGüncelAdres.Text);
                güncelle.ExecuteNonQuery();
                bgl.baglanti().Close();
                MessageBox.Show("Güncelleme İşlemi Başarılı !", "Güncelleme Bilgisi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtGüncelAd.Enabled = false;
                comboBoxGüncelil.Enabled = false;
                comboBoxGüncelilce.Enabled = false;
                txtGüncelAdres.Enabled = false;
                txtGüncelTür.Enabled = false;
                btnDüzenle.Enabled = false;
                btnGüncelle.Enabled = false;
                btnSil.Enabled = false;
                txtGüncelAd.Clear();
                txtHastaneNo.Clear();
                txtGüncelTür.Clear();
                txtGüncelAdres.Clear();
                comboBoxGüncelil.Text = "Seçilmedi...";
                comboBoxGüncelilce.Text = "Seçilmedi...";
                this.hastane_BilgisiTableAdapter.Fill(this.hastane_Otomasyonu_VeritabanıDataSet.Hastane_Bilgisi); //Listeyi Günceller
            }
            catch
            {
                MessageBox.Show("Güncelleme İşlemi Başarısız Oldu ! \n Lütfen Boş Alan Bırakmayın ", "Güncelleme Hatası", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand komutsil = new SqlCommand("delete from Hastane_Bilgisi where Hastane_ıd=@p1", bgl.baglanti());
                komutsil.Parameters.AddWithValue("@p1",txtHastaneNo.Text);
                komutsil.ExecuteNonQuery();
                bgl.baglanti().Close();
                MessageBox.Show("Silme İşlemi Gerçekleşti", "BİLGİLENDİRME", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.hastane_BilgisiTableAdapter.Fill(this.hastane_Otomasyonu_VeritabanıDataSet.Hastane_Bilgisi); //Listeyi Günceller
                txtGüncelAd.Enabled = false;
                comboBoxGüncelil.Enabled = false;
                comboBoxGüncelilce.Enabled = false;
                txtGüncelAdres.Enabled = false;
                txtGüncelTür.Enabled = false;
                btnDüzenle.Enabled = false;
                btnGüncelle.Enabled = false;
                btnSil.Enabled = false;
                txtGüncelAd.Clear();
                txtHastaneNo.Clear();
                txtGüncelTür.Clear();
                txtGüncelAdres.Clear();
                comboBoxGüncelil.Text = "Seçilmedi...";
                comboBoxGüncelilce.Text = "Seçilmedi...";
            }
            catch (Exception)
            {
                MessageBox.Show("Bir Hata Oluştu...", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataHastane_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen;
            string Hastaneno,Hastanead,HastaneTür,Hastaneil,Hastaneilce,HastaneAdres; //datagridviewde seçilen satırdaki veriler buraya atanacak
            secilen = dataHastane.SelectedCells[0].RowIndex;
            Hastaneno = dataHastane.Rows[secilen].Cells[0].Value.ToString();
            Hastanead = dataHastane.Rows[secilen].Cells[1].Value.ToString();
            HastaneTür = dataHastane.Rows[secilen].Cells[2].Value.ToString();
            Hastaneil = dataHastane.Rows[secilen].Cells[3].Value.ToString();
            Hastaneilce = dataHastane.Rows[secilen].Cells[4].Value.ToString();
            HastaneAdres = dataHastane.Rows[secilen].Cells[5].Value.ToString();
            //atanan verileri gerekli yerlere yazdırma işlemi
            txtGüncelAd.Text = Hastanead;
            txtHastaneNo.Text= Hastaneno;
            txtGüncelTür.Text = HastaneTür;
            comboBoxGüncelil.Text = Hastaneil;
            comboBoxGüncelilce.Text = Hastaneilce;
            txtGüncelAdres.Text = HastaneAdres;
            btnDüzenle.Enabled = true;
            btnSil.Enabled = true;
        }
    }
}
