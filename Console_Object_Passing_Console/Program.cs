using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_Object_Passing_Console
{
    class Program
    {
        static void Main(string[] args)
        {
            Students obj1 = new Students();
            Students obj2 = new Students();

            obj1.SetValues(11, 23);
            obj2.SetValues(100, 200);
            obj1.Addmarks(obj2);            //passing object
           //bj2.Addmarks(5, 4);
            Console.ReadLine();
                
        }
    }
}
