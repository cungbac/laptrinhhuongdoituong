namespace LTHDT_2023_12_Entities
{
    public class SanPham
    {
        public int MaSanPham { get; set; }
        public string TenSanPham {  set; get; }
        public double Gia {  get; set; }
        public SanPham(string ten, double gia)
        {
            if (string.IsNullOrEmpty(ten))
            {
                throw new Exception("Ten khong hop le");
            }
            if (gia < 0)
            {
                throw new Exception("Gia khong hop le");
            }
            TenSanPham = ten;
            Gia = gia;
        }
        public SanPham(string s)
        {
            string[] m = s.Split(',');
            MaSanPham = int.Parse(m[0]);
            TenSanPham = m[1];
            Gia = double.Parse(m[2]);
        }
    }
}