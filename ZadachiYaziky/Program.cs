using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZadachiYaziky
{
    class Magic
    {
        static int n, m, sum, sumCol, sumRow;
        static int[,] a = new int[40, 40];
        static bool IsCheck;

        public void inp()
        {
            int i, j;
            Console.WriteLine("Размерность?");
            n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите числа");
            for (i = 0; i < n; i++)
                for (j = 0; j < n; j++)
                    a[i, j] = Convert.ToInt32(Console.ReadLine());

            i = 1; j = 1;
            sum = 0;
            for (int g = 0; g < n; g++)
            {
                for (int s = 0; s < n; s++)
                {
                    m = a[s, g];
                    sum = sum + m;


                }
                sum = 0;
                if (g > 0 && sumRow == sum || g == 0)
                {
                    sumRow = sum;
                }
                else if (g > 0 && sumRow != sum)
                {
                    Console.WriteLine("Суммы строк {0} и {1} не равны. Квадрат не магический.", g - 1, g);
                    IsCheck = false;
                    break;
                }
                IsCheck = true;
            }
            if (IsCheck)
            {
                sum = 0;
                for (int s = 0; s < n; s++)
                {
                    for (int g = 0; g < n; g++)
                    {
                        m = a[g, s];
                        sum = sum + m;


                    }

                    if (s > 0 && sumCol == sum || s == 0)
                    {
                        sumCol = sum;
                    }
                    else if (s > 0 && sumCol != sum)
                    {
                        Console.WriteLine("Суммы столбцов {0} и {1} не равны. Матрица не магическая.", s - 1, s);
                        IsCheck = false;
                        break;
                    }
                    sum = 0;
                }
            }
            if (IsCheck)
            {
                Console.WriteLine("Суммы строк и столбцов равны. Матрица магическая!");
            }



        }

        public void outp()
        {
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine();
                for (int j = 0; j < n; j++)
                    Console.Write("{0, 5}", a[i, j]);
            }
            Console.WriteLine();
        }
    }

    class Program
    {
        static void Main()
        {
            /*Magic matrix = new Magic();
            matrix.inp();
            matrix.outp();*/
            Matrix mat = new Matrix();
            mat.input();
            mat.outp();
            mat.Transpon();
            mat.multMatrix();
            mat.minus();
            mat.outp();
            Console.ReadKey();
        }
    }
}
