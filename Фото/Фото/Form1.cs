using Microsoft.VisualBasic.ApplicationServices;

namespace Фото
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           this.Close();
        }
        void form_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form photos = new Form2();
            photos.Show();
            photos.FormClosed += new FormClosedEventHandler(form_FormClosed);
            this.Hide();
        }
    }
}

