using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTVN_B2
{
    internal class Diem
    {
        private double x;
        private double y;

        public Diem()
        {
            x = 0;
            y = 0;
        }

        public Diem(double x, double y)
        {
            this.x = x;
            this.y = y;
        }

        public void NhapToaDo()
        {
            Console.Write("Nhap hoanh do x: ");
            x = Convert.ToDouble(Console.ReadLine());
            Console.Write("Nhap tung do y: ");
            y = Convert.ToDouble(Console.ReadLine());
        }

        public void InToaDo()
        {
            Console.WriteLine($"Toa do diem: ({x}, {y})");
        }

        public double TinhKhoangCach(Diem d)
        {
            return Math.Sqrt(Math.Pow(d.x - this.x, 2) + Math.Pow(d.y - this.y, 2));
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Diem diem1 = new Diem();
            diem1.NhapToaDo();
            diem1.InToaDo();

            Diem diem2 = new Diem(3, 4);
            diem2.InToaDo();

            Console.WriteLine($"Khoang cach 2 diem: {diem1.TinhKhoangCach(diem2)}");
            Console.ReadKey();
        }
    }
}
