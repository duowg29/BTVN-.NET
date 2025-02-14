using System;

namespace BTVN_B4
{
    internal class NhanVien
    {
        private string HoTen;
        private int NamSinh;
        private string DiaChi;
        private double LuongCoBan;
        private double HeSo;
        private double PhuCap;
        private double TongTien;

        public NhanVien()
        {
            HoTen = "";
            NamSinh = 0;
            DiaChi = "";
            LuongCoBan = 0;
            HeSo = 0;
            PhuCap = 0;
            TongTien = 0;
        }

        public void NhapNhanVien()
        {
            Console.Write("Nhap ho ten: ");
            HoTen = Console.ReadLine();
            Console.Write("Nhap nam sinh: ");
            NamSinh = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhap dia chi: ");
            DiaChi = Console.ReadLine();
            Console.Write("Nhap luong co ban: ");
            LuongCoBan = Convert.ToDouble(Console.ReadLine());
            Console.Write("Nhap he so luong: ");
            HeSo = Convert.ToDouble(Console.ReadLine());
            Console.Write("Nhap phu cap: ");
            PhuCap = Convert.ToDouble(Console.ReadLine());
            TinhLuong();
        }

        private void TinhLuong()
        {
            TongTien = LuongCoBan * HeSo + PhuCap;
        }

        public void InNhanVien()
        {
            Console.WriteLine($"Ho ten: {HoTen}");
            Console.WriteLine($"Nam sinh: {NamSinh}");
            Console.WriteLine($"Dia chi: {DiaChi}");
            Console.WriteLine($"Luong co ban: {LuongCoBan}");
            Console.WriteLine($"He so: {HeSo}");
            Console.WriteLine($"Phu cap: {PhuCap}");
            Console.WriteLine($"Tong tien: {TongTien}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            NhanVien nv = new NhanVien();
            nv.NhapNhanVien();
            nv.InNhanVien();
            Console.ReadKey();
        }
    }
}
