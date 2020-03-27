using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BMR
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if ((textBoxWeight.Text != "") && (textBoxAge.Text != "") && (textBoxHeight.Text != "") && ((radioButtonMale.Checked) || (radioButtonFemale.Checked)))
                {
                    label6.ForeColor = Color.Blue;
                    int age = Convert.ToInt32(textBoxAge.Text);
                    float weight = Convert.ToSingle(textBoxWeight.Text);
                    float height = Convert.ToSingle(textBoxHeight.Text);
                    if (radioButtonFemale.Checked)
                    {
                        double bmiFemale = (99.9 * weight) + (6.25 * height) - (4.92 * age) - 161;
                        label6.Text = bmiFemale.ToString();
                    }
                    else
                    {
                        double bmiMale = (99.9 * weight) + (6.25 * height) - (4.92 * age) + 5;
                        label6.Text = bmiMale.ToString();
                    }
                }
                else
                {
                    label6.ForeColor = Color.DarkRed;
                    label6.Text = "Zapomniałeś o czymś";
                }
            }
            catch (FormatException )
            {
                label6.ForeColor = Color.DarkRed;
                label6.Text = "Podane dane są błędne ";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBoxAge.Text = "";
            textBoxHeight.Text = "";
            textBoxWeight.Text = "";
            label6.Text = "";
        }
    }
}
