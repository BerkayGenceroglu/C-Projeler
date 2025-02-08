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

namespace PastaneMaliyet
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection baglantı = new SqlConnection("Data Source=DESKTOP-SK0HNP2\\SQLEXPRESS;Initial Catalog=PastaneMaliyet;Integrated Security=True");

        void malzemelistele()
        {
            SqlDataAdapter malzeme = new SqlDataAdapter("Select * from TBLMALZEME", baglantı);
            DataTable dt = new DataTable();
            malzeme.Fill(dt);
            dataGridView1.DataSource = dt;
            dataGridView1.RowHeadersVisible = false;
        }
        void kasa()
        {
            SqlDataAdapter malzeme = new SqlDataAdapter("Select * from TBLKASA", baglantı);
            DataTable dt = new DataTable();
            malzeme.Fill(dt);
            dataGridView1.DataSource = dt;
            dataGridView1.RowHeadersVisible = false;
        }
        void fırınlistele()
        {
            SqlDataAdapter malzeme = new SqlDataAdapter("execute berkay",baglantı);
            DataTable dt = new DataTable();
            malzeme.Fill(dt);
            dataGridView1.DataSource = dt;
            dataGridView1.RowHeadersVisible = false;

        }
        void ürünlistele()
        {
            SqlDataAdapter malzeme = new SqlDataAdapter("Select * from TBLURUN", baglantı);
            DataTable dt = new DataTable();
            malzeme.Fill(dt);
            dataGridView1.DataSource = dt;
            dataGridView1.RowHeadersVisible = false;
        }
        void urunler()
        {
            SqlDataAdapter da = new SqlDataAdapter("select * from TBLURUN", baglantı);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cmburun.DataSource= dt;
            cmburun.DisplayMember = "AD";
            cmburun.ValueMember = "URUNID";
        }
        void malzemeler()
        {
            SqlDataAdapter da = new SqlDataAdapter("select * from TBLMALZEME",baglantı);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cmbmalzeme.DataSource= dt;
            cmbmalzeme.DisplayMember = "AD";
            cmbmalzeme.ValueMember = "ID";
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            malzemelistele();
            urunler();
            malzemeler();
            

        }

        private void btnmalzemelistesi_Click(object sender, EventArgs e)
        {
            malzemelistele();
        }

        private void btnurunlistesi_Click(object sender, EventArgs e)
        {
            ürünlistele();
        }

        private void btnkasa_Click(object sender, EventArgs e)
        {
            kasa();
        }

        private void btncıkıs_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnmalzemeekle_Click(object sender, EventArgs e)
        {
            baglantı.Open();
            SqlCommand ekle = new SqlCommand("insert into TBLMALZEME (AD,STOK,FIYAT,NOTLAR) values (@p1,@p2,@p3,@p4)", baglantı);
            ekle.Parameters.AddWithValue("@p1", txtmalzemead.Text);
            ekle.Parameters.AddWithValue("@p2", txtmalzemestok.Text);
            ekle.Parameters.AddWithValue("@p3", txtmalzemefiyat.Text);
            ekle.Parameters.AddWithValue("@p4", txtmalzemenot.Text);
            ekle.ExecuteNonQuery();
            baglantı.Close();
            MessageBox.Show("Malzeme ekleme işlemi başarılı");
            malzemelistele();
        }

        private void btnürünekle_Click(object sender, EventArgs e)
        {
            baglantı.Open();
            SqlCommand ekle = new SqlCommand("insert into TBLURUN (AD,STOK,MFIYAT,SFIYAT) values (@p1,@p2,@p3,@p4)", baglantı);
            ekle.Parameters.AddWithValue("@p1", txtürünad.Text);
            ekle.Parameters.AddWithValue("@p2", txtürünstok.Text);
            ekle.Parameters.AddWithValue("@p3", decimal.Parse(txtmfiyat.Text));
            ekle.Parameters.AddWithValue("@p4", decimal.Parse(txtsfiyat.Text));
            ekle.ExecuteNonQuery();
            baglantı.Close();
            MessageBox.Show("Ürün ekleme işlemi başarılı");
            ürünlistele();
        }

        

        private void btnfırın_Click(object sender, EventArgs e)
        {
            fırınlistele();
        }

        private void btnmaliyet_Click(object sender, EventArgs e)
        {
            baglantı.Open();
            SqlCommand komut = new SqlCommand("insert into TBLFIRIN (URUNID,MALZEMEID,MIKTAR,MALIYET) values (@p1,@p2,@p3,@p4)",baglantı);
            komut.Parameters.AddWithValue("@p1", cmburun.SelectedValue);
            komut.Parameters.AddWithValue("@p2", cmbmalzeme.SelectedValue);
            komut.Parameters.AddWithValue("@p3",decimal.Parse(txtfırınmıktar.Text));
            komut.Parameters.AddWithValue("@p4", decimal.Parse(txtfırınmaliyet.Text));
            komut.ExecuteNonQuery();
            baglantı.Close();
            MessageBox.Show("Ekleme işlemi başarılı");

            listBox1.Items.Add(cmbmalzeme.Text + " " + txtfırınmaliyet.Text);
        }

        private void txtfırınmıktar_TextChanged(object sender, EventArgs e)
        {
            double maliyet;
            if (txtfırınmıktar.Text == "")
            {
                txtfırınmıktar.Text = "0";
            }
            baglantı.Open();
            SqlCommand komut = new SqlCommand("select * from tblmalzeme where ID=@p1", baglantı);
            komut.Parameters.AddWithValue("@p1",cmbmalzeme.SelectedValue.ToString());
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                txtfırınmaliyet.Text = dr[3].ToString();
            }
            maliyet = Convert.ToDouble(txtfırınmaliyet.Text) / 1000 * Convert.ToDouble(txtfırınmıktar.Text);
            txtfırınmaliyet.Text = maliyet.ToString();
            baglantı.Close();

        }
    }
}
