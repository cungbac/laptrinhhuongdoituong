using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using LTHDT_2023_12_Entities;
using LTHDT_2023_12_Services;

namespace LTHDT_2023_12_WEB.Pages
{
    public class MH_DanhSach_SanPhamModel : PageModel
    {
        private IXuLySanPham _xuLySanPHam = new XuLySanPham();
        public List<SanPham> DanhSachSanPham;
        public string Chuoi = string.Empty;
        [BindProperty]
        public string TuKhoa { get; set; }
        public void OnGet()
        {
            DanhSachSanPham = _xuLySanPHam.DocDanhSachSanPham("");
        }
        public void OnPost()
        {
            DanhSachSanPham = _xuLySanPHam.DocDanhSachSanPham(TuKhoa);
        }
    }
}
