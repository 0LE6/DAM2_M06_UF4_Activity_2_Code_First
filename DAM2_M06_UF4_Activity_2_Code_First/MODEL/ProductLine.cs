using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAM2_M06_UF4_Activity_2_Code_First.MODEL
{
    public class ProductLine
    {
        public ProductLine()
        {
            Products = new HashSet<Product>();
        }

        [Key]
        [StringLength(50)]
        public string ProductLineCode { get; set; }
        [StringLength(4000)]
        public string TextDescription { get; set; }
        public string HtmlDescription { get; set; }
        public byte[] Image { get; set; }

        public  ICollection<Product> Products { get; set; }
    }
}
