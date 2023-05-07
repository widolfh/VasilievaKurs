using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace app
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex == 0)
            {
                label1.Text="Розрахувати та описати параметри \n " +
                    "механічного редуктора .";
            }
            else if (listBox1.SelectedIndex == 1)
            {
                label1.Text = "Змоделювати редуктор за допомогою \n " +
                    "геометричних примітивів у сфері " +
                    "\n програмного середовища Autocad.\r\n";
            }
            else if (listBox1.SelectedIndex == 2) 
            {
                label1.Text = "Навчитися створювати анімацію збирання \n" +
                    "та працювання редуктора у сфері \n" +
                    "програмного середовища 3DS Max .\n" +
                    "Зробити покадрову анімацію обліта редуктора \n" +
                    " у сфері програмного середовища Adobe Animate .";
            }
            else if (listBox1.SelectedIndex == 3) 
            {
                label1.Text = "Створити AR-анімацію своєї ілюстрації на тему\n" +
                    " \"Пам'ятки Харкова та України\" .";
            }
            else if (listBox1.SelectedIndex == 4) 
            {
                label1.Text = "Розробити мультимедійну презентацію з \n" +
                    "використанням мови програмування C# .";
            }
        }


       

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Hide();

            Form2 form2 = new Form2();

            form2.ShowDialog();

            this.Close();
        }
    }
}
