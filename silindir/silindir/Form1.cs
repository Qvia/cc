using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace silindir
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double r,sonuc;
            const double pi = 3.14;
            r =Convert.ToDouble(textBox1.Text);
            sonuc = (4 * pi) * r * r;
            label3.Text = (sonuc.ToString());

        }

        private void button2_Click(object sender, EventArgs e)
        {
            double r, sonuc;
            const double pi = 3.14;
            r = Convert.ToDouble(textBox1.Text);
            sonuc=((5*pi)*r*r*r)/3;
            label3.Text = (sonuc.ToString());
            
        }
    }
}
