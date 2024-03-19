using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Diem
    {
        // Thanh phan mang thong tin
        public int X { get; set; }
        public int Y { get; set; }

        // Ham tao
        public Diem()
        {

        }
        public Diem(int x, int y) 
        {
            X = x;
            Y = y;
        }
        // Thanh phan xu ly
        public void NhapDiem(string ghiChu)
        {
            Console.WriteLine(ghiChu);
            Console.WriteLine("Nhap toa do x: ");
            X = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap toa do y: ");
            Y = int.Parse(Console.ReadLine());
        }

        public double TinhKhoangCach(Diem m)
        {
            double kq;
            kq = Math.Sqrt((X - m.X) * (X - m.X) + (Y - m.Y) * (Y - m.Y));
            return kq;
        }
    }
}

