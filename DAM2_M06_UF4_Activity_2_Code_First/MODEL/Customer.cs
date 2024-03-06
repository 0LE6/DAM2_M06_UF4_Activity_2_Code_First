using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAM2_M06_UF4_Activity_2_Code_First.MODEL
{
    // TABLE Customers
    public class Customer
    {
        public Customer()
        {
            Orders = new HashSet<Order>();
            Payments = new HashSet<Payment>();
        }

        [Key]
        public int CustomerNumber { get; set; }
        [StringLength(50)]
        public string CustomerName { get; set; }
        [StringLength(50)]
        public string ContactLastName { get; set; }
        [StringLength(50)]
        public string ContactFirstName { get; set; }
        [StringLength(50)]
        public string Phone { get; set; }
        [StringLength(50)]
        public string AddressLine1 { get; set; }
        [StringLength(50)]
        public string AddressLine2 { get; set; }
        [StringLength(50)]
        public string City { get; set; }
        [StringLength(50)]
        public string State { get; set; }
        [StringLength(15)]
        public string PostalCode { get; set; }
        [StringLength(50)]
        public string Country { get; set; }
        public int SalesRepEmployeeNumber { get; set; }

        [Column(TypeName = "decimal(10, 2)")]
        public decimal CreditLimit { get; set; }

        public virtual Employee SalesRep { get; set; }
        public virtual ICollection<Order> Orders { get; set; }
        public virtual ICollection<Payment> Payments { get; set; }

    }
}
