using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class CustomerRepository
    {
        public Customer Retrieve(int customerId) {

            Customer customer = new Customer(customerId);

                // code that retrieves the defined customer

            if(customerId == 1)
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
