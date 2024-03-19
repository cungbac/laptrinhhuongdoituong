using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class LopPhanSo
    {
        // Thanh phan mang thong tin
        private int _tuSo;
        private int _mauSo;

        public int TuSo
        {
            get
            {
                return _tuSo;
            }
            set
            {
                _tuSo = value;
            }
        }
        public int MauSo
        {
            get
            {
                return _mauSo;
            }
            set
            {
                if (value != 0)
                {
                    _mauSo = value;
                }
            }
        }
        // Ham tao
        public LopPhanSo()
        {
            _tuSo = 0;
            _mauSo = 1;
        }
        public LopPhanSo(int n, int m)
        {
            _tuSo = n;
            if (m != 0)
            {
                _mauSo = m;
            }
            else
            {
                _mauSo = 1;
            }
        }
        // Thanh phan xu ly
        public void NhapPhanSo(string ghiChu)
        {
            Console.WriteLine(ghiChu);
            Console.WriteLine("Nhap tu so: ");
            _tuSo = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap mau so: ");
            _mauSo = int.Parse(Console.ReadLine());
        }
        public LopPhanSo CongPS(LopPhanSo p2)
        {
            LopPhanSo kq = new LopPhanSo();
            kq._tuSo = _tuSo * p2._mauSo + _mauSo * p2._tuSo;
            kq._mauSo = _mauSo * p2._mauSo;
            return kq;
        }
        public string XuatPhanSo()
        {
            return $"{_tuSo}/{_mauSo}";
        }
    }
}