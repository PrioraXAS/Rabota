﻿using System;
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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form photo = new Form1();
            photo.Show();
            photo.FormClosed += new FormClosedEventHandler(form_FormClosed);
            this.Hide();
        }
        void form_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }
    }
}
