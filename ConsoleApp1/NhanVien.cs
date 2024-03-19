using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal abstract class NhanVien
    {
        public NhanVien()
        {
            Console.WriteLine("HAM TAO NHAN VIEN");
        }
        public NhanVien(string ten)
        {
            this.HoTen = ten;
            Console.WriteLine($"HAM TAO NHAN VIEN {ten}");
        }
        public string HoTen { get; set; }
        public string DiaChi { get; set; }
        public string CCCD { get; set; }
        public virtual void Nhap(string ghiChu)
        {
            Console.WriteLine(ghiChu);
            Console.WriteLine("Nhap ho ten:");
            HoTen = Console.ReadLine();
            Console.WriteLine("Nhap dia chi:");
            DiaChi = Console.ReadLine();
            Console.WriteLine("Nhap CCCD:");
            CCCD = Console.ReadLine();
        }
        public abstract double TinhLuong();
    }
}
