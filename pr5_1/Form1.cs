using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pr5_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private int[] Arr = new int[10];
        private void btnNewArr_Click(object sender, EventArgs e)
        {
            int n = 10;
            int a = int.Parse(textBox2.Text);
            int b = int.Parse(textBox3.Text);
            Random r = new Random();
        }

        private void btnSort_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {

        }
    }
}
