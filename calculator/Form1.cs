using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace calculator
{
    public partial class Form1 : Form
    {

        
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            float p = Convert.ToInt32(Convert.ToDecimal(textBox1.Text));
            float t = Convert.ToInt32(Convert.ToDecimal(textBox1.Text));
            float r = Convert.ToInt32(Convert.ToDecimal(textBox1.Text));
     
            calculate c = new calculate(p,t,r);
            float ans = c.cal();

            label1.Text = ans.ToString();

           
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        
        }
    }
}
