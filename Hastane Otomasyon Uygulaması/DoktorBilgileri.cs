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
    public partial class DoktorBilgileri : Form
    {
        public DoktorBilgileri()
        {
            InitializeComponent();
        }
        SqlBaglantim bgl = new SqlBaglantim();

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        void kilitle()
        {
            txtGüncelAd.Enabled = false;
            txtGüncelSoyad.Enabled = false;
            txtGüncelUzmanlik.Enabled = false;
            txtGüncelMail.Enabled = false;
            mskGüncelTel.Enabled = false;
            comboBoxGüncelCinsiyet.Enabled = false;
            btnDüzenle.Enabled = false;
            btnGüncelle.Enabled = false;
            btnSil.Enabled = false;
        }
        void temizle()
        {
            txtad.Clear();
            txtGüncelAd.Clear();
            txtSoyad.Clear();
            txtGüncelSoyad.Clear();
            txtUzmanlik.Clear();
            txtGüncelUzmanlik.Clear();
            txtDrSicilno.Clear();
            txtSicilno.Clear();
            txtMail.Clear();
            txtGüncelMail.Clear();
            comboBoxCinsiyet.Text = "Seçiniz...";
            comboBoxGüncelCinsiyet.Text = "Seçiniz...";
            mskTel.Clear();
            mskGüncelTel.Clear();

        }

        private void DoktorBilgileri_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'hastane_Otomasyonu_VeritabanıDataSet.Doktor_Bilgileri' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.doktor_BilgileriTableAdapter.Fill(this.hastane_Otomasyonu_VeritabanıDataSet.Doktor_Bilgileri);
            kilitle();
            temizle();
        }
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand komutkaydet = new SqlCommand("insert into Doktor_Bilgileri (SicilNo,Uzmanlik_Alani,Ad,Soyad,Cinsiyet,Telefon,Mail) values (@p0,@p1,@p2,@p3,@p4,@p5,@p6)", bgl.baglanti());
                komutkaydet.Parameters.AddWithValue("@p0", txtSicilno.Text);
                komutkaydet.Parameters.AddWithValue("@p1", txtUzmanlik.Text); //Formdaki TextBox,ComboBox,maskedbox'a girilen veriler sql servere aktarılıyor
                komutkaydet.Parameters.AddWithValue("@p2", txtad.Text);
                komutkaydet.Parameters.AddWithValue("@p3", txtSoyad.Text);
                komutkaydet.Parameters.AddWithValue("@p4", comboBoxCinsiyet.Text);
                komutkaydet.Parameters.AddWithValue("@p5", mskTel.Text);
                komutkaydet.Parameters.AddWithValue("@p6", txtMail.Text);
                komutkaydet.ExecuteNonQuery();
                bgl.baglanti().Close();
                MessageBox.Show("Doktor Bilgileri Başarıyla Kaydedildi. \nDoktor Adı: " + txtad.Text + "\nUzmanlık Alanı: " + txtUzmanlik.Text + "", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.doktor_BilgileriTableAdapter.Fill(this.hastane_Otomasyonu_VeritabanıDataSet.Doktor_Bilgileri); //Listeyi Günceller
                ((anaSayfa)Application.OpenForms["anaSayfa"]).KayitSayisigoster(); //Ana sayfadaki kayıt sayısını güncelliyoruz
                temizle();
            }
            catch (Exception)
            {
                MessageBox.Show("Hastane Bilgileri Kaydı Başarısız Oldu ! \n Lütfen Boş Bölüm Bırakmayınız.", "Kayıt Hatası", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            SqlCommand ara = new SqlCommand("select * From Doktor_Bilgileri where SicilNo like '%" + txtDrSicilno.Text + "%'", bgl.baglanti());
            SqlDataReader oku = ara.ExecuteReader();
            while (oku.Read())
            {
                txtGüncelUzmanlik.Text = oku["Uzmanlik_Alani"].ToString();
                txtGüncelAd.Text = oku["Ad"].ToString();
                txtGüncelSoyad.Text = oku["Soyad"].ToString();
                comboBoxGüncelCinsiyet.Text = oku["Cinsiyet"].ToString();
                mskGüncelTel.Text = oku["Telefon"].ToString();
                txtGüncelMail.Text = oku["Mail"].ToString();
            }
            bgl.baglanti().Close();
            MessageBox.Show(" Doktorun Adı :" + txtGüncelAd.Text + " \n Uzmanlık Alanı: " + txtGüncelUzmanlik.Text + "\n Diğer Bilgileri Sağ Bölümdedir.\n Eğer Bölümler Boşsa Böyle Bir Doktor Kaydı Bulunmamaktadır!", "BİLGİLENDİRME", MessageBoxButtons.OK, MessageBoxIcon.Information);
            btnDüzenle.Enabled = true;
            btnSil.Enabled = true;
        }

        private void btnDüzenle_Click(object sender, EventArgs e)
        {
            btnGüncelle.Enabled = true;
            txtGüncelAd.Enabled = true;
            txtGüncelUzmanlik.Enabled = true;
            txtGüncelSoyad.Enabled = true;
            txtGüncelMail.Enabled = true;
            comboBoxGüncelCinsiyet.Enabled = true;
            mskGüncelTel.Enabled = true;
        }

        private void btnGüncelle_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand güncelle = new SqlCommand("update Doktor_Bilgileri set Uzmanlik_Alani=@p1,Ad=@p3,Soyad=@p4,Cinsiyet=@p5,Telefon=@p6,Mail=@p7 where SicilNo=@p2", bgl.baglanti());
                güncelle.Parameters.AddWithValue("@p1", txtGüncelUzmanlik.Text);
                güncelle.Parameters.AddWithValue("@p2", txtDrSicilno.Text);
                güncelle.Parameters.AddWithValue("@p3", txtGüncelAd.Text);
                güncelle.Parameters.AddWithValue("@p4", txtGüncelSoyad.Text);
                güncelle.Parameters.AddWithValue("@p5", comboBoxGüncelCinsiyet.Text);
                güncelle.Parameters.AddWithValue("@p6", mskGüncelTel.Text);
                güncelle.Parameters.AddWithValue("@p7", txtGüncelMail.Text);
                güncelle.ExecuteNonQuery();
                bgl.baglanti().Close();
                MessageBox.Show("Güncelleme İşlemi Başarılı !", "Güncelleme Bilgisi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.doktor_BilgileriTableAdapter.Fill(this.hastane_Otomasyonu_VeritabanıDataSet.Doktor_Bilgileri); //Listeyi Günceller
                kilitle();
                temizle();
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
                SqlCommand komutsil = new SqlCommand("delete from Doktor_Bilgileri where  SicilNo=@p1", bgl.baglanti());
                komutsil.Parameters.AddWithValue("@p1", txtDrSicilno.Text);
                komutsil.ExecuteNonQuery();
                bgl.baglanti().Close();
                MessageBox.Show("Silme İşlemi Gerçekleşti");
                this.doktor_BilgileriTableAdapter.Fill(this.hastane_Otomasyonu_VeritabanıDataSet.Doktor_Bilgileri); //Listeyi Günceller
                ((anaSayfa)Application.OpenForms["anaSayfa"]).KayitSayisigoster(); //Ana sayfadaki kayıt sayısını güncelliyoruz
                temizle();
                kilitle();
            }
            catch (Exception)
            {
                MessageBox.Show("Hata\nSilme işlemi Başarısız oldu. ");
            }
        }
        int secilen;
        private void doktorListesi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string SicilNo, isim, soyisim,Uzmanlik, cinsiyet, telefon, mail; //datagridviewde seçilen satırdaki veriler buraya atanacak
            secilen = doktorListesi.SelectedCells[0].RowIndex;
            SicilNo= doktorListesi.Rows[secilen].Cells[0].Value.ToString();
            Uzmanlik = doktorListesi.Rows[secilen].Cells[1].Value.ToString();
            isim = doktorListesi.Rows[secilen].Cells[2].Value.ToString();
            soyisim = doktorListesi.Rows[secilen].Cells[3].Value.ToString();
            cinsiyet = doktorListesi.Rows[secilen].Cells[4].Value.ToString();
            telefon = doktorListesi.Rows[secilen].Cells[5].Value.ToString();
            mail = doktorListesi.Rows[secilen].Cells[6].Value.ToString();
            //atanan verileri gerekli yerlere yazdırma işlemi
            txtDrSicilno.Text = SicilNo;
            txtGüncelUzmanlik.Text = Uzmanlik;
            txtGüncelAd.Text = isim;
            txtGüncelSoyad.Text = soyisim;
            comboBoxGüncelCinsiyet.Text = cinsiyet;
            mskGüncelTel.Text = telefon;
            txtGüncelMail.Text = mail;
            btnDüzenle.Enabled = true;
            btnSil.Enabled = true;
        }
    }
}
