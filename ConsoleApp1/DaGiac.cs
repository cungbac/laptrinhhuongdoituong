using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class DaGiac
    {
        // Thanh phan du lieu
        public Diem[] DanhSachDinh;

        // Thanh phan xu ly
        public void Nhap(string ghiChu)
        {
            Console.WriteLine(ghiChu);
            Console.WriteLine("Nhap so dinh cua da giac: ");
            int n = int.Parse(Console.ReadLine());
            DanhSachDinh = new Diem[n];
            for (int i = 0; i < n; i++)
            {
                DanhSachDinh[i] = new Diem();
                DanhSachDinh[i].NhapDiem($"Nhap diem A[{i}]");
            }
        }
        public double TinhChuVi()
        {
            double kq = 0;
            for (int i = 0; i < DanhSachDinh.Length - 1; i++)
            {
                kq = kq + DanhSachDinh[i].TinhKhoangCach(DanhSachDinh[i + 1]);
            }
            kq = kq + DanhSachDinh[0].TinhKhoangCach(DanhSachDinh[DanhSachDinh.Length - 1]);
            return kq;
        }
    }
}
