using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    internal class _3
    {
        public void InSoCoTong3KySoLaChan()
        {
            for (int i = 100; i <= 999; i++)
            {               
                if ((i / 100 + i / 10 % 10 + i % 10) % 2 == 0)
                {
                    Console.WriteLine($"{i}");
                }
            }
        }
    }
}
