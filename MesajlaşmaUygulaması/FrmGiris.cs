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
namespace MesajlaşmaUygulaması
{
    public partial class FrmGiris : Form
    {
        public FrmGiris()
        {
            InitializeComponent();
        }
        SqlConnection baglantı = new SqlConnection("Data Source=DESKTOP-SK0HNP2\\SQLEXPRESS;Initial Catalog=MesajUygulama;Integrated Security=True");

        private void btngirisyap_Click(object sender, EventArgs e)
        {
            baglantı.Open();
            SqlCommand komut1 = new SqlCommand("select * from TBLKISILER where NUMARA=@P1 and SIFRE=@P2", baglantı);
            komut1.Parameters.AddWithValue("@P1", msknumara.Text);
            komut1.Parameters.AddWithValue("@P2", txtsifre.Text);
            SqlDataReader dr = komut1.ExecuteReader();
            if (dr.Read())
            {
                FrmMesajBilgileri fr = new FrmMesajBilgileri();
                fr.numara = msknumara.Text;
                fr.Show();
            }
            else
            {
                MessageBox.Show("Hatalı Giriş Yaptınız,Lütfen Tekrar Deneyiniz");
            }
            baglantı.Close();
        }
    }
}
