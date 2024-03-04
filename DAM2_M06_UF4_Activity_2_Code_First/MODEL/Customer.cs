using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAM2_M06_UF4_Activity_2_Code_First.MODEL
{
    public class Customer
    {
        private int CustomerNumber {  get; set; }
        private string CustomerName { get; set; }
        private string ContactLastName { get; set; }
        private string ContactFirstName { get; set; }
        private string Phone {  get; set; }
        private string AdressLine1 { get; set; }
        private string AdressLine2 { get; set; }
        private string State { get; set; }
        private string PostalCode { get; set; }
        private string Country { get; set; }

        // TODO : foreign keys
        // private int? SalesRepEmployeeNumber { get; set; }
        // private double CreditLimit { get; set; }

    }
}
