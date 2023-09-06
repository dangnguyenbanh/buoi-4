using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace buoi4
{
    class Program
    {
        static void Main(string[] args)
        {
            ToaDo td = new ToaDo("O",5,5);
            HinhTron ht = new HinhTron(10.5,td);
            ht.xuat();
            Console.ReadKey();
        }
       
    }
}
