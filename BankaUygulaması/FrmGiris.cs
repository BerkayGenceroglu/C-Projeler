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
    public partial class FrmGiris : Form
    {
        public FrmGiris()
        {
            InitializeComponent();
        }

        private void linklbl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmKayıt fr = new FrmKayıt();   
            fr.Show();
        }
        SqlConnection baglantı = new SqlConnection("Data Source=DESKTOP-SK0HNP2\\SQLEXPRESS;Initial Catalog=Banka;Integrated Security=True;");
        private void FrmGiris_Load(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            baglantı.Open();
            SqlCommand select = new SqlCommand("select * from TBLKISILER where HESAPNO=@p1 and SIFRE=@p2", baglantı);
            select.Parameters.AddWithValue("@p1", mskhesap.Text);
            select.Parameters.AddWithValue("@p2", txtsıfre.Text);
            SqlDataReader dr = select.ExecuteReader();
            if (dr.Read())
            {
                FrmHesap fr = new FrmHesap();
                fr.hesapno = mskhesap.Text;
                fr.Show();
            }
            else
            {
                MessageBox.Show("Hatalı Giriş Yaptınız");
            }
            baglantı.Close();
        }
    }
}
