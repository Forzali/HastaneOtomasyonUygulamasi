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
    public partial class poliklinikBilgileri : Form
    {
        public poliklinikBilgileri()
        {
            InitializeComponent();
        }
        SqlBaglantim bgl = new SqlBaglantim();

        private void poliklinikBilgileri_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'hastane_Otomasyonu_VeritabanıDataSet.Poliklinik_Bilgileri' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.poliklinik_BilgileriTableAdapter.Fill(this.hastane_Otomasyonu_VeritabanıDataSet.Poliklinik_Bilgileri);
            txtGüncelad.Enabled = false;
            kapasiteDüzenle.Enabled = false;
            btnSil.Enabled = false;
            btnDüzenle.Enabled = false;
            btnGüncelle.Enabled = false;

        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand komutkaydet = new SqlCommand("insert into Poliklinik_Bilgileri (Pol_No,Pol_Adı,Hizmet_Kapasitesi) values (@p0,@p1,@p2)", bgl.baglanti());
                komutkaydet.Parameters.AddWithValue("@p0", txtPolNoKayit.Text);
                komutkaydet.Parameters.AddWithValue("@p1", txtPolAdi.Text); //Formdaki TextBox,ComboBox,maskedbox'a girilen veriler sql servere aktarılıyor
                komutkaydet.Parameters.AddWithValue("@p2", polKapasitesi.Value);
                komutkaydet.ExecuteNonQuery();
                bgl.baglanti().Close();
                MessageBox.Show("Poliklinik Başarıyla Kaydedildi.", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.poliklinik_BilgileriTableAdapter.Fill(this.hastane_Otomasyonu_VeritabanıDataSet.Poliklinik_Bilgileri); //Listeyi Günceller
                txtPolNoKayit.Clear();
                txtPolAdi.Clear();
                polKapasitesi.Value = 0;
                ((anaSayfa)Application.OpenForms["anaSayfa"]).KayitSayisigoster(); //Ana sayfadaki kayıt sayısını güncelliyoruz
            }
            catch (Exception)
            {
                MessageBox.Show("Poliklinik Kaydı Başarısız Oldu ! \n Lütfen Boş Bölüm Bırakmayınız.", "Kayıt Hatası", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            SqlCommand ara = new SqlCommand("select * From Poliklinik_Bilgileri where Pol_No like '%" + txtPolNo.Text + "%'", bgl.baglanti());
            SqlDataReader oku = ara.ExecuteReader();
            while (oku.Read())
            {
                txtGüncelad.Text = oku["Pol_Adı"].ToString();
                kapasiteDüzenle.Value = Convert.ToInt32(oku["Hizmet_Kapasitesi"].ToString());

            }
            bgl.baglanti().Close();
            MessageBox.Show(txtPolNo.Text + " Numaralı Polikliniğin Bilgileri Aşağıdaki Mavi Bölüme Getirilmiştir.\n Eğer Bölümler Boşsa Böyle Bir Poliklinik Yoktur !", "BİLGİLENDİRME", MessageBoxButtons.OK, MessageBoxIcon.Information);
            btnDüzenle.Enabled = true;
            btnSil.Enabled = true;
        }

        private void btnDüzenle_Click(object sender, EventArgs e)
        {
            btnGüncelle.Enabled = true;
            txtGüncelad.Enabled = true;
            kapasiteDüzenle.Enabled = true;
        }

        private void btnGüncelle_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand güncelle = new SqlCommand("update Poliklinik_Bilgileri set Pol_Adı=@p1,Hizmet_Kapasitesi=@p3 where Pol_No=@p2", bgl.baglanti());
                güncelle.Parameters.AddWithValue("@p1", txtGüncelad.Text);
                güncelle.Parameters.AddWithValue("@p2", txtPolNo.Text);
                güncelle.Parameters.AddWithValue("@p3", kapasiteDüzenle.Value);
                güncelle.ExecuteNonQuery();
                bgl.baglanti().Close();
                MessageBox.Show("Güncelleme İşlemi Başarılı !", "Güncelleme Bilgisi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtGüncelad.Enabled = false;
                kapasiteDüzenle.Enabled = false;
                btnDüzenle.Enabled = false;
                btnGüncelle.Enabled = false;
                btnSil.Enabled = false;
                txtGüncelad.Clear();
                txtPolNo.Clear();
                kapasiteDüzenle.Value = 0;
                this.poliklinik_BilgileriTableAdapter.Fill(this.hastane_Otomasyonu_VeritabanıDataSet.Poliklinik_Bilgileri); //Listeyi Günceller
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
                SqlCommand komutsil = new SqlCommand("delete from Poliklinik_Bilgileri where Pol_No=@p1", bgl.baglanti());
                komutsil.Parameters.AddWithValue("@p1", txtPolNo.Text);
                komutsil.ExecuteNonQuery();
                bgl.baglanti().Close();
                MessageBox.Show("Silme İşlemi Gerçekleşti","BİLGİLENDİRME",MessageBoxButtons.OK,MessageBoxIcon.Information);
                this.poliklinik_BilgileriTableAdapter.Fill(this.hastane_Otomasyonu_VeritabanıDataSet.Poliklinik_Bilgileri); //Listeyi Günceller
                txtGüncelad.Enabled = false;
                kapasiteDüzenle.Enabled = false;
                btnDüzenle.Enabled = false;
                btnGüncelle.Enabled = false;
                btnSil.Enabled = false;
                txtGüncelad.Clear();
                txtPolNo.Clear();
                kapasiteDüzenle.Value = 0;
                ((anaSayfa)Application.OpenForms["anaSayfa"]).KayitSayisigoster(); //Ana sayfadaki kayıt sayısını güncelliyoruz
            }
            catch (Exception)
            {
                MessageBox.Show("Bir Hata Oluştu...\nBu Poliklinik üzerine Tedavi veya Teşhis Kaydı Oluşturulmuş.","HATA",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        int secilen;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e) //listede işaretlenen veriler kutulara yerleştiriliyor
        {
            string PolNo,PolAd,Kapasite; //datagridviewde seçilen satırdaki veriler buraya atanacak
            secilen = dataGridView1.SelectedCells[0].RowIndex;
            PolNo = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            PolAd = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            Kapasite = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            //atanan verileri gerekli yerlere yazdırma işlemi
            txtGüncelad.Text = PolAd;
            kapasiteDüzenle.Text = Kapasite;
            txtPolNo.Text= PolNo;
            btnDüzenle.Enabled = true;
            btnSil.Enabled = true;
        }
       
        
    } 
}
