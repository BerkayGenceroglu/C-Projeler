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
using System.Linq.Expressions;
using System.CodeDom;
namespace FormÜzerindeSQLsorguları
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        void dbgetirme()
        {
            SqlConnection baglantı = new SqlConnection("Data Source=DESKTOP-SK0HNP2\\SQLEXPRESS;Initial Catalog=master;Integrated Security=True");
            baglantı.Open();    
            SqlCommand db = new SqlCommand("select name from sys.databases", baglantı);
            SqlDataReader dr = db.ExecuteReader();
            while (dr.Read())
            {
                cmbveritabanı.Items.Add(dr[0].ToString());
            }
            baglantı.Close();
        }
        void tablegetirme()
        {
            SqlConnection baglantı = new SqlConnection("Data Source=DESKTOP-SK0HNP2\\SQLEXPRESS;Initial Catalog=" +cmbveritabanı.Text+ ";Integrated Security=True");
            baglantı.Open();
            SqlCommand db = new SqlCommand("select * from sys.tables", baglantı);
            SqlDataReader dr1 = db.ExecuteReader();
            while (dr1.Read())
            {
                cmbtablo.Items.Add(dr1[0].ToString());
            }
            baglantı.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dbgetirme();
            SqlConnection bgl = new SqlConnection("Data Source=DESKTOP-SK0HNP2\\SQLEXPRESS;Initial Catalog="+ cmbveritabanı.Text + ";Integrated Security=True");
        }

        private void cmbveritabanı_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbtablo.Items.Clear();
            tablegetirme();
        }

        private void btnlistele_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection bgl = new SqlConnection("Data Source=DESKTOP-SK0HNP2\\SQLEXPRESS;Initial Catalog=" + cmbveritabanı.Text + ";Integrated Security=True");
                bgl.Open();
                SqlCommand listele = new SqlCommand(richTextBox1.Text, bgl);
                listele.ExecuteNonQuery();
                bgl.Close();
                SqlDataAdapter da = new SqlDataAdapter("select * from " + cmbtablo.Text, bgl);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                dataGridView1.RowHeadersVisible = false;
            }
            catch (Exception)
            {
                MessageBox.Show("Hatalı Sorgu Girdiniz");
            }

        }
       
        private void btnekle_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection bgl = new SqlConnection("Data Source=DESKTOP-SK0HNP2\\SQLEXPRESS;Initial Catalog=" + cmbveritabanı.Text + ";Integrated Security=True");
                bgl.Open();
                SqlCommand listele = new SqlCommand(richTextBox1.Text, bgl);
                listele.ExecuteNonQuery();
                bgl.Close();
                SqlDataAdapter da = new SqlDataAdapter("select * from " + cmbtablo.Text, bgl);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                dataGridView1.RowHeadersVisible = false;
            }
            catch (Exception)
            {
                MessageBox.Show("Hatalı Sorgu Girdiniz");
            }
        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection bgl = new SqlConnection("Data Source=DESKTOP-SK0HNP2\\SQLEXPRESS;Initial Catalog=" + cmbveritabanı.Text + ";Integrated Security=True");
                bgl.Open();
                SqlCommand listele = new SqlCommand(richTextBox1.Text, bgl);
                listele.ExecuteNonQuery();
                bgl.Close();
                SqlDataAdapter da = new SqlDataAdapter("select * from " + cmbtablo.Text, bgl);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                dataGridView1.RowHeadersVisible = false;
            }
            catch (Exception)
            {
                MessageBox.Show("Hatalı Sorgu Girdiniz");
            }
        }

        private void btnguncelle_Click(object sender, EventArgs e)
        {

            try
            {
                SqlConnection bgl = new SqlConnection("Data Source=DESKTOP-SK0HNP2\\SQLEXPRESS;Initial Catalog=" + cmbveritabanı.Text + ";Integrated Security=True");
                bgl.Open();
                SqlCommand listele = new SqlCommand(richTextBox1.Text, bgl);
                listele.ExecuteNonQuery();
                bgl.Close();
                SqlDataAdapter da = new SqlDataAdapter("select * from " + cmbtablo.Text, bgl);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                dataGridView1.RowHeadersVisible = false;
            }
            catch (Exception)
            {
                MessageBox.Show("Hatalı Sorgu Girdiniz");
            }
        }
    }
}
