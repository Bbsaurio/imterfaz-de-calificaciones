using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace imterfaz_de_calificaciones
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double c1= double.Parse(textBox1.Text);
            double c2 = double.Parse(textBox2.Text);
            double c3 = double.Parse(textBox3.Text);
            double c4 = double.Parse(textBox4.Text);
            double c5 = double.Parse(textBox5.Text);
            double cf = (c1 + c2 + c3 + c4 + c5) / 5;
            if (cf >= 6)
            {
                textBox6.Text = "Aprobatoria";
                textBox7.Text = cf.ToString();

            }
            else
            {
                textBox6.Text="No aprobatoria";
                textBox7.Text = cf.ToString();
                
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            textBox7.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
