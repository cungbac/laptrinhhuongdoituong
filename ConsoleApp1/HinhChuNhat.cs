using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class HinhChuNhat : Hinh
    {
        public Diem A { get; set; }
        public double ChieuDai { get; set; }
        public double ChieuRong { get; set; }

        public override void Nhap(string ghiChu)
        {
            base.Nhap(ghiChu);
            A = new Diem();
            A.NhapDiem("Nhap diem A:");
            Console.WriteLine("Nhap chieu dai:");
            ChieuDai = double.Parse(Console.ReadLine());
            Console.WriteLine("Nhap chieu rong:");
            ChieuRong = double.Parse(Console.ReadLine());
        }
        public override double TinhChuVi()
        {
            double chuVi = (ChieuDai + ChieuRong) * 2;
            return chuVi;
        }
    }
}
