using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BMI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if ((textBox1.Text != "") && (textBox2.Text != ""))
            {
                label5.ForeColor = Color.Black;
                int waga = Convert.ToInt32(textBox1.Text);
                float wzrost = Convert.ToSingle(textBox2.Text);
                Single bmi = waga / (wzrost * wzrost);
                label5.Text = bmi.ToString();
            }
            else
            {
                label5.ForeColor = Color.Red;
                label5.Text = "brak danych";
            }
        }
    }
}
