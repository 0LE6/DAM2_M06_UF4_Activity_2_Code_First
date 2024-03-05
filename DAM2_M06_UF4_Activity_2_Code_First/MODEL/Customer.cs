using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAM2_M06_UF4_Activity_2_Code_First.MODEL
{
    // TABLE Customers
    public class Customer
    {
        public int CustomerNumber {  get; set; }
        public string CustomerName { get; set; }
        public string ContactLastName { get; set; }
        public string ContactFirstName { get; set; }
        public string Phone {  get; set; }
        public string AdressLine1 { get; set; }
        public string AdressLine2 { get; set; }
        public string State { get; set; }
        public string PostalCode { get; set; }
        public string Country { get; set; }

        // TODO : foreign keys
        // private int? SalesRepEmployeeNumber { get; set; }
        // private double CreditLimit { get; set; }

    }
}
