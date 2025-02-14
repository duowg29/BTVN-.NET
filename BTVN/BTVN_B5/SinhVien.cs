using System;

namespace BTVN_B5
{
    internal class SinhVien
    {
        private string MaSV;
        private string HoTen;
        private int NamSinh;
        private string QueQuan;
        private double DiemLapTrinh;
        private double DiemCSDL;
        private double DiemTB;

        public SinhVien()
        {
            MaSV = "";
            HoTen = "";
            NamSinh = 0;
            QueQuan = "";
            DiemLapTrinh = 0;
            DiemCSDL = 0;
            DiemTB = 0;
        }

        public SinhVien(string maSV, string hoTen, int namSinh, string queQuan, double diemLapTrinh, double diemCSDL)
        {
            MaSV = maSV;
            HoTen = hoTen;
            NamSinh = namSinh;
            QueQuan = queQuan;
            DiemLapTrinh = diemLapTrinh;
            DiemCSDL = diemCSDL;
            TinhDiemTB();
        }

        public void NhapSinhVien()
        {
            Console.Write("Nhap ma sinh vien: ");
            MaSV = Console.ReadLine();
            Console.Write("Nhap ho ten: ");
            HoTen = Console.ReadLine();
            Console.Write("Nhap nam sinh: ");
            NamSinh = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhap que quan: ");
            QueQuan = Console.ReadLine();
            Console.Write("Nhap diem lap trinh: ");
            DiemLapTrinh = Convert.ToDouble(Console.ReadLine());
            Console.Write("Nhap diem CSDL: ");
            DiemCSDL = Convert.ToDouble(Console.ReadLine());
            TinhDiemTB();
        }

        private void TinhDiemTB()
        {
            DiemTB = (DiemLapTrinh + DiemCSDL) / 2;
        }

        public void InSinhVien()
        {
            Console.WriteLine($"Ma sinh vien: {MaSV}");
            Console.WriteLine($"Ho ten: {HoTen}");
            Console.WriteLine($"Nam sinh: {NamSinh}");
            Console.WriteLine($"Que quan: {QueQuan}");
            Console.WriteLine($"Diem lap trinh: {DiemLapTrinh}");
            Console.WriteLine($"Diem CSDL: {DiemCSDL}");
            Console.WriteLine($"Diem trung binh: {DiemTB}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            SinhVien sv = new SinhVien();
            sv.NhapSinhVien();
            sv.InSinhVien();
            Console.ReadKey();
        }
    }
}
