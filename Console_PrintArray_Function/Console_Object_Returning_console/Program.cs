using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_Object_Returning_console
{
    class Program
    {
        static void Main(string[] args)
        {
            Stud obj1 = new Stud();
            Stud obj2 = new Stud();
            Stud obj3 = new Stud();

            obj1.SetValues(11,2);
            obj2.SetValues(100, 200);
            obj3 = obj1.Addmarks(obj2);   //stored in obj3=temp obj
            obj3.display();

            Console.ReadLine();

        }
    }
}
