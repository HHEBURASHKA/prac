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

        private void tmr_Tick(object sender, EventArgs e)
        {
            /*Увеличивает значение свойства Left изображения pct на 20 пикселей
              Проверяет, если текущая позиция изображения pct, плюс его ширина и 20 пикселей, превышает ширину текущей формы*/
            pct.Left = pct.Left + 20;
            if (pct.Left + pct.Width + 20 > this.Width)
            {
                tmr.Stop();
                pct.Left = 0;
                btnStart.Text = "Старт";
                return;
            }
        }
        //Логическая переменная, отражающая текущее состояние анимации
        //(true, если анимация выполняется, false, если анимация остановлена)
        private bool isAnimating = false;

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (isAnimating)
            {
                //возвращает изображение в начальное положение
                //(устанавливает значение свойства Left изображения pct в 0 пикселей)
                tmr.Stop();
                pct.Left = 0;
                btnStart.Text = "Старт";
                isAnimating = false;
            }
            else
            {
                tmr.Start();
                btnStart.Text = "Стоп";
                //Устанавливает значение переменной(выполняется)
                isAnimating = true;
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
