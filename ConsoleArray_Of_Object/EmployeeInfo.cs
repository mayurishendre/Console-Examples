using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleArray_Of_Object
{
    class EmployeeInfo
    {
        private int id;
        private string name;
        private long adhar;

        public void GetData()
        {
            Console.WriteLine("enter the employee info...");
            Console.WriteLine("enter id ,name and adhar no.of employee");
            int id = Convert.ToInt32(Console.ReadLine());
            string name = Convert.ToString(Console.ReadLine());
            long adhar = Convert.ToInt64(Console.ReadLine());

        }
        public void Display()
        {
            Console.WriteLine("id:" + id + "\n name:" + name + "\n adhar:" + adhar);

        }
         
    }
}
