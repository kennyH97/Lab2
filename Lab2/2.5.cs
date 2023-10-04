using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    internal class _5
    {
        public void XetTamGiac()
        {
            int a, b, c;
            Console.Write("Nhap a: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhap b: ");
            b = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhap c: ");
            c = Convert.ToInt32(Console.ReadLine());

            if (a + b > c && a + c > b && b + c > a && a > 0 && b > 0 && c > 0)
            {
                Console.WriteLine("Day la do dai 3 canh cua mot tam giac");
                if (a == b && b == c)
                {
                    Console.WriteLine("Tam giac deu");
                }
                else if (a == b || b == c || a == c)
                {
                    Console.WriteLine("Tam giac can");
                }
                else if (a * a + b * b == c * c || a * a + c * c == b * b || b * b + c * c == a * a)
                {
                    Console.WriteLine("Tam giac vuong");
                }
                else
                {
                    Console.WriteLine("Tam giac thuong");
                }
            }
            else
            {
                Console.WriteLine("Day khong phai do dai 3 canh cua mot tam giac");
            }
        }
    }
}
