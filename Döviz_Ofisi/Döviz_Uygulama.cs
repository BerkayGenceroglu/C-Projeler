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
using System.Xml;
using System.Xml.Linq;  

namespace Döviz_Ofisi
{
    public partial class Döviz_Uygulama : Form
    {
        public Döviz_Uygulama()
        {
            InitializeComponent();
        }

        SqlConnection baglantı = new SqlConnection("Data Source=DESKTOP-SK0HNP2\\SQLEXPRESS;Initial Catalog=DbDoviz;Integrated Security=True");

        private void Kasa()
        {
            //database bağlantısı
            baglantı.Open();
            SqlCommand dovizsat = new SqlCommand("Select * from DOVİZ", baglantı);
            SqlDataReader dr = dovizsat.ExecuteReader();
            while (dr.Read())
            {
                lblkasadolar.Text = dr["DOLAR"].ToString();
                lbleurokasa.Text = dr["EURO"].ToString();
                lblkasalira.Text = dr["TL"].ToString();
            }
                 
            baglantı.Close();

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            string bugun = "https://www.tcmb.gov.tr/kurlar/today.xml";
            var xmldosya = new XmlDocument();
            xmldosya.Load(bugun);
            //Dolar
            string dolaralis = xmldosya.SelectSingleNode("Tarih_Date/Currency[@Kod='USD']/BanknoteBuying").InnerXml;
            string dolarsatis = xmldosya.SelectSingleNode("Tarih_Date/Currency[@Kod='USD']/BanknoteSelling").InnerXml;
            linklbldolaralıs.Text = dolaralis;
            linklbldolarsatıs.Text = dolarsatis;
            //Euro
            string euroalis = xmldosya.SelectSingleNode("Tarih_Date/Currency[@Kod='EUR']/BanknoteBuying").InnerXml;
            string eurosatis = xmldosya.SelectSingleNode("Tarih_Date/Currency[@Kod='EUR']/BanknoteSelling").InnerXml;
            linklbleuroalıs.Text = euroalis;
            linklbleurosatıs.Text = eurosatis;
            //Pund
            string pundalis = xmldosya.SelectSingleNode("Tarih_Date/Currency[@Kod='GBP']/BanknoteBuying").InnerXml;
            string pundsatis = xmldosya.SelectSingleNode("Tarih_Date/Currency[@Kod='GBP']/BanknoteSelling").InnerXml;
            linklblpoundalıs.Text = pundalis;
            linklblpoundsatıs.Text = pundsatis;
            Kasa();
        }

        private void linklbldolaralıs_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            txtkur2.Text = linklbldolaralıs.Text;    
        }
        private void linklbleurosatıs_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            txtkurberkay.Text = linklbleurosatıs.Text;
        }

        private void linklblpoundsatıs_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            txtkurberkay.Text = linklblpoundsatıs.Text;
        }

        private void linklbldolarsatıs_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            txtkurberkay.Text = linklbldolarsatıs.Text;
        }
        private void linklbleuroalıs_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            txtkur2.Text = linklbleuroalıs.Text; 
        }

        private void linklblpoundalıs_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            txtkur2.Text = linklblpoundalıs.Text;    
        }

        private void txtkur2_TextChanged_1(object sender, EventArgs e)
        {
            txtkur2.Text = txtkur2.Text.Replace(".", ",");

        }

        private void txtkurberkay_TextChanged(object sender, EventArgs e)
        {
            txtkurberkay.Text = txtkurberkay.Text.Replace(".", ",");
        }

        private void btndovizver_Click(object sender, EventArgs e)
        {
            double kur, tutar,kalan;
            int miktar;
            kur = Convert.ToDouble(txtkurberkay.Text);
            miktar = Convert.ToInt32(txtmiktar.Text);
            tutar = Convert.ToInt32(miktar / kur);
            txttutar.Text = tutar.ToString();
            kalan = miktar % kur;
            txtkalan.Text = kalan.ToString();   
            baglantı.Open();
            if (txtkurberkay.Text == linklbldolarsatıs.Text.Replace(".", ","))
            {
                lblkasadolar.Text = (Convert.ToDouble(lblkasadolar.Text) - tutar).ToString();
                lblkasalira.Text = (Convert.ToDouble(lblkasalira.Text) + miktar).ToString();
            }
            if (txtkurberkay.Text == linklbleurosatıs.Text.Replace(".", ","))
            {
                lbleurokasa.Text = (Convert.ToDouble(lbleurokasa.Text) - tutar).ToString();
                lblkasalira.Text = (Convert.ToDouble(lblkasalira.Text) + miktar).ToString();
            }
            SqlCommand guncelle = new SqlCommand("insert into DOVİZ (Dolar,Euro,TL) values (@p1,@p2,@p3)", baglantı);
            guncelle.Parameters.AddWithValue("@p1", Convert.ToDouble(lblkasadolar.Text));
            guncelle.Parameters.AddWithValue("@p2", Convert.ToDouble(lbleurokasa.Text));
            guncelle.Parameters.AddWithValue("@p3", Convert.ToDouble(lblkasalira.Text));

            guncelle.ExecuteNonQuery();
            baglantı.Close();
            Kasa();


        }

        private void btndövizal_Click(object sender, EventArgs e)
        {
            // Döviz alım Tl verme
            double kur, tutar;
            int miktar;
            kur = Convert.ToDouble(txtkur2.Text);
            miktar = Convert.ToInt32(txtmiktar2.Text);
            tutar = (miktar * kur);
            txttutar2.Text = tutar.ToString() + "  TL";
            if (txtkurberkay.Text == linklbldolarsatıs.Text.Replace(".", ","))
            {
               lblkasadolar.Text    = (Convert.ToDouble(lblkasadolar.Text) + miktar).ToString();
               lblkasalira.Text = (Convert.ToDouble(lblkasalira.Text) - tutar).ToString();
            }
            if (txtkurberkay.Text == linklbleurosatıs.Text.Replace(".", ","))
            {
                lbleurokasa.Text = (Convert.ToDouble(lbleurokasa.Text) + miktar).ToString();
                lblkasalira.Text = (Convert.ToDouble(lblkasalira.Text) - tutar).ToString();
            }
            baglantı.Open();

            SqlCommand guncelle = new SqlCommand("insert into DOVİZ (Dolar,Euro,TL) values (@p1,@p2,@p3)", baglantı);
            guncelle.Parameters.AddWithValue("@p1", Convert.ToDouble(lblkasadolar.Text));
            guncelle.Parameters.AddWithValue("@p2", Convert.ToDouble(lbleurokasa.Text));
            guncelle.Parameters.AddWithValue("@p3", Convert.ToDouble(lblkasalira.Text));

            guncelle.ExecuteNonQuery();
            baglantı.Close();
            Kasa();

        }


    }
}
