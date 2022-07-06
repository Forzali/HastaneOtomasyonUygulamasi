using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hastane_Otomasyon_Uygulaması
{
    public partial class HastaDüzenlemeVeArama : Form
    {
        public HastaDüzenlemeVeArama()
        {
            InitializeComponent();
        }
        SqlBaglantim bgl = new SqlBaglantim();
        private void HastaDüzenlemeVeArama_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'ds_HastaneOtomasyonu.ilceler' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.ilcelerTableAdapter.Fill(this.ds_HastaneOtomasyonu.ilceler);
            // TODO: Bu kod satırı 'ds_HastaneOtomasyonu.iller' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.illerTableAdapter.Fill(this.ds_HastaneOtomasyonu.iller);
            // TODO: Bu kod satırı 'ds_HastaneOtomasyonu.Hasta_Bilgileri' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.hasta_BilgileriTableAdapter.Fill(this.ds_HastaneOtomasyonu.Hasta_Bilgileri);

            txtAd.Enabled = false;
            txtSoyad.Enabled = false;
            mskDogum.Enabled = false;
            mskTel.Enabled = false;
            txtAdres.Enabled = false;
            comboBoxCinsiyet.Enabled = false;
            comboBoxil.Enabled = false;
            comboBoxilce.Enabled = false;
            comboBoxil.Text = "Belirtilmedi...";
            comboBoxilce.Text = "Belirtilmedi...;";
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand komutsil = new SqlCommand("delete from Hasta_Bilgileri where Tc_No=@p1", bgl.baglanti());
                komutsil.Parameters.AddWithValue("@p1", mskTc.Text);
                komutsil.ExecuteNonQuery();
                bgl.baglanti().Close();
                MessageBox.Show("Silme İşlemi Gerçekleşti");
                this.hasta_BilgileriTableAdapter.Fill(this.ds_HastaneOtomasyonu.Hasta_Bilgileri);
                ((anaSayfa)Application.OpenForms["anaSayfa"]).KayitSayisigoster(); //Ana sayfadaki kayıt sayısını güncelliyoruz
                mskTc.Clear();
                txtAd.Clear();
                txtSoyad.Clear();
                txtAdres.Clear();
                mskDogum.Value = DateTime.Now;
                comboBoxCinsiyet.Text = "Belirtilmedi...";
                mskTel.Clear();
                comboBoxil.Text = "Seçilmedi...";
                comboBoxilce.Text = "Seçilmedi...";
            }
            catch (Exception)
            {
                MessageBox.Show("Hata Silme işlemi Gerçekleşmedi. ");
            }
        }
        int secilen;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string tc,isim,soyisim,dg,cinsiyt,tlf,adres,il,ilce; //datagridviewde seçilen satırdaki veriler buraya atanacak
            secilen = dataGridView1.SelectedCells[0].RowIndex;
            tc = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            isim = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            soyisim = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            dg = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            cinsiyt = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            tlf = dataGridView1.Rows[secilen].Cells[5].Value.ToString();
            adres = dataGridView1.Rows[secilen].Cells[6].Value.ToString();
            il = dataGridView1.Rows[secilen].Cells[7].Value.ToString();
            ilce = dataGridView1.Rows[secilen].Cells[8].Value.ToString();
            //atanan verileri gerekli yerlere yazdırma işlemi
            mskTc.Text = tc;
            txtAd.Text = isim;
            txtSoyad.Text = soyisim;
            mskDogum.Text = dg;
            comboBoxCinsiyet.Text = cinsiyt;
            mskTel.Text = tlf;
            txtAdres.Text = adres;
            comboBoxil.Text = il;
            comboBoxilce.Text = ilce;

        }

        private void btnGüncelle_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand güncelle = new SqlCommand("update Hasta_Bilgileri set Ad=@p1,Soyad=@p3,Dogum_Tarihi=@p4,Cinsiyet=@p5,Telefon=@p6,Adres=@p7,il=@p8,ilce=@p9 where Tc_No=@p2", bgl.baglanti());
                güncelle.Parameters.AddWithValue("@p1", txtAd.Text);
                güncelle.Parameters.AddWithValue("@p2", mskTc.Text);
                güncelle.Parameters.AddWithValue("@p3", txtSoyad.Text);
                güncelle.Parameters.AddWithValue("@p4", mskDogum.Text);
                güncelle.Parameters.AddWithValue("@p5", comboBoxCinsiyet.Text);
                güncelle.Parameters.AddWithValue("@p6", mskTel.Text);
                güncelle.Parameters.AddWithValue("@p7", txtAdres.Text);
                güncelle.Parameters.AddWithValue("@p8", comboBoxil.Text);
                güncelle.Parameters.AddWithValue("@p9", comboBoxilce.Text);
                güncelle.ExecuteNonQuery();
                bgl.baglanti().Close();
                MessageBox.Show("Güncelleme İşlemi Başarılı !","Güncelleme Bilgisi",MessageBoxButtons.OK,MessageBoxIcon.Information);
                this.hasta_BilgileriTableAdapter.Fill(this.ds_HastaneOtomasyonu.Hasta_Bilgileri);
                txtAd.Enabled = false;
                txtSoyad.Enabled = false;
                mskDogum.Enabled = false;
                mskTel.Enabled = false;
                txtAdres.Enabled = false;
                comboBoxCinsiyet.Enabled = false;
                comboBoxil.Enabled = false;
                comboBoxilce.Enabled = false;
                mskTc.Clear();
                txtAd.Clear();
                txtSoyad.Clear();
                mskDogum.Text = DateTime.Now.ToString();
                comboBoxCinsiyet.Text = "Belirtilmedi...";
                mskTel.Clear();
                txtAdres.Clear();
                comboBoxil.Text = "Lütfen Seçiniz...";
                comboBoxilce.Text = "Lütfen Seçiniz...";
            }
            catch
            {
                MessageBox.Show("Güncelleme İşlemi Başarısız Oldu ! \n Lütfen Boş Alan Bırakmayın ","Güncelleme Hatası",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            int uzunluk = mskTc.Text.Length; //Eksik karakter sayısını gösterebilmek adına ayrı değişken tanımladım
            if (uzunluk< 11)
            {
                MessageBox.Show("T.C. Kimlik Numaranızı Eksik Girdiniz \n Lütfen Kontrol Edip Tekrar Deneyin ! \n Hatalı T.C. Kimlik Numaranız = " + mskTc.Text + "\n" + (11-uzunluk) + " Karakter Eksik Girildi Lütfen Düzeltin.", "Eksik Bilgi Girişi!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                SqlCommand ara = new SqlCommand("select * From Hasta_Bilgileri where Tc_No like '%" + mskTc.Text + "%'", bgl.baglanti());
                SqlDataReader oku = ara.ExecuteReader();
                while (oku.Read())
                {
                    txtAd.Text = oku["Ad"].ToString();
                    txtSoyad.Text = oku["Soyad"].ToString();
                    mskDogum.Text = oku["Dogum_Tarihi"].ToString();
                    comboBoxCinsiyet.Text = oku["Cinsiyet"].ToString();
                    mskTel.Text = oku["Telefon"].ToString();
                    comboBoxil.Text = oku["il"].ToString();
                    comboBoxilce.Text = oku["ilce"].ToString();
                    txtAdres.Text = oku["Adres"].ToString();

                }
                bgl.baglanti().Close();
            }
        }

        private void btnDüzenle_Click(object sender, EventArgs e)
        {
            txtAd.Enabled = true;
            txtSoyad.Enabled = true;
            mskDogum.Enabled = true;
            mskTel.Enabled = true;
            txtAdres.Enabled = true;
            comboBoxCinsiyet.Enabled = true;
            comboBoxil.Enabled = true;
            comboBoxilce.Enabled = true;
        }
    }
}
