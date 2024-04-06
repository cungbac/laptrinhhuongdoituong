using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LTHDT_2023_12_Entities;

namespace LTHDT_2023_12_Repo
{
    public class LuuTruSanPham : ILuuTruSanPham
    {
        private string _filePath = "D:\\1.Learning\\24.KHTN\\1.VB2\\10.LapTrinhHuongDoiTuong\\ConsoleApplications\\ConsoleApp1\\LTHDT_2023_12_Repo\\data.txt";
        public List<SanPham> DocDanhSachSanPham()
        {
            List<SanPham> dsSanPham = new List<SanPham>();
            StreamReader file = new StreamReader(_filePath);

            int n;
            string s = file.ReadLine();
            n = int.Parse(s);
            for (int i = 0; i < n; i++)
            {
                s = file.ReadLine();
                dsSanPham.Add(new SanPham(s));
            }
            file.Close();
            return dsSanPham;
        }
        public void LuuDanhSachSanPham(List<SanPham> dsSanPham)
        {
            StreamWriter writer = new StreamWriter(_filePath);
            writer.WriteLine(dsSanPham.Count());

            foreach (var sp in dsSanPham)
            {
                writer.WriteLine($"{sp.MaSanPham}, {sp.TenSanPham}, {sp.Gia}");
            }
            writer.Close();
        }
        public void ThemSanPham(SanPham sp)
        {
            List<SanPham> dsSanPham = DocDanhSachSanPham();
            dsSanPham.Add(sp);
            LuuDanhSachSanPham(dsSanPham);
        }
    }
}
