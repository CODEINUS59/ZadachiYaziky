using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZadachiYaziky
{
    class Matrix
    {

        static private Random r = new Random();
        int n;
        /*Основные матрицы*/
        int[,] a = new int[40, 40];
        int[,] b = new int[40, 40];
        int[,] c = new int[40, 40];
        int[,] d = new int[40, 40];

        /*Вспомогательные*/
        int[,] h1 = new int[80, 80];
        int[,] h2 = new int[80, 80];
        int[,] h3 = new int[80, 80];
        int[,] h4 = new int[80, 80];

        public void input()
        {
            Console.WriteLine("Размерность матриц?");
            n = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < n; i++)
                for (int j = 0; j < n; j++)
                {
                    a[i, j] = r.Next(20);
                    b[i, j] = r.Next(20);
                    c[i, j] = r.Next(20);
                    d[i, j] = r.Next(20);
                }
            

        }
        public void Transpon()
        {
            for (int i = 1; i < n; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    a[i, j] ^= a[j, i];
                    a[j, i] ^= a[i, j];
                    a[i, j] ^= a[j, i];
                }
            }
        }

        public void multMatrix()
        {

            for (int i = 0; i < n; i++)
                for (int j = 0; j < n; j++)
                {
                    h1[i,j] = 0;
                    for (int k = 0; k < n; k++)
                        h1[i,j] += c[i,k] * d[k,j];
                }
            
            for (int i = 0; i < n; i++)
                for (int j = 0; j < n; j++)
                {
                    h2[i, j] = 0;
                    for (int k = 0; k < n; k++)
                        h2[i, j] += b[i, k] * h1[k, j];
                }

            for (int i = 0; i < n; i++)
                for (int j = 0; j < n; j++)
                {
                    h3[i, j] = 0;
                    for (int k = 0; k < n; k++)
                        h3[i, j] += a[i, k] * h2[k, j];
                }
               
            for (int i = 0; i < n; i++)
                for (int j = 0; j < n; j++)
                {
                    h3[i, j] = h3[i, j] * 4;
                }

            for (int i = 0; i < n; i++)
                for (int j = 0; j < n; j++)
                {
                    d[i, j] = d[i, j] * 3;
                }

        }

        public void minus()
        {
            for (int i = 0; i < n; i++)
                for (int j = 0; j < n; j++)
                {
                    h4[i, j] = h1[i, j] - h3[i, j];
                }
        }

        public void outp()
        {
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine();
                for (int j = 0; j < n; j++)
                {
                    Console.Write("{0, 5}", h4[i, j]);
                }
            }
            Console.WriteLine();
        }


    }
}
