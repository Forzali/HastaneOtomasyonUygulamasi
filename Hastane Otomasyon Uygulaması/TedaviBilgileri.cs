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
    public partial class TedaviBilgileri : Form
    {
        public TedaviBilgileri()
        {
            InitializeComponent();
        }
        SqlBaglantim bgl = new SqlBaglantim();
        private void TedaviBilgileri_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'hastane_Otomasyonu_VeritabanıDataSet.Poliklinik_Bilgileri' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.poliklinik_BilgileriTableAdapter.Fill(this.hastane_Otomasyonu_VeritabanıDataSet.Poliklinik_Bilgileri);
            // TODO: Bu kod satırı 'hastane_Otomasyonu_VeritabanıDataSet.Tedavi_Bilgileri' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.tedavi_BilgileriTableAdapter.Fill(this.hastane_Otomasyonu_VeritabanıDataSet.Tedavi_Bilgileri);
            temizle();
            btnDüzenle.Enabled = false;
            btnGüncelle.Enabled = false;
            btnSil.Enabled = false;
            comboBoxGüncelPolno.Enabled = false;
            txtGüncelSonuc.Enabled = false;
            txtGüncelTedavi.Enabled= false;
        }
        void temizle()
        {
            comboBoxGüncelPolno.Text = "Belirtilmedi...";
            comboBoxPolno.Text = "Seçiniz...";
            DrSicilNo.Clear();
            drSicilNoGüncel.Visible = false;
            DrSicilNoGüncelYazi.Visible = false;
            mskGüncelTc.Clear();
            mskTc.Clear();
            dtpTarih.Value = DateTime.Now;
            dtpTarih.Value = DateTime.Now;
            txtTedavi.Clear();
            txtGüncelTedavi.Clear();
            txtSonuc.Clear();
            txtGüncelSonuc.Clear();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (mskTc.Text.Length < 11)
            {
                MessageBox.Show("T.C. Numaranız 11 Haneden eksik olamaz !");
            }
            else
            {
                try
                {
                    SqlCommand komutkaydet = new SqlCommand("insert into Tedavi_Bilgileri (Pol_No,DrSicilNo,H_TcNo,Tedavi_Tarihi,Tedavi,Tedavi_Sonucu) values (@p0,@p1,@p2,@p3,@p4,@p5)", bgl.baglanti());
                    komutkaydet.Parameters.AddWithValue("@p0", comboBoxPolno.Text);
                    komutkaydet.Parameters.AddWithValue("@p1", DrSicilNo.Text); //Formdaki TextBox,ComboBox,maskedbox'a girilen veriler sql servere aktarılıyor
                    komutkaydet.Parameters.AddWithValue("@p2", mskTc.Text);
                    komutkaydet.Parameters.AddWithValue("@p3", dtpTarih.Text);
                    komutkaydet.Parameters.AddWithValue("@p4", txtTedavi.Text);
                    komutkaydet.Parameters.AddWithValue("@p5", txtSonuc.Text);
                    komutkaydet.ExecuteNonQuery();
                    bgl.baglanti().Close();
                    MessageBox.Show("Tedavi Bilgileri Başarıyla Kaydedildi!", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.tedavi_BilgileriTableAdapter.Fill(this.hastane_Otomasyonu_VeritabanıDataSet.Tedavi_Bilgileri); //Listeyi Günceller
                    temizle();
                    ((anaSayfa)Application.OpenForms["anaSayfa"]).KayitSayisigoster(); //Ana sayfadaki kayıt sayısını güncelliyoruz
                }
                catch (Exception)
                {
                    MessageBox.Show("Tedavi Kaydı Başarısız Oldu ! \n Şunları Kontrol edin :\n--T.C. Kimlik Numaranız Kayıtlı olmayabilir.\n--Doktor Sicil Numarası Yanlış Girilmiş Olabilir.", "Kayıt Hatası", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            SqlCommand ara = new SqlCommand("select * From Tedavi_Bilgileri where H_TcNo like '%" + mskGüncelTc.Text + "%' and Tedavi_Tarihi like '%" + dtpGüncelTarih.Text + "%'", bgl.baglanti());
            SqlDataReader oku = ara.ExecuteReader();
            while (oku.Read())
            {
                comboBoxGüncelPolno.Text = oku["Pol_No"].ToString();
                txtGüncelTedavi.Text = oku["Tedavi"].ToString();
                txtGüncelSonuc.Text = oku["Tedavi_Sonucu"].ToString();
                DrSicilNoGüncelYazi.Text = oku["DrSicilNo"].ToString();

            }
            bgl.baglanti().Close();
            MessageBox.Show(mskGüncelTc.Text + " T.C. Numaralı Hastanın:\nTeşhis Bilgileri Aşağıdaki Bölüme Getirilmiştir.\n Eğer Bölümler Boşsa Böyle Bir Teşhis Kaydı Bulunmamaktadır !", "BİLGİLENDİRME", MessageBoxButtons.OK, MessageBoxIcon.Information);
            btnDüzenle.Enabled = true;
            btnSil.Enabled = true;
            drSicilNoGüncel.Visible = true;
            DrSicilNoGüncelYazi.Visible = true;
        }

        private void btnDüzenle_Click(object sender, EventArgs e)
        {
            btnGüncelle.Enabled = true;
            comboBoxGüncelPolno.Enabled = true;
            txtGüncelTedavi.Enabled = true;
            txtGüncelSonuc.Enabled = true;
        }

        private void btnGüncelle_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand güncelle = new SqlCommand("update Tedavi_Bilgileri set Pol_No=@p1,Tedavi=@p2,Tedavi_Sonucu=@p3 where H_TcNo like '%" + mskGüncelTc.Text + "%' and Tedavi_Tarihi like '%" + dtpGüncelTarih.Text + "%'", bgl.baglanti());
                güncelle.Parameters.AddWithValue("@p1", comboBoxGüncelPolno.Text);
                güncelle.Parameters.AddWithValue("@p2", txtGüncelTedavi.Text);
                güncelle.Parameters.AddWithValue("@p3", txtGüncelSonuc.Text);
                güncelle.ExecuteNonQuery();
                bgl.baglanti().Close();
                MessageBox.Show("Güncelleme İşlemi Başarılı !", "Güncelleme Bilgisi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnDüzenle.Enabled = false;
                btnGüncelle.Enabled = false;
                btnSil.Enabled = false;
                temizle();
                this.tedavi_BilgileriTableAdapter.Fill(this.hastane_Otomasyonu_VeritabanıDataSet.Tedavi_Bilgileri); //Listeyi Günceller
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
                SqlCommand komutsil = new SqlCommand("delete from Tedavi_Bilgileri where H_TcNo like '%" + mskGüncelTc.Text + "%' and Tedavi_Tarihi like '%" + dtpGüncelTarih.Text + "%'", bgl.baglanti());
                komutsil.ExecuteNonQuery();
                bgl.baglanti().Close();
                MessageBox.Show("Silme İşlemi Gerçekleşti", "BİLGİLENDİRME", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.tedavi_BilgileriTableAdapter.Fill(this.hastane_Otomasyonu_VeritabanıDataSet.Tedavi_Bilgileri); //Listeyi Günceller
                btnDüzenle.Enabled = false;
                btnGüncelle.Enabled = false;
                btnSil.Enabled = false;
                temizle();//temizle metodu çağrıldı
                ((anaSayfa)Application.OpenForms["anaSayfa"]).KayitSayisigoster(); //Ana sayfadaki kayıt sayısını güncelliyoruz
            }
            catch (Exception)
            {
                MessageBox.Show("Bir Hata Oluştu...", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void teshisListesi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void tedaviListesi_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen;
            string Poliklinikno, drsicil, tcno, tarih, tedavi, sonuc; //datagridviewde seçilen satırdaki veriler buraya atanacak
            secilen = tedaviListesi.SelectedCells[0].RowIndex;
            Poliklinikno = tedaviListesi.Rows[secilen].Cells[0].Value.ToString();
            drsicil = tedaviListesi.Rows[secilen].Cells[1].Value.ToString();
            tcno = tedaviListesi.Rows[secilen].Cells[2].Value.ToString();
            tarih = tedaviListesi.Rows[secilen].Cells[3].Value.ToString();
            tedavi = tedaviListesi.Rows[secilen].Cells[4].Value.ToString();
            sonuc= tedaviListesi.Rows[secilen].Cells[5].Value.ToString();
            //atanan verileri gerekli yerlere yazdırma işlemi
            mskGüncelTc.Text = tcno;
            dtpGüncelTarih.Text = tarih;
            comboBoxGüncelPolno.Text = Poliklinikno;
            txtGüncelTedavi.Text = tedavi;
            txtGüncelSonuc.Text = sonuc;
            DrSicilNoGüncelYazi.Text = drsicil;
            btnDüzenle.Enabled = true;
            btnSil.Enabled = true;
            drSicilNoGüncel.Visible = true;
            DrSicilNoGüncelYazi.Visible = true;
        }
    }
}
