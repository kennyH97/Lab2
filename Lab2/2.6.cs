using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Lab2
{
    internal class _6
    {
        public void tamGiac()
        {
            int n, i = 1, j = 1, k = 1;
            n = Convert.ToInt32(Console.ReadLine());
            for (i = 1; i <= n; i++)
            {
                int p = i;
                for (j = 1; j <= 2 * n - 1; j++)
                {
                    if (j == n)
                    {
                        if (k >= 10)
                        {
                            k = k % 10;
                        }
                        Console.Write("{0} ", k);
                    }
                    else if (j >= n - i + 1 && j < n && i > 1)
                    {
                        if (p < 10)
                        {
                            Console.Write("{0} ", p++);
                        }
                        else
                        {
                            Console.Write("{0} ", p % 10);
                            p++;
                        }
                    }
                    else if (j <= n + i - 1 && j > n && i > 1)
                    {
                        --p;
                        if (p >= 10)
                        {
                            Console.Write("{0} ", p % 10);
                        }
                        else
                        {
                            Console.Write("{0} ", p);
                        }
                    }
                    else
                    {
                        Console.Write("  ");
                    }
                }
                k += 2;
                Console.WriteLine();
            }
        }
    }
}
