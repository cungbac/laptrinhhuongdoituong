using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class TaoLapNhanVien
    {
        public static NhanVien TaoNhanVien(int loai)
        {
            if (loai == 1)
            {
                return new NhanVienSanXuat();
            }
            else
            {
                return new NhanVienVanPhong();
            }
        }
    }
    internal class CongTyDaHinh
    {
        // Thanh phan du lieu
        private string _ten;
        private NhanVien[] _dsNhanVien;

        // Thanh phan xu ly
        public void Nhap(string ghiChu)
        {
            Console.WriteLine(ghiChu);
            Console.WriteLine("Nhap ten cong ty:");
            _ten = Console.ReadLine();
            Console.WriteLine("Nhap so luong nhan vien san xuat:");
            int n = int.Parse(Console.ReadLine());
            _dsNhanVien = new NhanVien[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write("Nhap loai nhan vien (1 - NVSX, 2 - NVVP)");
                int loai = int.Parse(Console.ReadLine());
                _dsNhanVien[i] = TaoLapNhanVien.TaoNhanVien(loai);
                /* Neu khong co ham Tao nhan vien thi dung cach nay
                if (loai == 1)
                {
                    _dsNhanVien[i] = new NhanVienSanXuat();
                }
                else
                {
                    _dsNhanVien[i] = new NhanVienVanPhong();
                }
                */
                _dsNhanVien[i].Nhap($"Nhap thong tin nhan vien thu {i}");
            }
        }
        public double TinhTongLuong()
        {
            double s = 0;
            for (int i = 0; i < _dsNhanVien.Length; i++)
            {
                s = s + _dsNhanVien[i].TinhLuong();
            }
            return s;
        }
    }
}
