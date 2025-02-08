using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListYapısıProje
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            List<Kısıler> berkay = new List<Kısıler> ();
            berkay.Add(new Kısıler()
            {
                Adı = "berkay",
                Soyadı = "genceroğlu",
                Yası = 21
            });

            foreach(Kısıler kısıler in berkay)
            {
                listBox3.Items.Add(kısıler.Adı + " " + kısıler.Soyadı + " " +kısıler.Yası);
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<string> yazı = new List<string> ();
            yazı.Add("berkay");
            yazı.Add("alvaro");
            yazı.Add("mauro");
            yazı.Add("victor");
            yazı.Add("gabriel");
            yazı.Add("lucas");
            yazı.Add("fernando");

            foreach (string b in yazı)
            {
                listBox1.Items.Add(b);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            List<int> numara = new List<int> ();    
            numara.Add (1);
            numara.Add (2);
            numara.Add (3);
            numara.Add (4);
            numara.Add (5);
            numara.Add (6);
            numara.Add (7);
            numara.Add (8);
            numara.Add (9);
            numara.Add (10);
            foreach (int i in numara)
            {
                listBox2.Items.Add(i);
            }
        }
    }
}
