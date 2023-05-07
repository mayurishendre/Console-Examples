using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_Object_Passing_Console
{
    class Students
    {
        int mark1, mark2;
        public void SetValues(int m1,int m2)
        {
            mark1 = m1;
            mark2 = m2;
        }
        public void Addmarks(Students S)         //Receiving Object
        {
            mark1 = mark1 + S.mark1;
            mark2 = mark2 + S.mark2;
            Console.WriteLine("mark1=" + mark1);
            Console.WriteLine("mark2=" + mark2);
        }
    }
}
