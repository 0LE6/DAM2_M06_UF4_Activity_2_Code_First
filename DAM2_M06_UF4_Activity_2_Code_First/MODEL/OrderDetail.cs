using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace DAM2_M06_UF4_Activity_2_Code_First.MODEL
{
    public class OrderDetail
    {
        [Key, Column(Order = 0)]
        public int OrderNumber { get; set; }
        [Key, Column(Order = 1)]
        public string ProductCode { get; set; }
        public int QuantityOrdered { get; set; }
        [Column(TypeName = "decimal(10, 2)")]
        public decimal PriceEach { get; set; }
        public int OrderLineNumber { get; set; }

        public virtual Order Order { get; set; }
        public virtual Product Product { get; set; }
    }
}
