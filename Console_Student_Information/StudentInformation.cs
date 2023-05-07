using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_Student_Information
{
    class StudentInformation
    {
        private string Name;
        private int Age;

        public void GetData()
        {
            Console.WriteLine("enter the student's name and age..");
             Name =  Console.ReadLine();
            Age=Convert.ToInt32(Console.ReadLine());
        }
        public void Display()
        {
            Console.WriteLine("name=" + Name);
            Console.WriteLine("age=" + Age);
            Console.ReadLine();
            
        }
       
           

    }
}
