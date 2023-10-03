using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    internal class _1
    {
        public void namXthangY()
        {
            int namX, thangY;
            Console.Write("Nhap nam: ");
            namX = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhap thang: ");
            bool namNhuan = true;

            do
            {
                thangY = Convert.ToInt32(Console.ReadLine());
            }
            while (thangY < 1 || thangY > 12);

            if (namX % 400 == 0 || (namX % 4 == 0 & namX % 100 != 0))
            {
                Console.WriteLine("Nam {0} la nam nhuan", namX);
                namNhuan = true;
            }
            else
            {
                Console.WriteLine("Nam {0} la nam khong nhuan", namX);
                namNhuan = false;
            }

            switch (thangY)
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                    Console.WriteLine("Thang {0} co 31 ngay.", thangY);
                    break;
                case 4:
                case 6:
                case 9:
                case 11:
                    Console.WriteLine("Thang {0} co 31 ngay.", thangY);
                    break;
                case 2:
                    if (namNhuan == true)
                    {
                        Console.WriteLine("Thang 2 co 29 ngay.");
                    }
                    else
                    {
                        Console.WriteLine("Thang 2 co 28 ngay.");
                    }
                    break;
            }
            Console.ReadKey();
        }
    }
}
