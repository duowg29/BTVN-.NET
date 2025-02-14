using System;
using System.Linq;

namespace BTVN_B3
{
    internal class Mang1Chieu
    {
        private int n;
        private int[] a;

        public Mang1Chieu(int n)
        {
            this.n = n;
            a = new int[n];
        }

        public void NhapMang()
        {
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Nhap phan tu thu {i + 1}: ");
                a[i] = Convert.ToInt32(Console.ReadLine());
            }
        }

        public void InMang()
        {
            Console.WriteLine("Mang: " + string.Join(" ", a));
        }

        public void SapXep(int thutu)
        {
            if (thutu == 0)
                Array.Sort(a);
            else if (thutu == 1)
                Array.Sort(a, (x, y) => y.CompareTo(x));
        }

        public int TimKiem(int m)
        {
            for (int i = 0; i < n; i++)
            {
                if (a[i] == m)
                    return i;
            }
            return -1;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nhap so phan tu cua mang: ");
            int n = Convert.ToInt32(Console.ReadLine());

            Mang1Chieu mang = new Mang1Chieu(n);
            mang.NhapMang();
            mang.InMang();

            Console.Write("Nhap cach sap xep (0: Tang dan, 1: Giam dan): ");
            int thutu = Convert.ToInt32(Console.ReadLine());
            mang.SapXep(thutu);
            mang.InMang();

            Console.Write("Nhap so can tim: ");
            int m = Convert.ToInt32(Console.ReadLine());
            int viTri = mang.TimKiem(m);
            if (viTri == -1)
                Console.WriteLine("Khong tim thay phan tu trong mang.");
            else
                Console.WriteLine($"Phan tu {m} nam o vi tri {viTri}.");

            Console.ReadKey();
        }
    }
}
