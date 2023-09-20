using bai10;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai10
{
    class Program
    {
        static void Main(string[] args)
        {
            List<OrderDetail> lineItems = new List<OrderDetail>();
            lineItems.Add(new OrderDetail(new Product("Nuoc tuong", "sp4", 8000), 10));
            lineItems.Add(new OrderDetail(new Product("Gao", "sp1", 18000), 5));
            lineItems.Add(new OrderDetail(new Product("Duong", "sp3", 10000), 1));
            lineItems.Add(new OrderDetail(new Product("Gao", "sp1", 18000), 1));

            Order or = new Order(1, new DateTime(2015, 09, 10), lineItems);
            or.ShowOrder();
            Console.ReadLine();
        }
    }
}