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

namespace MesajlaşmaUygulaması
{
    public partial class FrmMesajBilgileri : Form
    {
        public FrmMesajBilgileri()
        {
            InitializeComponent();
        }
        SqlConnection baglantı = new SqlConnection("Data Source=DESKTOP-SK0HNP2\\SQLEXPRESS;Initial Catalog=MesajUygulama;Integrated Security=True");

        public string numara;

        void gelenkutusu()
        {
            SqlDataAdapter da = new SqlDataAdapter("select * from TBLMESAJLAR where ALICI="+ numara , baglantı);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            dataGridView1.RowHeadersVisible = false;

        }
        void gidenkutusu()
        {
            SqlDataAdapter da2 = new SqlDataAdapter("select * from TBLMESAJLAR where GONDEREN=" + numara, baglantı);
            DataTable dt2 = new DataTable();
            da2.Fill(dt2);
            dataGridView2.DataSource = dt2;
            dataGridView2.RowHeadersVisible = false;

        }

        void adsoyad()
        {
            baglantı.Open();
            SqlCommand isim = new SqlCommand("select AD,SOYAD from TBLKISILER where NUMARA=" + numara, baglantı);
            SqlDataReader dr = isim.ExecuteReader();
            if (dr.Read())
            {
               lblisimsoyisim.Text = dr[0] + " " + dr[1];   
            }
            baglantı.Close();

        }
        private void FrmMesajBilgileri_Load(object sender, EventArgs e)
        {
            lblnumara.Text = numara;
            gelenkutusu();
            gidenkutusu();
            adsoyad();

        }

        private void btngonder_Click(object sender, EventArgs e)
        {
            baglantı.Open();
            SqlCommand komut = new SqlCommand("insert into TBLMESAJLAR (GONDEREN,ALICI,BASLIK,ICERIK) values (@P1,@P2,@P3,@P4)", baglantı);
            komut.Parameters.AddWithValue("@P1", numara);
            komut.Parameters.AddWithValue("@P2", mskalıcınumara.Text);
            komut.Parameters.AddWithValue("@P3", txtbaslık.Text);
            komut.Parameters.AddWithValue("@P4", richtxtmesaj.Text);
            komut.ExecuteNonQuery();
            baglantı.Close();
            MessageBox.Show("Mesajınız Gönderildi");
            gidenkutusu();

        }
    }
}
