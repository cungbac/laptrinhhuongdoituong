// See https://aka.ms/new-console-template for more information

using System.Diagnostics.CodeAnalysis;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;

namespace ConsoleApp1
{
    class Programm
    {
        public static void PlaySounds(IAnimalSound a)
        {
            a.sound();
        }
        static void Main(string[] args)
        {
            Bird a = new Bird();
            a.fly();
            a.sound();

            Dog d = new Dog();
            d.sound();
            d.run();

            PlaySounds(a);
            PlaySounds(d);
            /*
            A a;
            a = new B1();
            a.F_Thuong();
            a.F_Ao();

            a = new B2();
            a.F_Thuong();
            a.F_Ao();
            /*
            NhanVienSanXuat nvsx = new NhanVienSanXuat();
            nvsx.Nhap("Nhap nhan vien:");
            /*
            TamGiac tg1;
            try
            {
                tg1 = new TamGiac(new Diem(0, 0), new Diem(1, 2), new Diem(2, 2));
                Console.WriteLine(TamGiac.DemSoLuongDoiTuong());

                TamGiac tg2 = new TamGiac(new Diem(0,9), new Diem(1,2), new Diem(2,9));
                Console.WriteLine(TamGiac.DemSoLuongDoiTuong());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return;
            }

            bool kiemTra = TamGiac.KiemTraTamGiac(
                new Diem(0, 0), new Diem(1, 1), new Diem(1, 2)
                );
            Console.WriteLine(kiemTra);

            CongTy CtyA = new CongTy();
            CtyA.Nhap("Nhap thong tin cong ty");

            NhanVienVanPhong Nv1 = new NhanVienVanPhong("Nam");
            Console.WriteLine($"Ten nhan vien la: {Nv1.HoTen}");

            Nv1.Nhap("Nhap thong tin nhan vien 1:");

            double LuongNv1 = Nv1.TinhLuong();
            Console.WriteLine($"Luong nhan vien 1: {LuongNv1}");
            /*
            Car Ford = new Car("Mustang", "red", 1969, 100);
            // Ford.model = "Mustang";
            // Ford.color = "red";
            // Ford.year = 1969;

            Car Opel = new Car("Astra", "white", 2005, 200);
            // Opel.model = "Astra";
            // Opel.color = "white";
            // Opel.year = 2005;

            Car Toyota = new Car("xyz", "blue", 2015, 250);

            Console.WriteLine(Ford.model);
            Console.WriteLine(Opel.model);
            Console.WriteLine(Toyota.model);

            Ford.fullThrottle();

            Person per1 = new Person();
            per1.Name = "Test";
            per1.Age = 10;
            Console.WriteLine(per1.Age);

            Diem d1 = new Diem();
            Console.WriteLine($"Diem d1 la: {d1.X}-{d1.Y}");

            // Phan so
            /// Class
            LopPhanSo p1, p2;
            p1 = new LopPhanSo();
            p2 = new LopPhanSo();
            // yeu cau doi tuong p1 thuc hien hanh dong
            p1.NhapPhanSo("Nhap phan so a: ");
            // yeu cau doi tuong p2 thuc hien hanh dong
            p2.NhapPhanSo("Nhap phan so b: ");
            // Yeu cau p1 thuc hien hanh dong cong voi p2
            LopPhanSo kq;
            kq = p1.CongPS(p2);
            string chuoi = "Ket qua la " + kq.XuatPhanSo();
            Console.WriteLine(chuoi);

            LopPhanSo p5 = new LopPhanSo();
            p5.TuSo = 1;
            p5.MauSo = 2;
            Console.WriteLine(p5.XuatPhanSo());
            // Struct
            PHANSO p3, p4;
            p3 = XuLyPhanSo.NhapPhanSo("Nhap phan so a: ");
            p4 = XuLyPhanSo.NhapPhanSo("Nhap phan so b: ");
            PHANSO kq2;
            kq2 = XuLyPhanSo.Cong2PhanSo(p3, p4);
            string chuoi2 = "Ket qua la " + XuLyPhanSo.XuatPhanSo(kq2);
            Console.WriteLine(chuoi2);


            // Tao lap doi tuong tam giac
            // Su dung constructor
            Diem A = new Diem();
            A.NhapDiem("Nhap diem A");
            Diem B = new Diem();
            B.NhapDiem("Nhap diem B");
            Diem C = new Diem();
            C.NhapDiem("Nhap diem C");
            TamGiac tg = new TamGiac(A, B, C) ;

            // Yeu cau doi tuong thuc hien hanh dong Nhap
            //tg.NhapTamGiac("Nhap tam giac: ");
            // Yeu cau doi tuong thuc hien hanh dong Tinh Chu Vi
            double chuViTg = tg.TinhChuVi();
            Console.WriteLine(chuViTg);

            // Tao lap doi tuong da giac
            DaGiac dg = new DaGiac();
            // Yeu cau doi tuong thuc hien hanh dong Nhap
            dg.Nhap("Nhap da giac: ");
            // Yeu cau doi tuong thuc hien hanh dong Tinh Chu Vi
            double chuViDg = dg.TinhChuVi();
            Console.WriteLine($"Chu vi da giac: {chuViDg}");
            */

        }
    }
}

