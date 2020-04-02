using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PanelLogowania
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Start()
        {
            Form2 f = new Form2();
            f.Show();
        }

        private void button_Click(object sender, EventArgs e)
        {
            string login = textBoxLogin.Text;
            string password = textBoxPassword.Text;
            string[] usersLogin = new string[3];
            string[] usersPassword = new string[3];
            usersLogin[0] = "Tytus";
            usersLogin[1] = "Romek";
            usersLogin[2] = "Atomek";
            usersPassword[0]= "ktos";
            usersPassword[1] = "ktos";
            usersPassword[2] = "ktos";
            for(int i = 0; i < 3; i++)
            {
                if((usersLogin[i]==login)&&(usersPassword[i]==password))
                {
                    Start();
                    break;
                }
               
            }
        }

    }
}
