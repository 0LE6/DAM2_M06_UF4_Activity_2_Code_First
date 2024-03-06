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
            //Employees = new HashSet<Employee>();
        }

        [Key]
        public string OfficeCode { get; set; }
        public string City {  get; set; }
        public string Phone { get; set; }
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
        public string PostalCode { get; set; }
        public string Territory { get; set; }

        //public ICollection<Employee> Employees { get; set; }
    }
}
