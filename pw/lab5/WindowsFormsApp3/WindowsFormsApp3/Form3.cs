using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace WindowsFormsApp3
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
            MySqlConnection connection = new MySqlConnection("datasource=127.0.0.1;port=3306;username=root;password=;database=biblioteka;");
        private void button1_Click(object sender, EventArgs e)
        {
            
            string book = "DELETE from ksiazka WHERE ksiazka.Id = " + textBox1.Text + ";";
            connection.Open();
            MySqlCommand command = new MySqlCommand(book, connection);
            try
            {
                if (command.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Usunięto ksiażkę");
                    Close();
                }
                else
                {
                     MessageBox.Show("Wystąpił błąd");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            connection.Close();
        }
    }
}

