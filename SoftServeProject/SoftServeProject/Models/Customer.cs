using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SoftServeProject.Models
{
    public class Customer
    {
        public int CustomerID { get; set; }
        public String LastName { get; set; }
        public Email MyProperty { get; set; }
    }
}
