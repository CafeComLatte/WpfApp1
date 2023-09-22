using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class PurchaseVO
    {
        public string ProductName { get; set; }
        public string Contents { get; set; }
        public string Price { get; set; }
        public string TotalPrice { get; set; }
        public string Count { get; set; }
        
        public string Image { get; set; }

        public string SysDate { get; set; }
        public string PaymentDate { get; set; }
        public string PaymentTime { get; set; }
    }
}
