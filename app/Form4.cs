using System;
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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                pictureBox1.Image = Image.FromFile("D:\\Vasilieva_Kurs\\images\\gordeev1.jpg");
                pictureBox1.Visible = true;
            }
            else
            {
                pictureBox1.Visible = false;
            }

            if (checkBox2.Checked)
            {
                pictureBox2.Image = Image.FromFile("D:\\Vasilieva_Kurs\\images\\potrashkova1.jpg");
                pictureBox2.Visible = true;
            }
            else
            {
                pictureBox2.Visible = false;
            }


            if (checkBox3.Checked)
            {
                pictureBox3.Image = Image.FromFile("D:\\Vasilieva_Kurs\\images\\evseev.jpg");
                pictureBox3.Visible = true;
            }
            else
            {
                pictureBox3.Visible = false;
            }


            if (checkBox4.Checked)
            {
                pictureBox4.Image = Image.FromFile("D:\\Vasilieva_Kurs\\images\\bratkevich.jpg");
                pictureBox4.Visible = true;
            }
            else
            {
                pictureBox4.Visible = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();

            Form2 form2 = new Form2();

            form2.ShowDialog();

            this.Close();
        }
    }
}
