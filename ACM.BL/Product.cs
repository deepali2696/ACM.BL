using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class Product
    {

        public Product()
        {
            
        }

        public Product(int productId)
        {
            ProductId = productId;
        }

        public int ProductId { get; private set; }
        public string ProductName { get; set; }
        public string ProductDescription { get; set; }
        public decimal? CurrentPrice { get; set; }

        public bool Validate()
        {
            var isValid = true;

            if(CurrentPrice == null) isValid = false;
            if(CurrentPrice < 0) isValid = false;
            if (string.IsNullOrWhiteSpace(ProductName)) isValid = false;
            if (string.IsNullOrWhiteSpace(ProductDescription)) isValid = false;

            return isValid;
        }

        public Product Retrieve(int ProductId)
        {
            // code that retrieves one product will be coded later with UI
            return new Product();
        }

        public List<Product> Retrieve() // default constructor method
        {
            //code that retrieves one product will be coded later with UI
            return new List<Product>();
        }

        public bool Save()
        {

            //code to save the current product

            return true;
        }
    }
}
