using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class B1 : A
    {
        public new void F_Thuong()
        {
            Console.WriteLine("Ham binh thuong - Lop B1");
        }
        public override void F_Ao()
        {
            Console.WriteLine("Ham Ao - Lop B1");
        }
    }
    class B2 : A
    {
        public new void F_Thuong()
        {
            Console.WriteLine("Ham binh thuong - Lop B2");
        }
        public override void F_Ao()
        {
            Console.WriteLine("Ham Ao - Lop B2");
        }
    }
    internal class MatPhang
    {
        public HinhTron[] DanhSachHinhTron;
        public HinhChuNhat[] DanhSachHinhChuNhat;

        public void Nhap(string ghiChu)
        {
            Console.WriteLine(ghiChu);
            Console.WriteLine("Nhap so luong hinh tron:");
            int n = int.Parse(Console.ReadLine());
            DanhSachHinhTron = new HinhTron[n];
            for (int i = 0; i < n; i++)
            {
                DanhSachHinhTron[i] = new HinhTron();
                DanhSachHinhTron[i].Nhap($"Nhap hinh tron thu {i + 1}");
            }

            Console.WriteLine("Nhap so luong hinh chu nhat:");
            n = int.Parse(Console.ReadLine());

            DanhSachHinhChuNhat = new HinhChuNhat[n];
            for (int i = 0;i < n; i++)
            {
                DanhSachHinhChuNhat[i] = new HinhChuNhat();
                DanhSachHinhChuNhat[i].Nhap($"Nhap hinh chu nhat thu {i + 1}");
            }
        }
        public double TinhTongChuVi()
        {
            double t = 0;
            for (int i = 0; i < DanhSachHinhTron.Length; i++)
            {
                t = t + DanhSachHinhTron[i].TinhChuVi();
            }
            for (int i = 0; i < DanhSachHinhChuNhat.Length; i++)
            {
                t = t + DanhSachHinhChuNhat[i].TinhChuVi();
            }
            return t;
        }
    }
}
