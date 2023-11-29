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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Paint(object sender, PaintEventArgs e)
        {
            this.BackColor = Color.LightBlue;

            Graphics g = e.Graphics;
            Pen blackPen = new Pen(Color.Black, 2);
            SolidBrush pinkBrush = new SolidBrush(Color.Pink);
            SolidBrush whiteBrush = new SolidBrush(Color.White);
            SolidBrush blackBrush = new SolidBrush(Color.Black);
            SolidBrush PaleVioletRedBrush = new SolidBrush(Color.PaleVioletRed);
            SolidBrush SalmonBrush = new SolidBrush(Color.Salmon);
            SolidBrush LightBlue = new SolidBrush(Color.LightBlue);
            // Свинья вид сверху 
            //Тельное сало
            g.FillRectangle(pinkBrush, 100, 100, 200, 100);
            g.DrawRectangle(blackPen, 100, 100, 200, 100);
            // Головное сало
            g.FillRectangle(pinkBrush, 300, 110, 80, 75);
            g.DrawRectangle(blackPen, 300, 110, 80, 75);
            // То чем смотрят 
            g.FillRectangle(blackBrush, 381, 115, 4, 10);
            g.FillRectangle(blackBrush, 381, 170, 4, 10);
            g.FillRectangle(whiteBrush, 381, 125, 4, 10);
            g.FillRectangle(whiteBrush, 381, 160, 4, 10);
            // Часть дыхательного пути и орган обоняния
            g.FillRectangle(pinkBrush, 382, 138, 6, 20);
            g.DrawRectangle(blackPen, 382, 138, 6, 20);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
