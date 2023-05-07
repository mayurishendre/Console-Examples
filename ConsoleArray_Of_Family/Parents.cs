using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleArray_Of_Family
{
    class Parents
    {
        private string fname;
        private string mname;
      //  private string city;

        public void PGetData()
        {
            Console.WriteLine("Enter the parents name ");
            fname = Console.ReadLine();
            mname = Console.ReadLine();
           // city = Console.ReadLine();
        }
        public void PDisplay()
        {
            Console.WriteLine("father Name:" + fname);
            Console.WriteLine("mother Name:" + mname);
          //  Console.WriteLine("City Name:" + city);
        }
    }
}
