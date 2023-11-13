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
        private int NumberSymbols(string stroka, char symbol)
        {
            int k = 0;
            for (int i = 0; i<stroka.Length; i++)
            {
                if (stroka[i] == symbol)
                {
                    k += 1;
                }
            }
            return k;
        }

        private void button1_Click(object sender, EventArgs e)
        {  
            string input = textBox1.Text;
            char symbol = textBox4.Text[0];
            int count = NumberSymbols(input, symbol);
            textBox2.Text = count.ToString();
            int maCount = 0;
            for (int i = 0; i < input.Length - 1; i++)
            {
                if (input[i] == 'м' && input[i +1] == 'а')
                {
                    maCount++;
                }
            }
            textBox3.Text = maCount.ToString();  
        }
    }

}
