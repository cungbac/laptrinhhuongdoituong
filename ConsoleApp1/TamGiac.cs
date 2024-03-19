using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace ConsoleApp1
{
    internal class TamGiac
    {
        // Thanh phan du lieu
        private Diem _a;
        private Diem _b;
        private Diem _c;

        // Bien o muc class, share chung giua tat ca cac doi tuong
        private static int _soLuongDoiTuong = 0;
        // Constructor
        public TamGiac()
        {
            _a = new Diem(0, 0);
            _b = new Diem(0, 1);
            _c = new Diem(1, 0);
            _soLuongDoiTuong++;
        }
        public TamGiac(Diem diemA, Diem diemB, Diem diemC) 
        { 
            if (!KiemTraTamGiac(diemA, diemB, diemC))
            {
                throw new Exception("Tam giac khong hop le");
            }
            _a = diemA;
            _b = diemB;
            _c = diemC;
            _soLuongDoiTuong++;
        }

        // Thanh phan xu ly
        public static bool KiemTraTamGiac(Diem a, Diem b, Diem c)
        {
            double canhA, canhB, canhC;
            canhA = b.TinhKhoangCach(c);
            canhB = a.TinhKhoangCach(c);
            canhC = a.TinhKhoangCach(b);
            return canhA + canhB > canhC
                && canhA + canhC > canhB
                && canhB + canhC > canhA;
        }
        
        public static int DemSoLuongDoiTuong()
        {
            return TamGiac._soLuongDoiTuong;
        }

        public void NhapTamGiac(string ghiChu)
        {
            Console.WriteLine(ghiChu);
            _a = new Diem();
            _a.NhapDiem("Nhap Diem A");

            _b = new Diem();
            _b.NhapDiem("Nhap Diem B");

            _c = new Diem();
            _c.NhapDiem("Nhap Diem C");
        }
        public double TinhChuVi()
        {
            double d1, d2, d3;
            d1 = _a.TinhKhoangCach(_b);
            d2 = _a.TinhKhoangCach(_c);
            d3 = _b.TinhKhoangCach(_c);

            return d1 + d2 + d3;
        }
    }
}
