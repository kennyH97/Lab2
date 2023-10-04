using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    internal class _4
    {
        public void VeHinh()
        {
            int n;
            Console.Write("Nhap mot so: ");
            n = Convert.ToInt32(Console.ReadLine());

            // a)
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            // b)
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (j <= n - 1 - i)
                    {
                        Console.Write("$");
                    }
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            // c)
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < 2 * n - 1; j ++)
                {
                    if (j >= n - 1 - i && j <= n - 1 + i)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
