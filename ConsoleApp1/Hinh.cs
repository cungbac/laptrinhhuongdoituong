using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal abstract class Hinh
    {
        public string MauSac { get; set; }
        public virtual void Nhap(string ghiChu)
        {
            Console.WriteLine(ghiChu);
            Console.WriteLine("Nhap mau sac:");
            MauSac = Console.ReadLine();
        }
        public abstract double TinhChuVi();
    }
}
