using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace DAM2_M06_UF4_Activity_2_Code_First.MODEL
{
    public class OrderDetail
    {
        public int OrderLineNumber { get; set; }
        public int OrderNumber { get; set; }
        public string ProductCode { get; set; }
        public int QuantityOrdered { get; set; }
        public decimal PriceEach { get; set; }
        public decimal OrderLineAmount { get; set; }

        public  Order Order { get; set; }
        public  Product Product { get; set; }
    }
}
