using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleArray_Of_Family
{
    class GrandParent
    {
        private string fname;
        private string mname;
        private string city;

        public void GPGetData()
        {
          Console.WriteLine("Enter the grandparents name and city");
          fname = Console.ReadLine();
           mname =Console.ReadLine();
         city =Console.ReadLine();
        }
        public void GPDisplay()
        {
        Console.WriteLine("Grandfather Name:" + fname);
        Console.WriteLine("Grandmother Name:" + mname);
        Console.WriteLine("City Name:" + city);
        }
      //  Console.ReadLine();

       
    }
}
