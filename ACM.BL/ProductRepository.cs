using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class ProductRepository
    {
        public Product Retrieve(int ProductId)
        {
            Product product = new Product();

            if (ProductId == 1)
            {
                product.ProductName = "car";
                product.CurrentPrice = 50;
            }

            return product;
        }

        public bool Save()
        {
            return true;
        }

    }
}
