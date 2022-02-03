using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class CustomerRepository
    {
        public Customer Retrieve(int CustomerId) {

            Customer customer = new Customer(CustomerId);

                // code that retrieves the defined customer

            if(CustomerId == 1)
            {
                customer.FirstName = "Deepali";
                customer.LastName = "Patel";
                customer.EmailAddress = "abcd@gmail.com";
            }
            return customer;
        }

        public bool Save()
        {
            return true;
        }
    }
}
