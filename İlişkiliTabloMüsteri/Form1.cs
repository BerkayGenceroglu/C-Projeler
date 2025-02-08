using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace İlişkiliTabloMüsteri
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'projeİlişkilitabloDataSet.berkaygenceroglu' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.berkaygencerogluTableAdapter.Fill(this.projeİlişkilitabloDataSet.berkaygenceroglu);
            dataGridView1.RowHeadersVisible = false;    
        }
    }
}
