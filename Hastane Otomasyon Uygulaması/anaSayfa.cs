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
    public partial class anaSayfa : Form
    {
        public anaSayfa()
        {
            InitializeComponent();
        }

        private void anaSayfa_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'hastane_Otomasyonu_VeritabanıDataSet.Tedavi_Bilgileri' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.tedavi_BilgileriTableAdapter.Fill(this.hastane_Otomasyonu_VeritabanıDataSet.Tedavi_Bilgileri);
            // TODO: Bu kod satırı 'hastane_Otomasyonu_VeritabanıDataSet.Doktor_Bilgileri' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.doktor_BilgileriTableAdapter.Fill(this.hastane_Otomasyonu_VeritabanıDataSet.Doktor_Bilgileri);
            // TODO: Bu kod satırı 'hastane_Otomasyonu_VeritabanıDataSet.Poliklinik_Bilgileri' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.poliklinik_BilgileriTableAdapter.Fill(this.hastane_Otomasyonu_VeritabanıDataSet.Poliklinik_Bilgileri);
            // TODO: Bu kod satırı 'hastane_Otomasyonu_VeritabanıDataSet.Hasta_Bilgileri' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.hasta_BilgileriTableAdapter.Fill(this.hastane_Otomasyonu_VeritabanıDataSet.Hasta_Bilgileri);
            tarihSaat.Start();
            KayitSayisigoster();
        }
        SqlBaglantim bgl = new SqlBaglantim();


        private void tarihSaat_Tick(object sender, EventArgs e)
        {
            lblTarih.Text = DateTime.Now.ToLongDateString();
            lblSaat.Text = DateTime.Now.ToLongTimeString();
        }

        private void hastaEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HastaKayitFormu frm = new HastaKayitFormu();
            frm.Show();
        }

        private void hastaKayıtListesiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HastaDüzenlemeVeArama form = new HastaDüzenlemeVeArama();
            form.Show();
        }

        private void hastaTeşhisBilgisiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            teshisBilgileri formteshis = new teshisBilgileri();
            formteshis.Show();
        }

        private void poliklinikEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            poliklinikBilgileri formpoliklinik = new poliklinikBilgileri();
            formpoliklinik.Show();
        }


       public void KayitSayisigoster()
        {
            //ilk önce listeyi güncelliyoruz diğer formlardan çağıracağımız için.
            this.tedavi_BilgileriTableAdapter.Fill(this.hastane_Otomasyonu_VeritabanıDataSet.Tedavi_Bilgileri);
            this.doktor_BilgileriTableAdapter.Fill(this.hastane_Otomasyonu_VeritabanıDataSet.Doktor_Bilgileri);
            this.poliklinik_BilgileriTableAdapter.Fill(this.hastane_Otomasyonu_VeritabanıDataSet.Poliklinik_Bilgileri);
            this.hasta_BilgileriTableAdapter.Fill(this.hastane_Otomasyonu_VeritabanıDataSet.Hasta_Bilgileri);
            //Güncelleme işlemi bitti şimdi ekrana yazdırma zamanı.
            int Hasta, Poliklinik,Doktor;
            Hasta = lstHasta.Rows.Count;
            Poliklinik = lstPol.Rows.Count;
            Doktor = lstDoktor.Rows.Count;
            lblHastaSayi.Text = Convert.ToString(Hasta-1);
            lblPolsay.Text = Convert.ToString(Poliklinik-1);
            lbldoktor.Text = Convert.ToString(Doktor-1);
            //Buradan sonrası günlük tedavi sayısını gösteren kodlar
            string bugün = DateTime.Now.ToShortDateString();
            SqlDataAdapter liste = new SqlDataAdapter("select * from Tedavi_Bilgileri where Tedavi_Tarihi like '" + bugün + "'", bgl.baglanti());
            DataTable tablo = new DataTable();
            liste.Fill(tablo);
            dataGridView1.DataSource = tablo;
            int sayi = dataGridView1.Rows.Count;
            lblTedavi.Text = Convert.ToString(sayi - 1);
        }

        private void hastaneHakkındaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HastaneBilgileri formHastane = new HastaneBilgileri();
            formHastane.Show();
        }

        private void doktorBilgileriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DoktorBilgileri FormDoktor = new DoktorBilgileri();
            FormDoktor.Show();
        }

        private void hastaTedaviBilgisiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TedaviBilgileri FormTedavi = new TedaviBilgileri();
            FormTedavi.Show();
        }
    }

}
