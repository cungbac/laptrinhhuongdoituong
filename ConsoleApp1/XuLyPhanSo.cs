using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public struct PHANSO
    {
        public int TuSo;
        public int MauSo;
    }

    public class XuLyPhanSo
    {
        public static PHANSO NhapPhanSo(string ghiChu)
        {
            PHANSO a;
            Console.WriteLine(ghiChu);
            Console.WriteLine("Nhap tu so: ");
            a.TuSo = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap mau so: ");
            a.MauSo = int.Parse(Console.ReadLine());
            return a;
        }
        public static PHANSO Cong2PhanSo(PHANSO a, PHANSO b)
        {
            PHANSO kq;
            kq.TuSo = a.TuSo * b.MauSo + a.MauSo * b.TuSo;
            kq.MauSo = a.MauSo * b.MauSo;
            return kq;
        }
        public static string XuatPhanSo(PHANSO a)
        {
            return $"{a.TuSo}/{a.MauSo}";
        }
    }
}
