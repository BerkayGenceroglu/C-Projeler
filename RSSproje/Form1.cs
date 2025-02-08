using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;


namespace RSSproje
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        void haber(string link)
        {
            listBox1.Items.Clear();
            XmlTextReader okuyucu = new XmlTextReader(link);
            while (okuyucu.Read())
            {
                if (okuyucu.Name == "title")
                {
                    listBox1.Items.Add(okuyucu.ReadString());
                }
            }
        }
        //https://haberglobal.com.tr/rss
        //https://www.gzt.com/rss
        //https://www.ntv.com.tr/gundem.rss

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnhaberglobal_Click(object sender, EventArgs e)
        {
            haber("https://haberglobal.com.tr/rss");
        }

        private void btngzt_Click(object sender, EventArgs e)
        {
            haber("https://www.gzt.com/rss");
        }

        private void btnntv_Click(object sender, EventArgs e)
        {
            haber("https://www.ntv.com.tr/gundem.rss");
        }
    }
}
