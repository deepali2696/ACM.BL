﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class Address
    {

        public Address()
        {

        }

        public Address(int addressId)
        {
            addressId=addressId;
        }

        public int AddressId { get; private set; }

        public string addr_line1 { get; set; }

        public string addr_line2 { get; set; }

        public string city { get; set; }

        public string state { get; set; }

        public string postalCode { get; set; }

        public string country { get; set; }

        public string addr_type { get; set; }

        public bool Validate()
        {
            var isValid = true;

            if(postalCode == null) isValid = false;

            return isValid;
        }

        public Address Reterive()
        {

        }

        public bool Save()
        {

        }
    }
}
