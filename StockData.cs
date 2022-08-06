using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project2
{
    public class StockData
    {
        string x;
        public class USDINR
        {

            public double end_rate { get; set; }
        }


        public class quotes
        {
            
            public USDINR USDINR { get; set; }
            
     
        }


        public class root
        {
            public quotes quotes { get; set; }
        }
    }
}
