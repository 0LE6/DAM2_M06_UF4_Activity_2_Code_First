using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAM2_M06_UF4_Activity_2_Code_First.MODEL
{
    // TABLE Employees
    public class Employee
    {
        private int EmployeeNumber {  get; set; }
        private string LastName { get; set; }
        private string FirstName { get; set; }
        private string Extension { get; set; }
        private string Email { get; set; }
        private string OfficeCode { get; set; }

        // TODO : Foreign Key que apunta a SalesRepEmployeeNumber de la TABLE Suctomers junto a EmployeeNumber
        // private int ReportTo { get; set; }
        private string JobTitle { get; set; }
    }
}
