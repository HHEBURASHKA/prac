using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pr5_1
{
    public partial class Pig : Form
    {
        public Pig()
        {
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 form1 = new Form3();
            form1.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form4 form1 = new Form4();
            form1.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form5 form1 = new Form5();
            form1.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // Проверяем, если форма Figures уже открыта, закрываем её
            if (Application.OpenForms.OfType<Figures>().Any())
            {
                Figures Figures = Application.OpenForms.OfType<Figures>().FirstOrDefault();
                Figures.Close();
                this.Close();
            }
        }
    }
}
