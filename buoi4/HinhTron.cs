using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace buoi4
{
    class HinhTron
    {
        private double BanKinh;

        public double banKinh
        {
            get { return BanKinh; }
            set { BanKinh = value; }
        }
        private ToaDo Tam;

        internal ToaDo Tam1
        {
            get { return Tam; }
            set { Tam = value; }
        }

        
        public HinhTron(double BanKinh,ToaDo Tam)
        {
            this.BanKinh = BanKinh;
            this.Tam = Tam;
        }
        public HinhTron()
        { 

        }
        public double TinhChuVi()
        {
            return 3.14 * 2 * BanKinh;
        }
        public double TinhdienTich()
        {
            return 3.14 * BanKinh * BanKinh;
        }
       public void xuat()
        {
            Console.WriteLine("Tam duong tron la {0}({1}; {2}),Ban kinh hinh tron la {3}, Chu vi hinh tron la{4}, Dien tich hinh tron la{5}", Tam.Diem, Tam.X, Tam.Y, BanKinh, TinhChuVi(), TinhdienTich());
        }

    }
}
