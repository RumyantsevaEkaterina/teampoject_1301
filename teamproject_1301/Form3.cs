﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace teamproject_1301
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            Text = "Решение системы уравнений";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            float a = float.Parse(textBox1.Text);
            float b = float.Parse(textBox2.Text);
            float c = float.Parse(textBox3.Text);
            float d = float.Parse(textBox4.Text);
            float q = float.Parse(textBox5.Text);
            float f = float.Parse(textBox6.Text);

           var x = (a * f - c * d) / (a * q - b * d);
           var y = (c * q - b * f) / (a * q - b * d);

            if ((a * q - b * d) == 0)
            {
                MessageBox.Show("Внимание! Уравнение не имеет решения");
            }

            textBox7.Text = Convert.ToString(x);
            textBox8.Text = Convert.ToString(y);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8 && !((e.KeyChar == ',') && (textBox1.Text.IndexOf(",") == -1)))
            {
                if (e.KeyChar != (char)Keys.Back) e.Handled = true;
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8 && !((e.KeyChar == ',') && (textBox2.Text.IndexOf(",") == -1)))
            {
                if (e.KeyChar != (char)Keys.Back) e.Handled = true;
            }
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8 && !((e.KeyChar == ',') && (textBox3.Text.IndexOf(",") == -1)))
            {
                if (e.KeyChar != (char)Keys.Back) e.Handled = true;
            }
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8 && !((e.KeyChar == ',') && (textBox4.Text.IndexOf(",") == -1)))
            {
                if (e.KeyChar != (char)Keys.Back) e.Handled = true;
            }
        }

        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8 && !((e.KeyChar == ',') && (textBox5.Text.IndexOf(",") == -1)))
            {
                if (e.KeyChar != (char)Keys.Back) e.Handled = true;
            }
        }

        private void textBox6_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8 && !((e.KeyChar == ',') && (textBox6.Text.IndexOf(",") == -1)))
            {
                if (e.KeyChar != (char)Keys.Back) e.Handled = true;
            }
        }
    }
}
