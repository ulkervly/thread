using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Thread.Models
{
    public class Order
    {
        public int No { get; set; }
        public int ProductCount { get; set; }
        public double TotalAmount { get; set; }
        public DateTime Createdat{ get; set; }
    }
}
