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

namespace ŞifrelemeVeriTabanı
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection baglantı = new SqlConnection("Data Source=DESKTOP-SK0HNP2\\SQLEXPRESS;Initial Catalog=Test;Integrated Security=True");

        private void Form1_Load(object sender, EventArgs e)
        {
            listele();
        }
        void listele()
        {
            SqlCommand listele = new SqlCommand("select * from TBLSIFRE", baglantı);
            SqlDataAdapter da = new SqlDataAdapter(listele);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            dataGridView1.RowHeadersVisible = false;    

        }
        private void btnkaydet_Click(object sender, EventArgs e)
        {
            //metin değişkenindeki her bir karakterin ASCII karşılığını alıp bir byte dizisine çevirir.
            //Convert.ToBase64String metodu, bir byte dizisini (byte[]) alıp, Base64 formatında bir string olarak döndürür.Bu kod, byte dizisini alıp Base64 formatına çevirerek string olarak saklar.
            string ad = txtad.Text;
            byte[] addizi =Encoding.UTF8.GetBytes(ad);
            string adsifre = Convert.ToBase64String(addizi);

            string soyad = txtsoyad.Text;
            byte[] soyaddizi = Encoding.UTF8.GetBytes(soyad);
            string soyadsifre = Convert.ToBase64String(soyaddizi);

            string mail = txtmaıl.Text;
            byte[] maildizi = Encoding.UTF8.GetBytes(mail);
            string mailsifre = Convert.ToBase64String(maildizi);

            string sifre = txtsıfre.Text;
            byte[] sifredizi = Encoding.UTF8.GetBytes(sifre);
            string sifresifre = Convert.ToBase64String(sifredizi);

            string hesapno = txthesapno.Text;
            byte[] hesapnodizi = Encoding.UTF8.GetBytes(hesapno);
            string hesapnosifre = Convert.ToBase64String(hesapnodizi);

            baglantı.Open();
            SqlCommand ekle = new SqlCommand("insert into TBLSIFRE (AD,SOYAD,EMAIL,SIFRE,HESAPNO) values (@p1,@p2,@p3,@p4,@p5)", baglantı);
            ekle.Parameters.AddWithValue("@p1", adsifre);
            ekle.Parameters.AddWithValue("@p2", soyadsifre);
            ekle.Parameters.AddWithValue("@p3", mailsifre);
            ekle.Parameters.AddWithValue("@p4", sifresifre);
            ekle.Parameters.AddWithValue("@p5", hesapnosifre);
            ekle.ExecuteNonQuery();
            baglantı.Close();
            MessageBox.Show("Kayıt Başarılı","İşlem Tamamlandır",MessageBoxButtons.OK,MessageBoxIcon.Information);
            listele();    
        }

        private void btnsifrecoz_Click(object sender, EventArgs e)
        {
            SqlDataAdapter da = new SqlDataAdapter("select * from TBLSIFRE", baglantı);
            DataTable dt = new DataTable();
            da.Fill(dt);
            foreach (DataRow row in dt.Rows)
            {
                try{
                    row["Ad"]= sifrecozumle(row["Ad"].ToString());
                    row["Soyad"] = sifrecozumle(row["Soyad"].ToString());
                    row["EMAIL"] = sifrecozumle(row["EMAIL"].ToString());
                    row["SIFRE"] = sifrecozumle(row["SIFRE"].ToString());
                    row["HesapNo"] = sifrecozumle(row["HesapNo"].ToString());
                }
                catch
                {
                    MessageBox.Show("ShowŞifre Çözme İşlemi Başarısız", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
            }
            dataGridView2.DataSource = dt;
        }

        string sifrecozumle(string v1)
        {
            byte[] cozumdizisi = Convert.FromBase64String(v1);
            string sonuc = Encoding.UTF8.GetString(cozumdizisi);
            return sonuc;   
        }
    }
}
