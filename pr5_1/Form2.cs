using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pr5_1
{
    public partial class Figures : Form
    {
        public Figures()
        {
            InitializeComponent();
        }

        private void Form2_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            // Цвета
            Color green = Color.Green;
            Color blue = Color.Blue;
            Color black = Color.Black;

            // Перья для различных стилей линий
            Pen solidPen = new Pen(black, 2);
            Pen dashedPen = new Pen(green, 8) { DashStyle = DashStyle.Dash };
            Pen dottedPen = new Pen(blue, 4) { DashStyle = DashStyle.Dot };

            // Заливка
            SolidBrush solidBrush = new SolidBrush(green);

            // Рисуем линии различных стилей
            g.DrawLine(solidPen, 20, 20, 200, 20);
            g.DrawLine(dashedPen, 20, 50, 200, 50);
            g.DrawLine(dottedPen, 20, 80, 200, 80);

            // Рисуем круг
            g.DrawEllipse(solidPen, 50, 120, 100, 100);
            g.FillEllipse(solidBrush, 200, 120, 100, 100);

            // Рисуем прямоугольники
            g.DrawRectangle(solidPen, 20, 250, 120, 80);
            g.FillRectangle(solidBrush, 200, 250, 120, 80);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Pig form1 = new Pig();
            form1.Show();
        }
    }
}
