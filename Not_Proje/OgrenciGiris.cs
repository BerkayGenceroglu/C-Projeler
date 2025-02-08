using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Not_Proje
{
    public partial class OgrenciGiris : Form
    {
        public OgrenciGiris()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OgrenciNot ogrenciNot = new OgrenciNot();
            ogrenciNot.numara = msknumber.Text;  
            ogrenciNot.Show();  

        }

        private void msknumber_TextChanged(object sender, EventArgs e)
        {
            if (msknumber.Text == "1111") 
            {
                FrmOgretmen frmOgretmen = new FrmOgretmen();
                frmOgretmen.Show();
            }
        }
    }
}
