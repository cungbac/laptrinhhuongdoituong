using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class CongTy
    {
        // Thanh phan du lieu
        private string _ten;
        private NhanVienSanXuat[] _dsSanXuat;
        private NhanVienVanPhong[] _dsVanPhong;

        // Thanh phan xu ly
        public void Nhap(string ghiChu)
        {
            Console.WriteLine(ghiChu);
            Console.WriteLine("Nhap ten cong ty:");
            _ten = Console.ReadLine();
            Console.WriteLine("Nhap so luong nhan vien san xuat:");
            int n = int.Parse(Console.ReadLine());
            _dsSanXuat = new NhanVienSanXuat[n];
            for (int i = 0; i < n; i++)
            {
                _dsSanXuat[i] = new NhanVienSanXuat();
                _dsSanXuat[i].Nhap($"Nhap thong tin nhan vien san xuat thu {i}");
            }
            Console.WriteLine("Nhap so luong nhan vien van phong:");
            n = int.Parse(Console.ReadLine());
            _dsVanPhong = new NhanVienVanPhong[n];
            for (int i = 0; i < n; i++)
            {
                _dsVanPhong[i] = new NhanVienVanPhong();
                _dsVanPhong[i].Nhap($"Nhap thong tin nhan vien van phong thu {i}");
            }
        }
        public double TinhTongLuong()
        {
            double s = 0;
            for (int i = 0; i < _dsSanXuat.Length; i++)
            {
                s = s + _dsSanXuat[i].TinhLuong();
            }
            for (int i = 0; i < _dsVanPhong.Length; i++)
            {
                s = s + _dsVanPhong[i].TinhLuong();
            }
            return s;
        }
    }
}
