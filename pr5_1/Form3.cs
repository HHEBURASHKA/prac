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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Paint(object sender, PaintEventArgs e)
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
            // Свинья вид с боку
            // Рисуем тело свиньи
            Rectangle rectBody = new Rectangle(100, 100, 200, 100);
            LinearGradientBrush gradientBody = new LinearGradientBrush(rectBody, Color.PaleVioletRed, Color.Salmon, LinearGradientMode.ForwardDiagonal);
            g.FillRectangle(gradientBody, rectBody);
            g.DrawRectangle(blackPen, rectBody);
            // Голова
            Rectangle rectHead = new Rectangle(300, 80, 80, 75);
            LinearGradientBrush gradientHead = new LinearGradientBrush(rectBody, Color.Salmon, Color.PaleVioletRed, LinearGradientMode.ForwardDiagonal);
            g.FillRectangle(gradientBody, rectHead);
            g.DrawRectangle(blackPen, rectHead);
            // Нос
            Rectangle rectNose = new Rectangle(382, 115, 6, 20);
            LinearGradientBrush gradientNose = new LinearGradientBrush(rectBody, Color.Pink, Color.PaleVioletRed, LinearGradientMode.ForwardDiagonal);
            g.FillRectangle(gradientNose, rectNose);
            g.DrawRectangle(blackPen, rectNose);
            // Глаза
            g.FillRectangle(blackBrush, 381, 93, 4, 10);
            //Ноги
            Rectangle rectLevLeg = new Rectangle(110, 201, 20, 50);
            LinearGradientBrush gradientLevLeg = new LinearGradientBrush(rectBody, Color.Pink, Color.PaleVioletRed, LinearGradientMode.ForwardDiagonal);
            g.FillRectangle(gradientLevLeg, rectLevLeg);
            g.DrawRectangle(blackPen, rectLevLeg);
            Rectangle rectRightLeg = new Rectangle(270, 201, 20, 50);
            LinearGradientBrush gradientRightLeg = new LinearGradientBrush(rectBody, Color.Pink, Color.PaleVioletRed, LinearGradientMode.ForwardDiagonal);
            g.FillRectangle(gradientRightLeg, rectRightLeg);
            g.DrawRectangle(blackPen, rectRightLeg);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
