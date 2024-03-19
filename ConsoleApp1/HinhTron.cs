using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    // Tinh da hinh - ham thuong - ham ao
    class A
    {
        public void F_Thuong()
        {
            Console.WriteLine("Ham FA binh thuong");
        }
        public virtual void F_Ao()
        {
            Console.WriteLine("Ham FA Ao");
        }
    }
    internal class HinhTron : Hinh
    {        
        public Diem Tam { get; set; }
        public double BanKinh { get; set; }
        public override void Nhap(string ghiChu)
        {
            base.Nhap(ghiChu);
            Tam = new Diem();
            Tam.NhapDiem("Nhap toa do tam hinh tron:");
            Console.WriteLine("Nhap ban kinh:");
            BanKinh = double.Parse(Console.ReadLine());
        }
        public override double TinhChuVi()
        {
            double chuVi = 2 * BanKinh * Math.PI;
            return chuVi;
        }
    }
}
