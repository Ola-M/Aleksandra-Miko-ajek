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

        private void label2_Click(object sender, EventArgs e)
        {
            
        }

        private void Key_R(object sender, KeyPressEventArgs e)
        {
            Random rand = new Random();
            int T ;
            T = rand.Next(1,6);
            label2.Text = T.ToString();
            
            
            
        }

        private void DoSchowka(object sender, MouseEventArgs e)
        {
            Clipboard.SetText(label2.Text);
        }
    }
}
