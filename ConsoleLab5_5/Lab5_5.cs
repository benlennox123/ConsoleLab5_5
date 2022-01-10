using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleLab5_5
{
    class Lab5_5
    {
        static void Main(string[] args)
        {
            Console.Write("Введите размерность двухмерного массива N=");
            int N = Math.Abs(Convert.ToInt32(Console.ReadLine()));
            int[,] t = new int[N, N];
            for (int i = 0; i < N; i++)
            {
                int t1 = i % 2;
                if (t1 == 0)
                {
                    for (int j = 0; j < N; j++)
                    {
                        int t2 = j % 2;
                        if (t2 == 0)
                        {
                            t[i, j] = 1;
                        }
                        else
                        {
                            t[i, j] = 0;
                        }
                        Console.Write("{0} ", t[i, j]);
                    }
                }
                else
                {
                    for (int j = 0; j < N; j++)
                    {
                        int t2 = j % 2;
                        if (t2 == 0)
                        {
                            t[i, j] = 0;
                        }
                        else
                        {
                            t[i, j] = 1;
                        }
                        Console.Write("{0} ", t[i, j]);
                    }
                }
                Console.WriteLine();
            }
            Console.Write("Для завершения нажмите любую клавишу");
            Console.ReadKey();
        }
    }
}
