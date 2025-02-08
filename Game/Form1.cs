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

namespace Game
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection baglantı = new SqlConnection("Data Source=DESKTOP-SK0HNP2\\SQLEXPRESS;Initial Catalog=DbOyun;Integrated Security=True");

        int soruNo = 0, dogruSayısı = 0, yanlısSayısı = 0, kalansoru = 24;
        bool cevapverildi = false;
        public void sorugetir()
        {
            baglantı.Open();
            SqlCommand sorugetir = new SqlCommand("Select Soru from Tblsoru where ID=@p1", baglantı);
            sorugetir.Parameters.AddWithValue("@p1",soruNo);
            SqlDataReader dr = sorugetir.ExecuteReader();
                while (dr.Read())
                {
                    Button clickedbutton = this.Controls.Find("button" + soruNo, true).FirstOrDefault() as Button; // Butonu bul
                    lblodak.Text= clickedbutton.Text;
                    richTextBox1.Text = dr[0].ToString();
                }
            baglantı.Close();
        }
        public void cevapgetir()
        {
            baglantı.Open();
            SqlCommand cevapgetir = new SqlCommand("Select Cevap from Tblsoru where ID=@p1", baglantı);
            cevapgetir.Parameters.AddWithValue("@p1", soruNo);
            SqlDataReader dr = cevapgetir.ExecuteReader();
                if (dr.Read()) // Satır varsa kontrol et
                {
                    string dogruCevap = dr["Cevap"].ToString(); // Veriyi oku
                    Button clickedbutton = this.Controls.Find("button" + soruNo,true).FirstOrDefault() as Button; // Butonu bul
                        if (dogruCevap == textBox1.Text) // Kullanıcı girdisi ile karşılaştır
                        {
                            clickedbutton.BackColor = Color.Green; // Doğru cevap
                            dogruSayısı++;
                            lbldogru.Text = dogruSayısı.ToString();
                            textBox1.Text = "";

                        }
                        else // Kullanıcı girdisi ile karşılaştır
                        {
                            clickedbutton.BackColor = Color.Red; // Yanlış cevap
                            yanlısSayısı++;
                            lblyanlıs.Text = yanlısSayısı.ToString();
                            textBox1.Text = "";
                        }
                    textBox1.Enabled = false;
                    textBox1.Clear(); // Cevap kutusunu temizle  
                }
            baglantı.Close();   
        }

        
        
        private void Form1_Load(object sender, EventArgs e)
        {
            lbls.Text = kalansoru.ToString();
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && !cevapverildi)
            {
                cevapgetir();
                textBox1.Clear();
                textBox1.Focus();
                kalansoru--;
                lbls.Text = kalansoru.ToString();
            }
        }


        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (soruNo < 24 )
            {
                linkLabel1.Text = "Sonraki";
                soruNo++;
                this.Text = soruNo.ToString();  
                sorugetir();
                textBox1.Enabled = true;    
            }
            else
            {
                linkLabel1.Text = "Bitti";
                linkLabel1.Enabled = false;

                MessageBox.Show("Doğru sayısı:   "+ lbldogru.Text + "\n" + "Yanlış Sayısı:   " + lblyanlıs.Text );
            }
        }
    }
}
