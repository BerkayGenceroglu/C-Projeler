using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;


namespace ExcelTablo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\\Users\\Berkay\\Desktop\\excel1.xls;Extended Properties='Excel 8.0;HDR=YES;IMEX=0';");


        void listele()
        {
            OleDbDataAdapter da = new OleDbDataAdapter("select * from [Sheet1$]", baglanti);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource= dt;

        }

        void ekle()
        {
            baglanti.Open();
            OleDbCommand da = new OleDbCommand("insert into [Sheet1$] (FirstName,LastName,Gender,Country,Age) values (@p1,@p2,@p3,@p4,@p5)",baglanti);
            da.Parameters.AddWithValue("@p1", txtfirstname.Text);
            da.Parameters.AddWithValue("@p2", txtlastname.Text);
            da.Parameters.AddWithValue("@p3", txtgender.Text);
            da.Parameters.AddWithValue("@p4", txtcountry.Text);
            da.Parameters.AddWithValue("@p5", txtage.Text);
            da.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Ekleme işlemi Başarılı");
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            listele();
        }

        private void btnekle_Click(object sender, EventArgs e)
        {
            ekle();
        }

        private void btnlistele_Click(object sender, EventArgs e)
        {
            listele();

        }

        
    }
}
