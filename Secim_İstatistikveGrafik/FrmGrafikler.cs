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

namespace Secim_İstatistikveGrafik
{
    public partial class FrmGrafikler : Form
    {
        public FrmGrafikler()
        {
            InitializeComponent();
        }

       
        SqlConnection br = new SqlConnection("Data Source=DESKTOP-SK0HNP2\\SQLEXPRESS;Initial Catalog=DbSecimProje;Integrated Security=True");
        private void FrmGrafikler_Load(object sender, EventArgs e)
        {
            //İLÇE ADLARINI Comboboxa Çekme 
            br.Open();
            SqlCommand listele = new SqlCommand("select ILCEAD from TBLILCE", br);
            SqlDataReader dr = listele.ExecuteReader(); 
            while (dr.Read())
            {
               cmbılce.Items.Add(dr[0]);
            }
            br.Close();


            //Grafiğe Sonuçları Çekme
            br.Open();
            SqlCommand grafik = new SqlCommand("Select Sum(APARTI),Sum(BPARTI),Sum(CPARTI),Sum(DPARTI),Sum(EPARTI) from TBLILCE", br);
            SqlDataReader dr2 = grafik.ExecuteReader(); 
            while (dr2.Read())
            {
                chart1.Series["Partiler"].Points.AddXY("A Parti", dr2[0]);
                chart1.Series["Partiler"].Points.AddXY("B Parti", dr2[1]);
                chart1.Series["Partiler"].Points.AddXY("C Parti", dr2[2]);
                chart1.Series["Partiler"].Points.AddXY("D Parti", dr2[3]);
                chart1.Series["Partiler"].Points.AddXY("E Parti", dr2[4]);
            }
            br.Close(); 

            
        }

        private void cmbılce_SelectedIndexChanged(object sender, EventArgs e)
        {
            br.Open();
            SqlCommand goster = new SqlCommand("Select * from TBLILCE where ILCEAD=@p1", br);
            goster.Parameters.AddWithValue("@p1", cmbılce.Text);
            SqlDataReader dr3 = goster.ExecuteReader();
            while (dr3.Read())
            {
                int s1, s2, s3, s4, s5;
                s1 = int.Parse(dr3[2].ToString());
                s2 = int.Parse(dr3[3].ToString());
                s3 = int.Parse(dr3[4].ToString());
                s4 = int.Parse(dr3[5].ToString());
                s5 = int.Parse(dr3[6].ToString());

                progress1.Maximum = s1 + s2 + s3 + s4 + s5;
                progressBarB.Maximum = s1 + s2 + s3 + s4 + s5;
                progressBarC.Maximum = s1 + s2 + s3 + s4 + s5;
                progressBarD.Maximum = s1 + s2 + s3 + s4 + s5;
                progressBarE.Maximum = s1 + s2 + s3 + s4 + s5;

                // Progress bara ekleme
                progress1.Value = int.Parse(dr3[2].ToString());
                progressBarB.Value = int.Parse(dr3[3].ToString());
                progressBarC.Value = int.Parse(dr3[4].ToString());
                progressBarD.Value = int.Parse(dr3[5].ToString());
                progressBarE.Value = int.Parse(dr3[6].ToString());

                // Progress bar yanına yazma
                lblaparti.Text = dr3[2].ToString();
                lblbparti.Text = dr3[3].ToString();
                lblcparti.Text = dr3[4].ToString();
                lbldparti.Text = dr3[5].ToString();
                lbleparti.Text = dr3[6].ToString();
            }
            br.Close(); 
        }
    }
}
