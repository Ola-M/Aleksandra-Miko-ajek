using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Windows.Forms;


namespace PESEL
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Int64 pesel = Int64.Parse(textBox1.Text.ToString());
            Int64[] p = new Int64[11];
                  
            for(int i=0;i<11;i++ )
             {
                p[i] = pesel % 10;
             }
            Int64 peselCheck = (1 * p[0]) + (3 * p[1]) + (7 * p[2]) + (9 * p[3]) + (1 * p[4]) + (3 * p[5]) + (7 * p[6]) + (9 * p[7]) + (1 * p[8]) + (3 * p[9]);
            peselCheck %= 10;
            if ((10 - peselCheck) == p[10])
             {
                 label3.Text = "Pesel jest poprawny";
             }
             else
             {
                 label3.Text = "Błędny pesel";
             }

        }

    }
}
