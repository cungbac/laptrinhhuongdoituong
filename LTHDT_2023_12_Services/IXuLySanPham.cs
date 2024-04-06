using LTHDT_2023_12_Entities;

namespace LTHDT_2023_12_Services
{
    public interface IXuLySanPham
    {
        List<SanPham> DocDanhSachSanPham(string tuKhoa);
        void ThemSanPham(SanPham sanPham);
    }
}