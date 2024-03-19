using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class NhanVienVanPhong : NhanVien
    {
        private double _heSoLuong;
        private double _phuCap;

        public double HeSoLuong
        {
            get { return _heSoLuong; }
            set
            {
                if (value > 1 && value <= 10)
                {
                    _heSoLuong = value;
                }
            }
        }
        public double PhuCap
        {
            get { return _phuCap; }
            set
            {
                if (value >= 0 && value <= 1000)
                {
                    _phuCap = value;
                }
            }
        }
        public NhanVienVanPhong(string hoTen = "")
        {
            HoTen = hoTen;
            HeSoLuong = 1;
            PhuCap = 0;
        }
        public override void Nhap(string ghiChu)
        {
            base.Nhap(ghiChu); // Goi vao ham Nhap cua lop NhanVien
            Console.WriteLine("Nhap he so luong:");
            _heSoLuong = double.Parse(Console.ReadLine());
            Console.WriteLine("Nhap phu cap:");
            _phuCap = double.Parse(Console.ReadLine());
        }
        public override double TinhLuong()
        {
            return HeSoLuong * 1000 + PhuCap;
        }
    }
}
