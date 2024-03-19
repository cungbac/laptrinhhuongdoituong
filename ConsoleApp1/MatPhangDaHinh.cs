using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class TaoLapHinh
    {
        public static Hinh TaoDoiTuongHinh(int loai)
        {
            if (loai == 1)
            {
                return new HinhTron();
            }
            else
            {
                return new HinhChuNhat();
            }
        }
    }
    internal class MatPhangDaHinh
    {
        // Thanh phan du lieu
        private string _ten;
        private Hinh[] _dsHinh;

        // Thanh phan xu ly
        public void Nhap(string ghiChu)
        {
            Console.WriteLine(ghiChu);
            Console.WriteLine("Nhap so luong hinh:");
            int n = int.Parse(Console.ReadLine());

            _dsHinh = new Hinh[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write("Nhap loai hinh: 1 - Tron, 2 - Hinh chu nhat");
                int loai = int.Parse(Console.ReadLine());

                _dsHinh[i] = TaoLapHinh.TaoDoiTuongHinh(loai);
                _dsHinh[i].Nhap($"Nhap thong tin hinh thu {i}");
            }
        }
        public double TinhTongChuVi()
        {
            double t = 0;
            for (int i = 0; i < _dsHinh.Length; i++)
            {
                t = t + _dsHinh[i].TinhChuVi();
            }
            return t;
        }
    }
}
