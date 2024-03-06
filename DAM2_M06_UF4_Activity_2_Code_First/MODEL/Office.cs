using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAM2_M06_UF4_Activity_2_Code_First.MODEL
{
    public class Office
    {
        public Office()
        {
            Employees = new HashSet<Employee>();
        }

        [Key]
        [StringLength(10)]
        public string OfficeCode { get; set; }
        [StringLength(50)]
        public string City { get; set; }
        [StringLength(50)]
        public string Phone { get; set; }
        [StringLength(50)]
        public string AddressLine1 { get; set; }
        [StringLength(50)]
        public string AddressLine2 { get; set; }
        [StringLength(50)]
        public string State { get; set; }
        [StringLength(50)]
        public string Country { get; set; }
        [StringLength(15)]
        public string PostalCode { get; set; }
        [StringLength(10)]
        public string Territory { get; set; }

        public virtual ICollection<Employee> Employees { get; set; }
    }
}
