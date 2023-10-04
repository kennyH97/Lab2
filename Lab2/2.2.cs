using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Lab2
{
    internal class _2
    {
        public void ThoiGian()
        {
            int gio, phut, giay;
            Console.Write("Nhap so giay: ");
            giay = Convert.ToInt32(Console.ReadLine());
            gio = giay /3600;
            phut = giay % 3600 / 60;
            giay = giay % 60;
            Console.WriteLine($"{gio:00}:{phut:00}:{giay:00}");
        }
    }
}
