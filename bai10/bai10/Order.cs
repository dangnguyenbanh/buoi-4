using bai10;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace bai10
{
    class Order
    {
        private int _orderID;

        public int OrderID
        {
            get { return _orderID; }
            set { _orderID = value; }
        }
        private DateTime _orderDate;

        public DateTime OrderDate
        {
            get { return _orderDate; }
            set { _orderDate = value; }
        }

        private List<OrderDetail> _lineItems;

        internal List<OrderDetail> LineItems
        {
            get { return _lineItems; }
            set { _lineItems = value; }
        }
        public Order(int orderID, DateTime orderDate, List<OrderDetail> list)
        {
            this.OrderID = orderID;
            this.OrderDate = orderDate;
            this.LineItems = list;
        }

        public double CalcTotalCharge()
        {
            double ThanhTien = 0;
            foreach (OrderDetail Item in LineItems)
            {
                ThanhTien += Item.CalcTotalPrice();
            }
            return ThanhTien;
        }

        public void ShowOrder()
        {
            Console.WriteLine("Ma hoa don: {0}", OrderID);
            Console.WriteLine("Ngay: {0}", OrderDate);
            Console.WriteLine("{0,-4}|{1, -8}|{2, -12}|{3,8}|{4,8}|{5,12}", "STT", "Ma SP", "Mo ta", "Gia", "SL", "Thanh tien");
            int count = 1;
            foreach (OrderDetail Item in LineItems)
            {
                Console.WriteLine("{0,-4}|{1, -8}|{2, -12}|{3,8}|{4,8}|{5,12} VNĐ", count, Item.Product.ProductID, Item.Product.Description, Item.Product.Price, Item.Quatity, Item.CalcTotalPrice());
                count++;
            }
            Console.WriteLine("Tong tien: {0} VNĐ", CalcTotalCharge());
        }

    }
}