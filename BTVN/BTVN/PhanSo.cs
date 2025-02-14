using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTVN_B1
{
    internal class PhanSo
    {
        private int TuSo;
        private int MauSo;

        public PhanSo()
        {
            TuSo = 0;
            MauSo = 1;
        }

        public PhanSo(int tu, int mau)
        {
            if (mau == 0)
            {
                throw new ArgumentException("Mau so khong the bang 0");
            }
            TuSo = tu;
            MauSo = mau;
            RutGon();
        }

        public void NhapPhanSo()
        {
            Console.Write("Nhap tu so: ");
            TuSo = int.Parse(Console.ReadLine());
            do
            {
                Console.Write("Nhap mau so (khac 0): ");
                MauSo = int.Parse(Console.ReadLine());
            } while (MauSo == 0);
            RutGon();
        }

        public void InPhanSo()
        {
            Console.WriteLine($"{TuSo}/{MauSo}");
        }

        private void RutGon()
        {
            int ucln = UCLN(Math.Abs(TuSo), Math.Abs(MauSo));
            TuSo /= ucln;
            MauSo /= ucln;
            if (MauSo < 0)
            {
                TuSo = -TuSo;
                MauSo = -MauSo;
            }
        }

        private int UCLN(int a, int b)
        {
            while (b != 0)
            {
                int temp = b;
                b = a % b;
                a = temp;
            }
            return a;
        }

        public PhanSo Cong(PhanSo p)
        {
            return new PhanSo(TuSo * p.MauSo + MauSo * p.TuSo, MauSo * p.MauSo);
        }

        public PhanSo Tru(PhanSo p)
        {
            return new PhanSo(TuSo * p.MauSo - MauSo * p.TuSo, MauSo * p.MauSo);
        }

        public PhanSo Nhan(PhanSo p)
        {
            return new PhanSo(TuSo * p.TuSo, MauSo * p.MauSo);
        }

        public PhanSo Chia(PhanSo p)
        {
            return new PhanSo(TuSo * p.MauSo, MauSo * p.TuSo);
        }
    }

    class Program
    {
        static void Main()
        {
            PhanSo ps1 = new PhanSo();
            ps1.NhapPhanSo();
            PhanSo ps2 = new PhanSo();
            ps2.NhapPhanSo();

            Console.Write("Phan so thu nhat: ");
            ps1.InPhanSo();
            Console.Write("Phân số thứ hai: ");
            ps2.InPhanSo();

            Console.Write("Tong: ");
            ps1.Cong(ps2).InPhanSo();
            Console.Write("Hieu: ");
            ps1.Tru(ps2).InPhanSo();
            Console.Write("Tich: ");
            ps1.Nhan(ps2).InPhanSo();
            Console.Write("Thuong: ");
            ps1.Chia(ps2).InPhanSo();
        }
    }
}
