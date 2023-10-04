using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace If_else
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            int sayı1, sayı2;

            sayı1 = Convert.ToInt32(txtSayı1.Text);
            sayı2 = Convert.ToInt32(txtSayı2.Text);

            if (sayı1 > sayı2)
            {
                MessageBox.Show("1.Sayı daha büyüktür.");
            }
            else if (sayı2 > sayı1)
            {
                MessageBox.Show("2.Sayı daha büyüktür.");
            }

            else
            {
                MessageBox.Show("2 Sayı eşittir.");
            }
                 
           
            
             
        }
    }
}
