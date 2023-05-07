using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_Constructor_Overloading
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee();
            emp.Display();
            Employee obj1 = new Employee(2, "mayuri", 1000);
             obj1.Display();
             Console.ReadLine();

          //  Console.WriteLine("\n\n by obj2 ");
            //Employee obj2 = new Employee( obj1);    //it will call the copy constructor
            //obj2.Display();
           // Console.ReadLine();
        }
            
    }
}
