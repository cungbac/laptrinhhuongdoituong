using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class NhanVienSanXuat : NhanVien
    {
        private int _sanPham;
        public int SanPham
        {
            get { return _sanPham; }
            set
            {
                if (value > 1 && value <= 10)
                {
                    _sanPham = value;
                }
            }
        }

        public NhanVienSanXuat(string hoTen = ""): base(hoTen)
        {
            Console.WriteLine("HAM TAO NHAN VIEN SAN XUAT");
        }
        // Them tu khoa new de xac dinh cai dat lai ham Nhap (Ke thua tu NhanVien)
        public override void Nhap(string ghiChu)
        {
            base.Nhap(ghiChu); // Goi vao ham Nhap cua lop NhanVien
            Console.WriteLine("Nhap so san pham:");
            _sanPham = int.Parse(Console.ReadLine());

        }
        public override double TinhLuong()
        {
            return SanPham * 100;
        }
    }
}
