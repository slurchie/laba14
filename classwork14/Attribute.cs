using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace classwork14
{
    class Attribute : System.Attribute
    {
        public int sum { get; set; }
        public Attribute () { }
        public Attribute (int Sum )
        {
            sum = Sum;
        }
    }
}
