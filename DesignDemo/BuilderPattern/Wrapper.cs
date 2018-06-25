using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    public class Wrapper:IPacking
    {
        public string Packing()
        {
            return "Wrapper";
        }
    }


    public class Bottle : IPacking
    {
        public string Packing()
        {
            return "Bottle";
        }
    }
}
