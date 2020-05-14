using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_6._3
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Введите размерность массива:");
                int n = Convert.ToInt32(Console.ReadLine());
                int[,] mass = new int[n, n];
                Random r = new Random();
                Console.WriteLine();
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        mass[i, j] = r.Next(1, 100);
                        Console.Write(mass[i, j] + "   ");
                    }
                    Console.WriteLine();
                }

                for (int i = 0; i < n; i++)
                {
                    int k = 0;
                    for (int j = 0; j < n; j++)
                    {
                        if (mass[j, i] < mass[k, i])
                        {
                            k = j;
                        }
                    }
                    mass[k, i] = 0;
                }
                Console.WriteLine();
                Console.WriteLine("Минимум заменён нулем:");
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        Console.Write(mass[i, j] + "   ");
                    }
                    Console.WriteLine();
                }
            }
            catch (Exception E)
            {
                Console.WriteLine(E.Message);
            }
            Console.ReadKey();
        }
    }
}
