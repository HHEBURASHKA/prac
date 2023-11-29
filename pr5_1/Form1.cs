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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            // Заливка фона 
            this.BackColor = Color.LightBlue;

            Graphics g = e.Graphics;
            Pen blackPen = new Pen(Color.Black, 2);
            SolidBrush pinkBrush = new SolidBrush(Color.Pink);
            SolidBrush whiteBrush = new SolidBrush(Color.White);
            SolidBrush blackBrush = new SolidBrush(Color.Black);
            SolidBrush PurpleBrush = new SolidBrush(Color.Purple);

            // Свинья вид с боку
            // Рисуем тело свиньи
            g.FillRectangle(pinkBrush, 100, 100, 200, 100);
            g.DrawRectangle(blackPen, 100, 100, 200, 100);
            // Голова
            g.FillRectangle(pinkBrush, 300, 80, 80, 75);
            g.DrawRectangle(blackPen, 300, 80, 80, 75);
            // Нос
            g.FillRectangle(pinkBrush, 382, 115, 6, 20);
            g.DrawRectangle(blackPen, 382, 115, 6, 20);
            // Глаза
            g.FillRectangle(blackBrush, 381, 93, 4, 10);
            //Ноги
            g.FillRectangle(pinkBrush, 110, 201, 20, 50);
            g.DrawRectangle(blackPen, 110, 201, 20, 50);
            g.FillRectangle(pinkBrush, 270, 201, 20, 50);
            g.DrawRectangle(blackPen, 270, 201, 20, 50);

            // Свинья вид с переди
            //Голова
            g.FillRectangle(pinkBrush, 640, 80, 80, 75);
            g.DrawRectangle(blackPen, 640, 80, 80, 75);
            // Глаза
            g.FillRectangle(whiteBrush, 650, 95, 20, 10);
            g.DrawRectangle(blackPen, 650, 95, 20, 10);
            g.FillRectangle(whiteBrush, 690, 95, 20, 10);
            g.DrawRectangle(blackPen, 690, 95, 20, 10);
            // Зрачки(а почему бы и нет)
            g.FillRectangle(blackBrush, 651, 95, 10, 10);
            g.FillRectangle(blackBrush, 700, 95, 10, 10);
            // Пятак
            g.DrawRectangle(blackPen, 660, 115, 40, 20);
            g.FillRectangle(blackBrush, 664, 120, 10, 10);
            g.FillRectangle(blackBrush, 686, 120, 10, 10);
            // Ножки
            g.FillRectangle(pinkBrush, 640, 201, 20, 50);
            g.DrawRectangle(blackPen, 640, 201, 20, 50);
            g.FillRectangle(pinkBrush, 700, 201, 20, 50);
            g.DrawRectangle(blackPen, 700, 201, 20, 50);
            // Талия (аномалия как песочные часы)
            g.FillRectangle(pinkBrush, 640, 156, 80, 46);
            g.DrawRectangle(blackPen, 640, 156, 80, 46);

            // Свинья вид сверху 
            //Тельное сало
            g.FillRectangle(pinkBrush, 100, 300, 200, 100);
            g.DrawRectangle(blackPen, 100, 300, 200, 100);
            // Головное сало
            g.FillRectangle(pinkBrush, 300, 314, 80, 75);
            g.DrawRectangle(blackPen, 300, 314, 80, 75);
            // То чем смотрят 
            g.FillRectangle(blackBrush, 381, 315, 4, 10);
            g.FillRectangle(blackBrush, 381, 367, 4, 10);
            g.FillRectangle(whiteBrush, 381, 325, 4, 10);
            g.FillRectangle(whiteBrush, 381, 378, 4, 10);
            // Часть дыхательного пути и орган обоняния
            g.FillRectangle(pinkBrush, 382, 341, 6, 20);
            g.DrawRectangle(blackPen, 382, 341, 6, 20);

        }
    }
}
