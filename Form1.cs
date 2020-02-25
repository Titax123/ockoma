using System;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            button1.Click += (a, b) => Calculate();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        void Calculate()
        {
            double x = 0, y = 0, z = 0;
            if (!double.TryParse(textBox1.Text, out x) || !double.TryParse(textBox2.Text, out y) || !double.TryParse(textBox3.Text, out z))
                return;

            textBox4.Text = (5 * Math.Atan(x) - 1.0 / 4 * Math.Acos(x) * ((x + 3 * Math.Abs(x - y) + x * x) / (Math.Abs(x - y) * z + x * x))).ToString();
        }
    }
}
