using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAM2_M06_UF4_Activity_2_Code_First.MODEL
{
    public class Product
    {
        public string ProductCode { get; set; }
        public string ProductName { get; set; }
        public ProductLines ProductLine { get; set; }
        public string ProductScale { get; set; }
        public string ProductVendor { get; set; }
        public string ProductDescription { get; set; }
        public int QuantityInStock { get; set; }
        public decimal BuyPrice { get; set; }
        public decimal MSRP { get; set; }

        public  ICollection<OrderDetail> OrderDetails { get; set; }
    }
}
