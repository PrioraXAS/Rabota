using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace Базы_данных
{
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
        }        
            
        private void Form_FormClosed(object sender, FormClosedEventArgs e)
        {
            Close();
        }

        private void ButtonEnter_Click(object sender, EventArgs e)
        {
            string login = TextBoxLogin.Text;
            string Password = TextBoxLogin.Text;
            if (login == "admin" && Password == "admin")
            {
                Form users = new Form1();
                users.Show();
                this.Hide();
            }
            if (login == "user" && Password == "user")
            {
                Form users = new Form10();
                users.Show();
                this.Hide();
            }
           
        }

        private void Form9_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
