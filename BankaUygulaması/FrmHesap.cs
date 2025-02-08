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

namespace BankaUygulaması
{
    public partial class FrmHesap : Form
    {
        public FrmHesap()
        {
            InitializeComponent();
        }
        SqlConnection baglantı = new SqlConnection("Data Source=DESKTOP-SK0HNP2\\SQLEXPRESS;Initial Catalog=Banka;Integrated Security=True;");
         public string hesapno;

        void tablo1()
        {
            baglantı.Open();
            SqlCommand cmd = new SqlCommand("SELECT HAREKETID, GONDEREN, TUTAR FROM tblhareket WHERE ALICI=@p1", baglantı);
            cmd.Parameters.AddWithValue("@p1", lblhesapno.Text); // Senin hesap numaran alıcı olmalı

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            dataGridView1.RowHeadersVisible = false;
            baglantı.Close();
        }

        void tablo2()
        {
            baglantı.Open();
            SqlCommand cmd = new SqlCommand("SELECT HAREKETID, ALICI, TUTAR FROM tblhareket WHERE GONDEREN=@p1", baglantı);
            cmd.Parameters.AddWithValue("@p1", lblhesapno.Text); // Senin hesap numaran gönderen olmalı

            SqlDataAdapter da2 = new SqlDataAdapter(cmd);
            DataTable dt2 = new DataTable();
            da2.Fill(dt2);
            dataGridView2.DataSource = dt2;
            dataGridView2.RowHeadersVisible = false;
            baglantı.Close();
        }



        private void FrmHesap_Load(object sender, EventArgs e)
        {
            lblhesapno.Text = hesapno;

            //Hesap No'ya göre Diğer Bilgileri Getirme
            baglantı.Open();
            SqlCommand komut = new SqlCommand("select * from TBLKISILER where HESAPNO=@p1", baglantı);
            komut.Parameters.AddWithValue("@p1", hesapno);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                lbladsoyad.Text = dr[1].ToString() + " " + dr[2].ToString();
                lbltelefon.Text = dr[3].ToString();
                lbltckimlik.Text = dr[4].ToString();
            }
            baglantı.Close();

            tablo1();
            tablo2();
        }

        void islemler()
        {
            //Hesap No'ya göre Gelen İşlemleri Getirme
            baglantı.Open();
            SqlCommand sqlCommand = new SqlCommand("insert into tblhareket (GONDEREN,ALICI,TUTAR) values (@p1,@p2,@p3)", baglantı);
            sqlCommand.Parameters.AddWithValue("@p1", lblhesapno.Text);
            sqlCommand.Parameters.AddWithValue("@p2", mskhesapno.Text);
            sqlCommand.Parameters.AddWithValue("@p3", decimal.Parse(txttutar.Text));
            sqlCommand.ExecuteNonQuery();
            baglantı.Close();
        }
       

        private void btngonder_Click(object sender, EventArgs e)
        {
            //Para Transferi1
            baglantı.Open();    
            SqlCommand paratransfer = new SqlCommand("update tblHesap set BAKIYE=BAKIYE+@p1 where HESAPNO=@p2", baglantı);
            paratransfer.Parameters.AddWithValue("@p2",mskhesapno.Text); 
            paratransfer.Parameters.AddWithValue("@p1",decimal.Parse(txttutar.Text));
            paratransfer.ExecuteNonQuery();
            baglantı.Close();
            MessageBox.Show("Para Transferi Başarılı");

            //Para Transferi2
            baglantı.Open();
            SqlCommand paratransfer2 = new SqlCommand("update tblhesap set BAKIYE=BAKIYE-@p1 where HESAPNO=@p2", baglantı);
            paratransfer2.Parameters.AddWithValue("@p1", decimal.Parse(txttutar.Text));
            paratransfer2.Parameters.AddWithValue("@p2", lblhesapno.Text);
            paratransfer2.ExecuteNonQuery();
            baglantı.Close();
            islemler();
            tablo1();
            tablo2();
        }
    }
}
