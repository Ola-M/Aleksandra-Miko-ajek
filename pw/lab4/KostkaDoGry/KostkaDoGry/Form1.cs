using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KostkaDoGry
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void KeyR(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 'r')
            {
                Random rand = new Random();
                int T = 0;
                for (int i = 0; i < 5; i++)
                {
                    T = rand.Next(1, 6);
                }
                label2.Text = T.ToString();
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            
        }
    }
}
