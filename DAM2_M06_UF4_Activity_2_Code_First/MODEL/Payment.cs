using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAM2_M06_UF4_Activity_2_Code_First.MODEL
{
    public class Payment
    {
        [Key, Column(Order = 0)]
        public int CustomerNumber { get; set; }
        [Key, Column(Order = 1)]
        [StringLength(50)]
        public string CheckNumber { get; set; }
        public DateTime PaymentDate { get; set; }
        [Column(TypeName = "decimal(10, 2)")]
        public decimal Amount { get; set; }

        public virtual Customer Customer { get; set; }
    }
}
