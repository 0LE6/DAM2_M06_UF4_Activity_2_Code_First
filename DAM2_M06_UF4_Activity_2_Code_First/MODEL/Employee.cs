using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAM2_M06_UF4_Activity_2_Code_First.MODEL
{
    public class Employee
    {
        public Employee()
        {
            Customers = new HashSet<Customer>();
            Subordinates = new HashSet<Employee>();
        }

        [Key]
        public int EmployeeNumber { get; set; }
        [StringLength(50)]
        public string LastName { get; set; }
        [StringLength(50)]
        public string FirstName { get; set; }
        [StringLength(10)]
        public string Extension { get; set; }
        [StringLength(100)]
        public string Email { get; set; }
        [StringLength(10)]
        public int? ReportsTo { get; set; }

        [ForeignKey("Office")]
        public string OfficeCode { get; set; }
        [StringLength(50)]
        public string JobTitle { get; set; } 
        public virtual Office Office { get; set; }

        public virtual Employee Manager { get; set; }
        public virtual ICollection<Customer> Customers { get; set; }
        public virtual ICollection<Employee> Subordinates { get; set; }
    }
}
