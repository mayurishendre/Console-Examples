using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_Generics
{
    class DemoClass<UnknownDatatype>
    {
        //step3
        public bool compare(UnknownDatatype x,UnknownDatatype y)
        {
            if(x.Equals(y))
            {
                return true;
            }
            else 
            {
                return false;
            }
        }
    }
}
