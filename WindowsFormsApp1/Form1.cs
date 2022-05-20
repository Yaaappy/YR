using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        int d = 0, d1 = 0;
        float A = 0;
        bool z = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        { textBox1.Text = textBox1.Text + 1; }
        private void button2_Click(object sender, EventArgs e)
        { textBox1.Text = textBox1.Text + 2; }
        private void button3_Click(object sender, EventArgs e)
        { textBox1.Text = textBox1.Text + 3; }
        private void button4_Click(object sender, EventArgs e)
        { textBox1.Text = textBox1.Text + 4; }
        private void button5_Click(object sender, EventArgs e)
        { textBox1.Text = textBox1.Text + 5; }
        private void button6_Click(object sender, EventArgs e)
        { textBox1.Text = textBox1.Text + 6; }
        private void button7_Click(object sender, EventArgs e)
        { textBox1.Text = textBox1.Text + 7; }
        private void button8_Click(object sender, EventArgs e)
        { textBox1.Text = textBox1.Text + 8; }
        private void button9_Click(object sender, EventArgs e)
        { textBox1.Text = textBox1.Text + 9; }
        private void button10_Click(object sender, EventArgs e)
        { textBox1.Text = textBox1.Text + 0; }
        private void button16_Click(object sender, EventArgs e)
        { 
            if ( z == false ) textBox1.Text = textBox1.Text + ",";
            z = true;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            d1 = 1;
            Math();
        } // +
        private void button13_Click(object sender, EventArgs e)
        {
            d1 = 2;
            Math();
        } // -
        private void button12_Click(object sender, EventArgs e)
        {
            d1 = 3;
            Math();
        } // *
        private void button11_Click(object sender, EventArgs e)
        {
            d1 = 4;
            Math();
        } // /
        private void button15_Click(object sender, EventArgs e)
        {
            d1 = 0;
            Math();
        } // =
        private void button17_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            d = 0;
        }
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (z == true)
            {
                if ( e.KeyChar <= 47 || e.KeyChar >= 58) e.Handled = true;
            }
            else
            { 
                if (e.KeyChar <= 43 || e.KeyChar >= 45 && e.KeyChar <= 47 || e.KeyChar >= 58) e.Handled = true;
                else if (e.KeyChar == 44) z = true;
            }
            if (e.KeyChar == 46)
            {
                if (z == false) textBox1.Text = textBox1.Text + ",";
                z = true;
            }
            if (e.KeyChar == 43)
            {
                d1 = 1;
                Math();
            }
            if (e.KeyChar == 45)
            {
                d1 = 2;
                Math();
            }
            if (e.KeyChar == 42)
            {
                d1 = 3;
                Math();
            }
            if (e.KeyChar == 47)
            {
                d1 = 4;
                Math();
            }
            if (e.KeyChar == 61)
            {
                d1 = 0;
                Math();
            }
        }
        void Math()
        {
            string tb1 = textBox1.Text;
            if (tb1 == "") tb1 = "0";
            if (d == 0) A = Convert.ToSingle(tb1);
            if (d == 1) A = A + Convert.ToSingle(tb1);
            if (d == 2) A = A - Convert.ToSingle(tb1);
            if (d == 3) A = A * Convert.ToSingle(tb1);
            if (d == 4) A = A / Convert.ToSingle(tb1);
            textBox1.Text = "";
            textBox2.Text = A.ToString();
            d = d1;
            z = false;
        }
    }
}
