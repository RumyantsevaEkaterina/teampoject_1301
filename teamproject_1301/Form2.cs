using System;
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
    public partial class Form2 : Form
    {
        private readonly object errorProvider1;

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            float a = float.Parse(textBox2.Text);
            float b = float.Parse(textBox3.Text);
            float c = float.Parse(textBox4.Text);

            var d = b * b - 4 * a * c;
           
            if (d<0)
                {
                MessageBox.Show("Дискриминант меньше нуля! Корней нет.");
                    }
            if (d == 0)
            {
                MessageBox.Show("Дискриминант равен 0.");
            }
            var x1 = (-b - Math.Sqrt(d)) / 2 * a;
            var x2 = (-b + Math.Sqrt(d)) / 2 * a;
            textBox5.Text = Convert.ToString(d);
            textBox6.Text = Convert.ToString(x1);
            textBox7.Text = Convert.ToString(x2);
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != 44)
            {
                e.Handled = true;
            }
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != 44)
            {
                e.Handled = true;
            }
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != 44)
            {
                e.Handled = true;
            }
        }
    }
}
