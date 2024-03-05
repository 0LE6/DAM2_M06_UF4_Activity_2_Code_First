using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAM2_M06_UF4_Activity_2_Code_First.MODEL
{
    // TABLE Employees
    public class Employee
    {
        public Employee()
        {
            Customers = new HashSet<Customer>();
        }
        [Key]
        public int EmployeeNumber {  get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string Extension { get; set; }
        public string Email { get; set; }
        public string OfficeCode { get; set; }

        public ICollection<Customer> Customers { get; set; }
        private int? ReportTo { get; set; }
        public string JobTitle { get; set; }
    }
}
