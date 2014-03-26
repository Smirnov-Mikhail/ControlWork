namespace Task_on_the_CW1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Data;
    using System.Drawing;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Windows.Forms;


    public partial class Form1 : Form
    {
        private bool choice;

        public Form1()
        {
            InitializeComponent();
        }

        public void change(System.Windows.Forms.Button button)
        {
            if (button.Text == "X" || button.Text == "O")
                return;
            if (choice)
            {
                button.Text = "O";
                choice = false;
            }
            else
            {
                button.Text = "X";
                choice = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            change(button1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            change(button2);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            change(button3);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            change(button4);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            change(button5);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            change(button6);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            change(button7);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            change(button8);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            change(button9);
        }
    }
}
