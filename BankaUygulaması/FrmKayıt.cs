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

namespace BankaUygulaması
{
    public partial class FrmKayıt : Form
    {
        public FrmKayıt()
        {
            InitializeComponent();
        }
        SqlConnection baglantı = new SqlConnection("Data Source=DESKTOP-SK0HNP2\\SQLEXPRESS;Initial Catalog=Banka;Integrated Security=True;");
        private void btnkayıtol_Click(object sender, EventArgs e)
        {
            baglantı.Open();
           SqlCommand ekle = new SqlCommand("insert into TBLKISILER (AD,SOYAD,TC,TELEFON,HESAPNO,SIFRE) values (@p1,@p2,@p3,@p4,@p5,@p6)",baglantı);
            ekle.Parameters.AddWithValue("@p1", txtAd.Text);
            ekle.Parameters.AddWithValue("@p2", txtsoyad.Text);
            ekle.Parameters.AddWithValue("@p3", mtxttc.Text);
            ekle.Parameters.AddWithValue("@p4", mtxtnumber.Text);
            ekle.Parameters.AddWithValue("@p5", mtexthesap.Text);
            ekle.Parameters.AddWithValue("@p6", txtsıfre.Text);
            ekle.ExecuteNonQuery();
            baglantı.Close();
            MessageBox.Show("Kaydınız Başarıyla Yapılmıştır","İşlem Başarılı");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int sayı = rnd.Next(100000, 999999);
            mtexthesap.Text = sayı.ToString();
        }
    }
}
