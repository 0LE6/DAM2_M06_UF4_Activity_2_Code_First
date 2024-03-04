using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAM2_M06_UF4_Activity_2_Code_First.MODEL
{
    public class Office
    {
        // TABLE Offices
        // TODO : Foreign Key que apunta a OfficeCode de la TABLE Employees
        // private string OfficeCode { get; set; }

        private string City {  get; set; }
        private string Phone { get; set; }
        private string AddressLine1 { get; set; }
        private string AddressLine2 { get; set; }
        private string State { get; set; }
        private string Country { get; set; }
        private string PostalCode { get; set; }
        private string Territory { get; set; }
    }
}
