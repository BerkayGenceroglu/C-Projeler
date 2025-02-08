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

namespace Film_Proje
{
    public partial class FlimPanel : Form
    {
        public FlimPanel()
        {
            InitializeComponent();
        }
        SqlConnection baglantı = new SqlConnection("Data Source=DESKTOP-SK0HNP2\\SQLEXPRESS;Initial Catalog=FlimArsivi;Integrated Security=True");
        
        void flim()
        {
            SqlDataAdapter da = new SqlDataAdapter("Select * From TBLFILM", baglantı);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            dataGridView1.RowHeadersVisible = false;

        }
        private void FlimPanel_Load(object sender, EventArgs e)
        {
            flim(); 
        }

        private void btnkaydet_Click(object sender, EventArgs e)
        {
            baglantı.Open();    
            SqlCommand ekle = new SqlCommand("insert into TBLFILM (AD,KATEGORI,LINK,DURUM) values (@p1,@p2,@p3,@p4)",baglantı);
            ekle.Parameters.AddWithValue("@p1", txtad.Text);
            ekle.Parameters.AddWithValue("@p2", txtKategori.Text);
            ekle.Parameters.AddWithValue("@p3",txtlink.Text);
            ekle.Parameters.AddWithValue("@p4", "False");
            ekle.ExecuteNonQuery();
            MessageBox.Show("Film Eklendi","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information);    
            baglantı.Close();
            flim();
            txtad.Text = "";
            txtKategori.Text = "";
            txtlink.Text = "";
            txtad.Focus();

        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            string link = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            webBrowser1.Navigate(link); 
        }

        Random random = new Random();   
        private void button3_Click(object sender, EventArgs e)
        {
            int sayı1 = random.Next(1, 200);
            int sayı2 = random.Next(1, 200);   
            int sayı3 = random.Next(1, 200);

            this.BackColor = Color.FromArgb(sayı1, sayı2, sayı3);
        }

        private void button1_Click(object sender, EventArgs e)
        {
                // Ekran boyutunu alıyoruz
                if (this.WindowState == FormWindowState.Normal)
                {
                    this.WindowState = FormWindowState.Maximized; // Tam ekran yapıyoruz
                }
                else
                {
                    this.WindowState = FormWindowState.Normal; // Normale döndürüyoruz
                }
        }
    }
}
