using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    internal class _7
    {
        public void LaiSuat()
        {
            int soTienGui, soThangGui;
            double laiSuatNganHang, laiSuatThang, tienLaiThang, tienTrongTaiKhoan, laiCuoiKy = 0;
            Console.Write("Nhap so tien gui ngan hang: ");
            soTienGui = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhap so thang gui tien: ");
            soThangGui = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhap lai suat: ");
            laiSuatNganHang = Convert.ToDouble(Console.ReadLine());

            tienTrongTaiKhoan = soTienGui;
            laiSuatThang = laiSuatNganHang / 12 / 100;
            for (int i = 1; i <= soThangGui; i++)
            {
                tienLaiThang = tienTrongTaiKhoan * laiSuatThang;
                tienTrongTaiKhoan = tienTrongTaiKhoan + tienLaiThang;
                laiCuoiKy += tienLaiThang;
            }
            Console.WriteLine($"So du cuoi ky la: {tienTrongTaiKhoan}");
            Console.WriteLine($"Tien lai cuoi ky la: {laiCuoiKy}");

        }
    }
}
