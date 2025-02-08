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

namespace Not_Proje
{
    public partial class OgrenciNot : Form
    {
        public OgrenciNot()
        {
            InitializeComponent();
        }

        public string numara;
        SqlConnection baglantı = new SqlConnection("Data Source=DESKTOP-SK0HNP2\\SQLEXPRESS;Initial Catalog=DbNotKayıt;Integrated Security=True;");

        private void OgrenciNot_Load(object sender, EventArgs e)
        {
            lblnumara.Text = numara;
            baglantı.Open();
            SqlCommand komut = new SqlCommand("Select * From TBLNOT where OGRNUMARA=@p1", baglantı);   
            komut.Parameters.AddWithValue("@p1", numara);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                lbladsoyad.Text = dr[2].ToString() + " " + dr[3].ToString();    
                lblsınav1.Text = dr[4].ToString();
                lblsınav2.Text = dr[5].ToString();
                lblsınav3.Text = dr[6].ToString();
                lblort.Text = dr[7].ToString();
                lbldurum.Text = dr[8].ToString();
            }
            baglantı.Close();
        }
    }
}
