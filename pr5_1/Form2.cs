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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void buttonCalc_Click(object sender, EventArgs e)
        {
            //сичтаем с формы требуемые значени
            double Xmin = double.Parse(textBoxXminS.Text);
            double Xmax = double.Parse(textBoxXmaxS.Text);
            double Step = double.Parse(textBoxStepS.Text);
            //количество точек графика
            int count = (int)Math.Ceiling((Xmax - Xmin) / Step)
                + 1;
            //массив значений X - общий для обоих графиков
            double[] X = new double[count];
            double[] y1 = new double[count];
            double[] y2 = new double[count];
            //расчитываем точки для графиков функции
            for (int i = 0; i < count; i++)
            {
                //вычисляем значение
                X[i] = Xmin + Step * i;
                //вычисляем значение функций в точке X
                y1[i] = Math.Pow(10, -2) * (-1.5) * (0.75) / (X[i] + Math.Cos(Math.Sqrt(Math.Pow((-1.25), 3) * X[i])));
                y2[i] = (Math.Pow(X[i], 2) + 2 * X[i] - 7) / Math.Sqrt(X[i]+100);
            }
            //настраиваем оси графика
            chart2.ChartAreas[0].AxisX.Minimum = Xmin;
            chart2.ChartAreas[0].AxisX.Maximum = Xmax;
            //определяем шаг сетки 
            chart2.ChartAreas[0].AxisX.MajorGrid.Interval = Step;

            //добавляем вычисление значения в графики
            chart2.Series[0].Points.DataBindXY(X, y1);
            chart2.Series[1].Points.DataBindXY(X, y2);
        }
    }
}
