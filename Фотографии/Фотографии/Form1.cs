using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Фотографии
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form photo = new Form2();
            photo.Show();
            photo.FormClosed += new FormClosedEventHandler(form_FormClosed);
            this.Hide();
        }
        void form_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form photo = new Form3();
            photo.Show();
            photo.FormClosed += new FormClosedEventHandler(form_FormClosed);
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form photo = new Form4();
            photo.Show();
            photo.FormClosed += new FormClosedEventHandler(form_FormClosed);
            this.Hide();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
