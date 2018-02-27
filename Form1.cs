using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab1_1
{
    public partial class Calculator : Form
    {
        public Calculator()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void piramidabp_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void piramidavolume_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void Calculate1_Click(object sender, EventArgs e)
        {
           
            piramidavolume.Text = ((((Double.Parse(side.Text) * Double.Parse(side.Text) * Double.Parse(side.Text)) * 1.41) / 12.0)).ToString();
            piramidabp.Text = (((((Double.Parse(side.Text) * Double.Parse(side.Text))*1.7)/4.0)*3.0)).ToString();
            piramidapl.Text = (((((Double.Parse(side.Text) * Double.Parse(side.Text)) * 1.7) / 4.0) * 4.0)).ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            volumez.Text = (3.14 * Double.Parse(radiusz.Text) * Double.Parse(radiusz.Text) * Double.Parse(heightz.Text)).ToString();
            plbz.Text = (2 * 3.14 * Double.Parse(radiusz.Text) * Double.Parse(heightz.Text)).ToString();
            plz.Text = ((2 * 3.14 * Double.Parse(radiusz.Text) * Double.Parse(radiusz.Text)) + Double.Parse(plbz.Text)).ToString();
        }

        private void Calculate3_Click(object sender, EventArgs e)
        {
            volumek.Text = ((3.14 * Double.Parse(radiusk.Text) * Double.Parse(radiusk.Text) * Double.Parse(heightk.Text)) / 3).ToString();
            plbk.Text = (3.14 * Double.Parse(radiusk.Text) * Double.Parse(twirnak.Text)).ToString();   
            plk.Text = (Double.Parse(plbk.Text) + (3.14 * Double.Parse(radiusk.Text) * Double.Parse(radiusk.Text))).ToString();
        }
    }
}
