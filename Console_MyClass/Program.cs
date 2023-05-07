using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_MyClass
{
    class Program
    {
        static void Main(string[] args)
        {
            //MyClass obj=new MyClass();       ......Constructor
            MyClass.SomeMethod();                 //it is also a obj (i.e MyClass) means constructor is called
            Console.ReadLine();

            MyClass.SomeMethod();         //or by function
            Console.ReadLine();
        }
        
        
    }
    public static class MyClass
    {
        static MyClass()     //Constructor
        {
            Console.WriteLine("this is via constructor");
        }
        public static void SomeMethod()
        {
            Console.WriteLine("via Method");
        }
    }
}
