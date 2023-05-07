
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_Object_Returning_console
{
    class Stud
    {
        int mark1, mark2;
        public void SetValues(int m1,int m2)
        {
            mark1 = m1;
            mark2 = m2;

        }
        public Stud Addmarks(Stud s)

        {
            Stud temp = new Stud();                //passing obj is stored in temp obj
            temp.mark1 = mark1 + s.mark1;
            temp.mark2 = mark2 + s.mark2;
            return temp;                    //returning obj   
        }
        public void display()
        {
            Console.WriteLine("mark1=" + mark1);
            Console.WriteLine("mark2=" + mark2);
        }
    }
}
