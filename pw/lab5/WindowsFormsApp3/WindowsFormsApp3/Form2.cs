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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        MySqlConnection connection = new MySqlConnection("datasource=127.0.0.1;port=3306;username=root;password=;database=biblioteka;");
        private void button1_Click(object sender, EventArgs e)
        {
            string newBook = "INSERT INTO ksiazka (Id, Tytuł, Autor, Gatunek, rokWydania) VALUES('" + "NULL" + "','" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "');";
            connection.Open();
            MySqlCommand command = new MySqlCommand(newBook, connection);
            try
            {
                if (command.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Dodano ksiażkę");
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
    

