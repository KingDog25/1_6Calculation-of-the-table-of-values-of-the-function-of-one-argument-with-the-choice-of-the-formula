/*Вычисление таблицы значений функции одного аргумента с выбором формулы*/
/*Составить программу вычисления N значений функции Y для X, изменяющегося от X1 с шагом dX.
 Для проверки правильности программы задать значения для А, X1 и dX из второй таблицы*/

/* Calculation of the table of values of the function of one argument with the choice of the formula */
/*Compose a program to calculate N values of the function Y for X, which varies from X1 with a step of dX.
  To check the correctness of the program, set the values \u200b\u200bfor A, X1 and dX from the second table */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _23_variant_CSharp_1_6
{
    public partial class FormСhoiceFormula : Form
    {
        public FormСhoiceFormula()
        {
            InitializeComponent();
        }

        private void buttonСalculate_Click(object sender, EventArgs e)
        {
            int n = 23, a = 1;
            double x1 = -2.2 * a;
            double dX = (double)a/5;
            string[] tableX = new string[n];
            dataGridView1.RowCount = 1;                             //кол-во строк
            dataGridView1.ColumnCount = 4;                          //столбцов
            dataGridView1.Columns[0].HeaderText = "N";
            dataGridView1.Columns[1].HeaderText = "Значение А";
            dataGridView1.Columns[2].HeaderText = "Значение X1";
            dataGridView1.Columns[3].HeaderText = "Шаг dX";

            dataGridView2.RowCount = n;                             //кол-во строк
            dataGridView2.ColumnCount = 5;                          //столбцов
            dataGridView2.Columns[0].HeaderText = "N";
            dataGridView2.Columns[1].HeaderText = "Значение А";
            dataGridView2.Columns[2].HeaderText = "Значение X1";
            dataGridView2.Columns[3].HeaderText = "Шаг dX";
            dataGridView2.Columns[4].HeaderText = "Результат функции f(x)";

            tableX[0] = "23";
            tableX[1] = "1";
            tableX[2] = "-2,2A";
            tableX[3] = "A/5";
            for (int j = 0; j < dataGridView1.ColumnCount; j++)                                         //заполняем значения X
            {
                dataGridView1.Rows[0].Cells[j].Value = tableX[j];
            }

            double[,] tableY = new double[n, dataGridView2.ColumnCount];
            for (int i = 0; i < n; i++)
            {
                tableY[i, 0] = i+1;
                dataGridView2.Rows[i].Cells[0].Value = (i+1).ToString("0.####");
                
                tableY[i, 1] = a;
                dataGridView2.Rows[i].Cells[1].Value = a.ToString("0.####");

                tableY[i, 2] = x1;
                dataGridView2.Rows[i].Cells[2].Value = x1.ToString("0.####");

                tableY[i, 3] = dX;
                dataGridView2.Rows[i].Cells[3].Value = dX.ToString("0.####");

                tableY[i, 4] = FunctRezult(x1, a);
                dataGridView2.Rows[i].Cells[4].Value = FunctRezult(x1, a).ToString("0.####");

                x1 += dX;                                                       //добавляем шаг
             }

            double FunctRezult(double x, double a)
            {
                double y;
                if (x < 0)
                    y = a + Math.Sqrt(2 * a * Math.Abs(x)) - Math.Abs(x);
                else
                    y = a * Math.Sqrt(3) - Math.Pow(x, 2) + Math.Pow(a, 2);
                return y;
            }

        }
    }
}
