using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_InternalClassExample
{
    class Program
    {
        static void Main(string[] args)
        {
            StudentInfo obj = new StudentInfo();
            obj.getdata();
            obj.display();
            Console.ReadLine();
        }
        

    }
    class StudentInfo
        {
            private int id;
            private string StudentName;
            public void getdata()
            {

                Console.WriteLine("enter the id and StudentName");
                id = Convert.ToInt32(Console.ReadLine());
                 StudentName = Console.ReadLine();
            }


            public void display()
            {
                Console.WriteLine("id=" + id + "   StudentName=" + StudentName);
                Console.ReadLine();
            }
        }
}
