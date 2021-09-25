using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prova01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            double numero1 = Convert.ToDouble(textBox1.Text);
            double numero2 = Convert.ToDouble(textBox2.Text);
            double resultado = numero1 + numero2;
            textBox3.Text = resultado.ToString();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            double numero1 = Convert.ToDouble(textBox1.Text);
            double numero2 = Convert.ToDouble(textBox2.Text);
            double resultado = numero1 - numero2;
            textBox3.Text = resultado.ToString();
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            double numero1 = Convert.ToDouble(textBox1.Text);
            double numero2 = Convert.ToDouble(textBox2.Text);
            double resultado = numero1 * numero2;
            textBox3.Text = resultado.ToString();
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            double numero1 = Convert.ToDouble(textBox1.Text);
            double numero2 = Convert.ToDouble(textBox2.Text);
            double resultado = numero1 / numero2;
            textBox3.Text = resultado.ToString();
        }
    }
}
