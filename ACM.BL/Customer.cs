using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class Customer
    {
        public int CustomerId { get; private set; }
        public string EmailAddress { get; set; }
        public string FirstName { get; set; }

        public string FullName
        {
            get
            {

                //if there is only lastname defined, the fullname is the lastname with no comma
                string fullName = LastName;

                // to check condition for firstname

                if (!string.IsNullOrWhiteSpace(FirstName))
                {
                    if (!string.IsNullOrWhiteSpace(fullName))
                    {
                        //fullName = fullName + ",";
                        fullName += ",";
                    }

                    fullName += FirstName;
                }

                return fullName;
            }
        }


        private string _lastName;
        public string LastName
        {
            get { return _lastName; }
            set { _lastName = value; }
        }

    }
}
