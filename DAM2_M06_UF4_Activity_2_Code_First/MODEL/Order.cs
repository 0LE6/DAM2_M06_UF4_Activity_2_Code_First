using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAM2_M06_UF4_Activity_2_Code_First.MODEL
{
    public class Order
    {
        public int OrderNumber { get; set; }
        public DateTime OrderDate { get; set; }
        public DateTime RequiredDate { get; set; }
        public DateTime ShippedDate { get; set; }
        public string Status { get; set; }
        public string Comments { get; set; }
        public int CustomerNumber { get; set; }
        public int EmployeeNumber { get; set; }

        public  Customer Customer { get; set; }
        public  Employee Employee { get; set; }
        public  ICollection<OrderDetail> OrderDetails { get; set; }
    }
}
