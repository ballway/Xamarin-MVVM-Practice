using System;
using System.Collections.Generic;
using System.Text;

namespace projCustomerSystemMobile.Models
{
    public class CCustomer
    {
        public int fld { get; set; }
        public string fName { get; set; }
        public string fPhone { get; set; }
        public string fEmail { get; set; }
        public string fAddress { get; set; }

        public override string ToString()
        {
            return $"{fName} / {fPhone} / {fEmail} / {fAddress}";
        }
    }
}
