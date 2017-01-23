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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 kvadr = new Form2();
            kvadr.Hide();
            kvadr.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 syst = new Form3();
            syst.Hide();
            syst.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form4 potap = new Form4();
            potap.Hide();
            potap.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }
    }
}
