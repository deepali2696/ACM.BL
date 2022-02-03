using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ACM.BL;

namespace ACM.BL
{
    public class OrderRepository
    {
        public Order Retrieve(int OrderId)
        {
            Order order = new Order();

            if (OrderId == 1)
            {
                order.ShippingAddress = "Montreal";
                order.OrderItems = 5;
                order.OrderDate = new DateTimeOffset(DateTime.Now.Year, 2, 3, 16, 04, 00, new TimeSpan(7, 0, 0));
            }

            return order;
        }

        public bool Save()
        {
            return true;
        }
    }
}
