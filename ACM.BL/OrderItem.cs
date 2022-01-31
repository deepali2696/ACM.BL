using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class OrderItem
    {

        public OrderItem()
        {

        }

        public OrderItem(int orderItemId)
        {
            orderItemId = orderItemId;
        }

        public int orderItemId { get; private set; }

        public int productId { get; private set; }

        public int quantity { get; set; }

        public decimal? purchasePrice { get; set; }

        public bool Validate()
        {
            var isValid = true;

            if(quantity <= 0) isValid = false;
            if(productId <= 0) isValid = false;
            if (purchasePrice == null) isValid = false;
            if (purchasePrice <= 0) isValid = false;

            return isValid;
        }


        public OrderItem Retrieve(int orderItemId)
        {
            return new OrderItem();
        }

        public List<OrderItem> Retrieve() // default constructor method
        {
            return new List<OrderItem>();
        }

        public bool Save()
        {
            return true;
        }
    }
}
