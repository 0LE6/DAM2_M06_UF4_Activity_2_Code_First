using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAM2_M06_UF4_Activity_2_Code_First.MODEL
{
    public class ProductLines
    {
        public ProductLines()
        {
            Products = new HashSet<Product>();
        }
        public string ProductLine { get; set; }
        public string TextDescription { get; set; }
        public string HtmlDescription { get; set; }
        public string Image { get; set; } // set as string

        public ICollection<Product> Products { get; set; }
    }
}
