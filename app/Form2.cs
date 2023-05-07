﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace app
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();

            Form3 form3 = new Form3();
            
            form3.ShowDialog();
            
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();

            Form4 form4 = new Form4();

            form4.ShowDialog();

            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();

            Form5 form = new Form5();

            form.ShowDialog();

            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }
    }
}
