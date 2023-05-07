using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleArray_Of_Object
{
    class Program
    {
        static void Main(string[] args)
        {
            EmployeeInfo[] Arrobj = new EmployeeInfo[4];
            Console.WriteLine("enter recordes...");
            for (int i = 0; i < 4; i++)
            {
                Arrobj[i] = new EmployeeInfo();
                Arrobj[i].GetData();

            }
            Console.WriteLine("...Records...");
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine("Record no.:" + i);
                Arrobj[i].Display();

            }
            Console.ReadLine();
        }
    }
}
