using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ukol1methody
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public double Obsah(double a)
        {
            return 4 * a;
        }
        public double Obsah(double a, double b)
        {
            return a * b;
        }
        public double Objem(double a)
        {
            return a * a * a; 
        }
        public double Objem(double a, double b, double c)
        {
            return a * b * c;
        }
        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try { 
            double a = double.Parse(textBox1.Text);
            double b = double.Parse(textBox2.Text);
            double c = double.Parse(textBox3.Text);
            label5.Text = Obsah(a).ToString();
            label7.Text = Obsah(a, b).ToString();
            label10.Text = Objem(a).ToString();
            label8.Text = Objem(a, b, c).ToString();
            }
            catch { MessageBox.Show("JENOM ČÍSLA"); }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
