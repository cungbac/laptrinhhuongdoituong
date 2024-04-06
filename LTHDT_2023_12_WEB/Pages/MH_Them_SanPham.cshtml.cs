using LTHDT_2023_12_Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using LTHDT_2023_12_Entities;
using LTHDT_2023_12_Services;

namespace LTHDT_2023_12_WEB.Pages
{
    public class MH_Them_SanPhamModel : PageModel
    {
        [BindProperty]
        public string MaSanPham { get; set; }
        public string TenSanPham { get; set; }
        public int Gia { get; set; }
        public string Chuoi { get; set; } = string.Empty;
        private IXuLySanPham _xuLySanPham = new XuLySanPham();
        public void OnPost()
        {
            try
            {
                var sp = new SanPham(TenSanPham, Gia);
                sp.Gia = Gia;
                _xuLySanPham.ThemSanPham(sp);
                Response.Redirect("/MH_DanhSach_SanPham");
            }
            catch (Exception ex)
            {
                Chuoi = ex.Message;
            }
        }
    }
}
