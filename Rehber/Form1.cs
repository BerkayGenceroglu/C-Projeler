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
namespace Rehber
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection baglantı = new SqlConnection("Data Source=DESKTOP-SK0HNP2\\SQLEXPRESS;Initial Catalog=Rehber;Integrated Security=True");
        void listele()
        {
            SqlDataAdapter da = new SqlDataAdapter("Select * from Rehber", baglantı);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;

        }
        void temizle() 
        {
            txtid.Text = "";
            txtad.Text = "";
            txtsoyad.Text = "";
            txttel.Text = "";
            txtmail.Text = "";  
            txtfoto.Text = "";
            txtad.Focus();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'rehberDataSet.Rehber' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.rehberTableAdapter.Fill(this.rehberDataSet.Rehber);
            listele();


        }

        private void btndosya_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            txtfoto.Text = openFileDialog1.FileName;
            pictureBox1.ImageLocation = txtfoto.Text;
        }

        private void btnekle_Click(object sender, EventArgs e)
        {
            baglantı.Open();
            SqlCommand ekle = new SqlCommand("insert into Rehber (Ad,Soyad,Telefon,MAIl,Fotograf) values (@p1,@p2,@p3,@p4,@p5)", baglantı); 
            ekle.Parameters.AddWithValue("@p1", txtad.Text);
            ekle.Parameters.AddWithValue("@p2", txtsoyad.Text);
            ekle.Parameters.AddWithValue("@p3", txttel.Text);
            ekle.Parameters.AddWithValue("@p4", txtmail.Text);
            ekle.Parameters.AddWithValue("@p5", txtfoto.Text);
            ekle.ExecuteNonQuery();
            baglantı.Close();
            MessageBox.Show("Kişi Eklendi","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information);
            listele();
            temizle();

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            txtid.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            txtad.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            txtsoyad.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            txttel.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            txtmail.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            pictureBox1.ImageLocation= dataGridView1.Rows[secilen].Cells[5].Value.ToString();
            txtfoto.Text = dataGridView1.Rows[secilen].Cells[5].Value.ToString();

        }

        private void btnsil_Click(object sender, EventArgs e)
        {
           
            DialogResult cıkıs = new DialogResult();
            cıkıs =MessageBox.Show("Devam Etmek İstiyor Musunuz ?","UYARI", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (cıkıs == DialogResult.Yes)
            {
                baglantı.Open();
                SqlCommand sil = new SqlCommand("Delete from Rehber where ID=" + txtid.Text, baglantı);
                sil.ExecuteNonQuery();
                baglantı.Close();
                MessageBox.Show("Kişi başarıyla silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                listele();
                temizle();
            }
            else
            {
                MessageBox.Show("İşlem iptal edildi.");
            }
           

        }

        private void btntemizle_Click(object sender, EventArgs e)
        {
            temizle();
        }

        private void btngüncelle_Click(object sender, EventArgs e)
        {
            baglantı.Open();
            SqlCommand guncelle = new SqlCommand("update Rehber set Ad=@p1,Soyad=@p2,Telefon=@p3,MAIl=@p4,Fotograf=@p5 where ID=@p6", baglantı);
            guncelle.Parameters.AddWithValue("@p1", txtad.Text);
            guncelle.Parameters.AddWithValue("@p2", txtsoyad.Text);
            guncelle.Parameters.AddWithValue("@p3", txttel.Text);
            guncelle.Parameters.AddWithValue("@p4", txtmail.Text);
            guncelle.Parameters.AddWithValue("@p5", txtfoto.Text);
            guncelle.Parameters.AddWithValue("@p6", txtid.Text);
            guncelle.ExecuteNonQuery();
            baglantı.Close();
            MessageBox.Show("Kişi başarıyla güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            listele();
            temizle();  
        }
    }
}
