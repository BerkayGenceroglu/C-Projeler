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
namespace Secim_İstatistikveGrafik
{
    public partial class FrmSonuclar : Form
    {
        public FrmSonuclar()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        SqlConnection br = new SqlConnection("Data Source=DESKTOP-SK0HNP2\\SQLEXPRESS;Initial Catalog=DbSecimProje;Integrated Security=True");
        private void btnoygiris_Click(object sender, EventArgs e)
        {
            br.Open();
            SqlCommand ekle = new SqlCommand("insert into TBLILCE (ILCEAD,APARTI,BPARTI,CPARTI,DPARTI,EPARTI) values (@p1,@p2,@p3,@p4,@p5,@p6)", br);
            ekle.Parameters.AddWithValue("@p1", txtilce.Text);
            ekle.Parameters.AddWithValue("@p2",txtaparti.Text);
            ekle.Parameters.AddWithValue("@p3",txtbparti.Text);
            ekle.Parameters.AddWithValue("@p4",txtcparti.Text);
            ekle.Parameters.AddWithValue("@p5",txtdparti.Text);
            ekle.Parameters.AddWithValue("@p6",txteparti.Text);
            ekle.ExecuteNonQuery();
            br.Close();
            MessageBox.Show("Oy Girişi Yapıldı");
        }

        private void btngrafik_Click(object sender, EventArgs e)
        {
            FrmGrafikler frmGrafikler = new FrmGrafikler();
            frmGrafikler.Show();    
        }

        private void FrmSonuclar_Load(object sender, EventArgs e)
        {

        }
    }
}
