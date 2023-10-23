using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace for_ornek_4_815
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnYaz_Click(object sender, EventArgs e)
        {
            int sayi = Convert.ToInt32(txtBaslangic.Text);
            int sayi2 = Convert.ToInt32(txtBitis.Text);

            for (int i = sayi; i<= sayi2; i++)
            {
                lbSayilar.Items.Add(i);
            }



        }
    }
}
