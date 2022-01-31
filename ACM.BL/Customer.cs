using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class Customer
    {

        //Constructor

        public Customer()
        {

        }

        public Customer(int CustomerId)
        {
            CustomerId = CustomerId;
        }

        public int CustomerId { get; private set; }
        public string EmailAddress { get; set; }
        public string FirstName { get; set; }

        public string FullName
        {
            get
            {

                //if there is only lastname defined, the fullname is the lastname with no comma
                string fullName = LastName;

                if (!string.IsNullOrWhiteSpace(FirstName))
                {
                    if (!string.IsNullOrWhiteSpace(fullName))
                    {
                        //fullName = fullName + ",";
                        fullName += ", ";
                    }

                    fullName += FirstName;
                }

                return fullName;
            }
        }

        public static int InstanceCount { get; set; }

        private string _lastName;
        public string LastName
        {
            get { return _lastName; }
            set { _lastName = value; }
        }

        public bool Validate()
        {
            var isValid = true;
            if (string.IsNullOrWhiteSpace(LastName)) isValid = false;

            if (string.IsNullOrWhiteSpace(EmailAddress)) isValid = false;

            return isValid;
        }

        // method to retrieve one customer
        public Customer Retrieve(int customerId)
        {
            // code that retrieves one customer will be coded later with UI
            return new Customer();
        }

        // method to retrieve all customers / list of customers

        public List<Customer> Retrieve() // default constructor method
        {
            //code that retrieves one customer will be coded later with UI
            return new List<Customer>();    
        }

        //method to save the current customer

        public bool Save()
        {

            //code to save the current customer

            return true;
        }
    }

}       



