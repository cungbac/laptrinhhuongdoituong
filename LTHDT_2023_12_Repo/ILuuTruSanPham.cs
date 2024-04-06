using LTHDT_2023_12_Entities;


namespace LTHDT_2023_12_Repo
{
    public interface ILuuTruSanPham
    {
        List<SanPham> DocDanhSachSanPham();
        void LuuDanhSachSanPham(List<SanPham> dsSanPham);
        void ThemSanPham(SanPham sp);

    }
}