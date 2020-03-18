using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoeBackOffice
{
    class clsOrderNo
    {

    }
        
     
    
        

namespace ShoeTesting
    {
        public class clsOrder
        {
            public bool Active { get; internal set; }
            public DateTime DateAdded { get; internal set; }
            public int OrderNo { get; internal set; }
            public int PaymentAmount { get; internal set; }
            public int CustomerID { get; internal set; }
            public string CustomerName { get; internal set; }
        }
    }
}

