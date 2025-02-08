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
namespace EtütDers
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection baglantı = new SqlConnection("Data Source=DESKTOP-SK0HNP2\\SQLEXPRESS;Initial Catalog=EtütSistemi;Integrated Security=True;");

        void listele()
        {
            SqlDataAdapter da = new SqlDataAdapter("select * from TBLDERS", baglantı);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cmbders.ValueMember = "DERSID";
            cmbders.DisplayMember = "DERSAD";
            cmbders.DataSource = dt;
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            listele();
            etütlistesi();
            ogretmenlistesi();
        }

        private void cmbders_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            SqlDataAdapter da = new SqlDataAdapter("SELECT OGRTID,(AD +' '+SOYAD) AS ADSOYAD FROM TBLOGRETMEN WHERE DERSID=" + cmbders.SelectedValue, baglantı);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cmbogretmen.ValueMember= "OGRTID";
            cmbogretmen.DisplayMember = "ADSOYAD";
            cmbogretmen.DataSource = dt;

        }

        void etütlistesi()
        {
            SqlDataAdapter da = new SqlDataAdapter("execute komut", baglantı);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            dataGridView1.RowHeadersVisible = false;
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                bool durum = Convert.ToBoolean(dt.Rows[i]["DURUM"]);
                if ( durum == true)
                {
                    dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.Red;
                }
                else
                {
                    dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.Green;
                }
            }
        }


        private void btnOlustur_Click(object sender, EventArgs e)
        {
                baglantı.Open();
                SqlCommand da = new SqlCommand("INSERT INTO TBLETUT (DERSID, OGRETMENID, TARİH, SAAT,DURUM) VALUES (@p1, @p2, @p3, @p4,@p5)", baglantı);
                da.Parameters.AddWithValue("@p1", cmbders.SelectedValue);
                da.Parameters.AddWithValue("@p2", cmbogretmen.SelectedValue);
                da.Parameters.AddWithValue("@p3", msktarih.Text);
                da.Parameters.AddWithValue("@p4", msksaat.Text);
                da.Parameters.AddWithValue("@p5", false);
            da.ExecuteNonQuery();
                baglantı.Close();

                MessageBox.Show("Etüt Oluşturuldu");
                etütlistesi();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            txtId.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();

        }

        private void btnetütver_Click(object sender, EventArgs e)
        {
            baglantı.Open();
            SqlCommand etut = new SqlCommand("UPDATE TBLETUT SET OGRENCIID=@p1, DURUM=@p2 WHERE ID=@p3", baglantı);
            etut.Parameters.AddWithValue("@p3", txtId.Text);
            etut.Parameters.AddWithValue("@p2", "1");
            etut.Parameters.AddWithValue("@p1", txtogrencinumara.Text);
            etut.ExecuteNonQuery();
            baglantı.Close();
            MessageBox.Show("Etüt Verildi");
            etütlistesi();
        }

        private void btnfotografyukle_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            pictureBox1.ImageLocation = openFileDialog1.FileName;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            baglantı.Open();
            SqlCommand ekle = new SqlCommand("insert into TBLOGRENCI (AD,SOYAD,FOTOGRAF,SINIF,TELEFON,MAIL) values            (@p1,@p2,@p3,@p4,@p5,@p6)",baglantı);
            ekle.Parameters.AddWithValue("@p1", txtad.Text);
            ekle.Parameters.AddWithValue("@p2", txtsoyad.Text);
            ekle.Parameters.AddWithValue("@p3", pictureBox1.ImageLocation);
            ekle.Parameters.AddWithValue("@p4", txtsınıf.Text);
            ekle.Parameters.AddWithValue("@p5", msktelefon.Text);
            ekle.Parameters.AddWithValue("@p6", txtmail.Text);
            ekle.ExecuteNonQuery();
            baglantı.Close();
            MessageBox.Show("Öğrenci başarılı bir şekilde Eklendi");


        }

        private void btndersekle_Click(object sender, EventArgs e)
        {
            baglantı.Open();
            SqlCommand ekle = new SqlCommand("insert into TBLDERS (DERSAD) values (@p1)", baglantı);
            ekle.Parameters.AddWithValue("@p1", txtDers.Text);
            ekle.ExecuteNonQuery();
            baglantı.Close();
            MessageBox.Show("Ders başarılı bir şekilde Eklendi");
        }
        void ogretmenlistesi()
        {
            SqlDataAdapter da = new SqlDataAdapter("select * from TBLDERS", baglantı);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cmbders2.ValueMember = "DERSID";
            cmbders2.DisplayMember = "DERSAD";
            cmbders2.DataSource = dt;

        }
        
        private void btnogretmenekle_Click(object sender, EventArgs e)
        {
            baglantı.Open();
            SqlCommand ekle = new SqlCommand("insert into TBLOGRETMEN (AD,SOYAD,DERSID) values (@p1,@p2,@p3)", baglantı);
            ekle.Parameters.AddWithValue("@p1", txtogrtmenad.Text);
            ekle.Parameters.AddWithValue("@p2", txtogretmensoyad.Text);
            ekle.Parameters.AddWithValue("@p3", cmbders2.SelectedValue);
            ekle.ExecuteNonQuery();
            baglantı.Close();
            MessageBox.Show("Öğretmen başarılı bir şekilde Eklendi");


        }

    }
}
