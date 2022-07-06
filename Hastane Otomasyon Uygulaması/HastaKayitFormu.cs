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
using System.Data.OleDb;

namespace Hastane_Otomasyon_Uygulaması
{
    public partial class HastaKayitFormu : Form
    {
        public HastaKayitFormu()
        {
            InitializeComponent();
        }
        SqlBaglantim bgl = new SqlBaglantim();

        private void pictureBox2_Click(object sender, EventArgs e)
        {
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void HastaKayitFormu_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'ds_HastaneOtomasyonu.ilceler' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.ilcelerTableAdapter.Fill(this.ds_HastaneOtomasyonu.ilceler);
            // TODO: Bu kod satırı 'ds_HastaneOtomasyonu.iller' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.illerTableAdapter.Fill(this.ds_HastaneOtomasyonu.iller);
            comboBoxil.Text = "İl Seçiniz...";
            comboBoxilce.Text = "İlçe Seçiniz...";
        }

        private void btnKayit_Click(object sender, EventArgs e)  //Hasta Kayıt İşlemi yapılacak
        {
            if (mskTc.Text.Length < 11) //Masked TextBoxda  Error Provider Düzgün Çalıştırılamadığından dolayı T.C. kimlik hata kontrolü burada yapılıyor.
            {
                MessageBox.Show("T.C. Kimlik Numaranızı Eksik Girdiniz \n Lütfen Kontrol Edip Tekrar Deneyin ! \n Hatalı T.C. Kimlik Numaranız = "+mskTc.Text+"\n 11 Haneli olması gereken Kimlik Numaranızın uzunluğu = "+mskTc.Text.Length+"","Eksik Bilgi Girişi!",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    SqlCommand komutkaydet = new SqlCommand("insert into Destek_Kaydi (Ad,Soyad,Mail,Tel,Cihaz_Tur,Seri_No,Sikayet,Cihaz_Durumu,Fiyat,Yetkili_id,il,ilce,adres) values (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9,@p10,@p11,@p12,@p13)", bgl.baglanti());
                    //Formdaki TextBox,ComboBox,maskedbox'a girilen veriler sql servere aktarılıyor
                    komutkaydet.Parameters.AddWithValue("@p1", txtAd.Text);
                    komutkaydet.Parameters.AddWithValue("@p2", txtSoyad.Text);
                    komutkaydet.Parameters.AddWithValue("@p3", txt);
                    komutkaydet.Parameters.AddWithValue("@p4", comboBoxCinsiyet.Text);
                    komutkaydet.Parameters.AddWithValue("@p5", mskTel.Text.ToString());
                    komutkaydet.Parameters.AddWithValue("@p6", txtAdres.Text);
                    komutkaydet.Parameters.AddWithValue("@p7", comboBoxil.Text);
                    komutkaydet.Parameters.AddWithValue("@p8", comboBoxilce.Text);
                    komutkaydet.ExecuteNonQuery();
                    bgl.baglanti().Close();
                    mskTc.Clear();
                    txtAd.Clear();
                    txtSoyad.Clear();
                    mskDogum.Text = DateTime.Now.ToString();
                    comboBoxCinsiyet.Text = "Belirtilmedi...";
                    mskTel.Clear();
                    txtAdres.Clear();
                    comboBoxil.Text = "Lütfen Seçiniz...";
                    comboBoxilce.Text = "Lütfen Seçiniz...";
                    MessageBox.Show("Hasta Başarıyla Kaydedildi !", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ((anaSayfa)Application.OpenForms["anaSayfa"]).KayitSayisigoster(); //Ana sayfadaki kayıt sayısını güncelliyoruz
                }
                catch (Exception)
                {
                    MessageBox.Show("Hastanın Kaydı Gerçekleştirilemedi ! \n Şunları Kontrol Edin :\n - Boş Alan Bırakmış Olabilirsiniz.\n- Bu T.C. Numarasına Ait Bir Kayıt Bulunuyor olabilir.", "Kayıt Hatası", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void mskTc_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
        }

    }
}
//Data Source=DESKTOP-B4REV5U;Initial Catalog=Hastane_Otomasyonu_Veritabanı;Integrated Security=True 