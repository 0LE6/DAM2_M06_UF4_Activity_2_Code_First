using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAM2_M06_UF4_Activity_2_Code_First.MODEL
{
    public class Product
    {
        public Product()
        {
            OrderDetails = new HashSet<OrderDetail>();
        }

        [Key]
        [StringLength(15)]
        public string ProductCode { get; set; }
        [StringLength(70)]
        public string ProductName { get; set; }
        [StringLength(50)]
        public string ProductLine { get; set; }
        [StringLength(10)]
        public string ProductScale { get; set; }
        [StringLength(50)]
        public string ProductVendor { get; set; }
        public string ProductDescription { get; set; }
        public int QuantityInStock { get; set; }
        [Column(TypeName = "decimal(10, 2)")]
        public decimal BuyPrice { get; set; }
        [Column(TypeName = "decimal(10, 2)")]
        public decimal MSRP { get; set; }

        public virtual ProductLine ProductLineDetails { get; set; }
        public virtual ICollection<OrderDetail> OrderDetails { get; set; }
    }
}
