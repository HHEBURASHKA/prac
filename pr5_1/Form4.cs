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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Paint(object sender, PaintEventArgs e)
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
            // Свинья вид с переди
            //Голова
            g.FillRectangle(pinkBrush, 340, 80, 80, 75);
            g.DrawRectangle(blackPen, 340, 80, 80, 75);
            // Глаза
            g.FillRectangle(whiteBrush, 350, 95, 20, 10);
            g.DrawRectangle(blackPen, 350, 95, 20, 10);
            g.FillRectangle(whiteBrush, 390, 95, 20, 10);
            g.DrawRectangle(blackPen, 390, 95, 20, 10);
            // Зрачки(а почему бы и нет)
            g.FillRectangle(blackBrush, 351, 95, 10, 10);
            g.FillRectangle(blackBrush, 400, 95, 10, 10);
            // Пятак
            g.DrawRectangle(blackPen, 360, 115, 40, 20);
            g.FillRectangle(blackBrush, 364, 120, 10, 10);
            g.FillRectangle(blackBrush, 386, 120, 10, 10);
            // Ножки
            g.FillRectangle(pinkBrush, 340, 201, 20, 50);
            g.DrawRectangle(blackPen, 340, 201, 20, 50);
            g.FillRectangle(pinkBrush, 400, 201, 20, 50);
            g.DrawRectangle(blackPen, 400, 201, 20, 50);
            // Талия (аномалия как песочные часы)
            g.FillRectangle(pinkBrush, 340, 156, 80, 46);
            g.DrawRectangle(blackPen, 340, 156, 80, 46);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
