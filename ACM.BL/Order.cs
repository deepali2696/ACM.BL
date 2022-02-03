using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class Order
    {

        public Order()
        {

        }

        public Order(int orderId)
        {
            OrderId = orderId;
        }

        public DateTimeOffset? OrderDate { get; set; }

        public int OrderId { get; private set; }
        public string Date { get; set; }
        public string ShippingAddress { get; set; }
        public int OrderItems { get; set; }

        public bool Validate()
        {
            var isValid = true;

            if (OrderDate == null) isValid=false ;

            return isValid;
        }

        public Order Retrieve(int orderId)
        {
            return new Order();
        }

        public List<Order> Retrieve() // default constructor method
        {
            return new List<Order>();
        }

        public bool Save()
        {
            return true;
        }
    }
}
