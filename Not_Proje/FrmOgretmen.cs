using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Not_Proje
{
    public partial class FrmOgretmen : Form
    {
        public FrmOgretmen()
        {
            InitializeComponent();
        }
        SqlConnection baglantı = new SqlConnection("Data Source=DESKTOP-SK0HNP2\\SQLEXPRESS;Initial Catalog=DbNotKayıt;Integrated Security=True;");
        public void listele()
        {
            this.tBLNOTTableAdapter.Fill(this.dbNotKayıtDataSet.TBLNOT);
        }
        private void FrmOgretmen_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'dbNotKayıtDataSet.TBLNOT' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            listele();
        }

        private void btnkaydet_Click(object sender, EventArgs e)
        {
            baglantı.Open();
            SqlCommand ekle = new SqlCommand("insert into TBLNOT (OGRNUMARA, OGRAD, OGRSOYAD) values (@p1, @p2, @p3)", baglantı);
            ekle.Parameters.AddWithValue("@p1", msknumber.Text);
            ekle.Parameters.AddWithValue("@p2", txtad.Text); 
            ekle.Parameters.AddWithValue("@p3", txtsoyad.Text);
            ekle.ExecuteNonQuery();
            baglantı.Close();
            MessageBox.Show(Text = "Öğrenci Eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);   
            listele();  
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            msknumber.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            txtad.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            txtsoyad.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            txtsınav1.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            txtsınav2.Text = dataGridView1.Rows[secilen].Cells[5].Value.ToString();
            txtsınav3.Text = dataGridView1.Rows[secilen].Cells[6].Value.ToString();
        }

        private void btnguncelle_Click(object sender, EventArgs e)
        {
            double ortalama;
            int s1, s2, s3;
            string durum;
            s1 = Convert.ToInt16(txtsınav1.Text);
            s2 = Convert.ToInt16(txtsınav2.Text);
            s3 = Convert.ToInt16(txtsınav3.Text);
            ortalama = (s1 + s2 + s3) / 3;
            lblort.Text = ortalama.ToString();
            if (ortalama >= 50)
            {
                durum = "True";
            }
            else
            {
                durum = "False";
            }
           

            lblgecen.Text = dbNotKayıtDataSet.TBLNOT.Count(x => x.DURUM == true).ToString();
            lblkalan     .Text = dbNotKayıtDataSet.TBLNOT.Count(x => x.DURUM == false).ToString();


            baglantı.Open();    
            SqlCommand update = new SqlCommand("update TBLNOT set OGRS1 = @p1, OGRS2 = @p2, OGRS3 = @p3, ORTALAMA = @p4 ,DURUM=@p5 where OGRNUMARA=@p6", baglantı);
            update.Parameters.AddWithValue("@p1", txtsınav1.Text);
            update.Parameters.AddWithValue("@p2", txtsınav2.Text);
            update.Parameters.AddWithValue("@p3", txtsınav3.Text);
            update.Parameters.AddWithValue("@p4", decimal.Parse(lblort.Text));
            update.Parameters.AddWithValue("@p5", durum);
            update.Parameters.AddWithValue("@p6", msknumber.Text);
            update.ExecuteNonQuery();
            baglantı.Close();
            MessageBox.Show("Güncelleme Gerçekleşti");
            listele();  
        }

        private void lblgecen_Click(object sender, EventArgs e)
        {

        }
    }
}
