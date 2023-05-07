using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_Student_Info_Class
{
    class Program
    {
        static void Main(string[] args)
        {
            StudentInfo obj = new StudentInfo();
            obj.GetData();
           obj.StdMarks();
           // obj.Status();

            
            Console.ReadLine();
                
        }

    }
    class StudentInfo
    {
        private int ID;
        private string StudentName;
        private int age;
        private long  MobNo;

        private int Mark1;
        private int Mark2;
        private int Mark3;

        private int Total;
        private float percentage;
        //private string PassFail;

        public  void GetData()
        {
            Console.WriteLine("Enter the students ID,StudentName,age,MobNo...");
             ID = Convert.ToInt32(Console.ReadLine());
            StudentName = Console.ReadLine();
            age = Convert.ToInt32(Console.ReadLine());
             MobNo = Convert.ToInt64(Console.ReadLine());


        }
        public  void StdMarks()
        {
            Console.WriteLine("Enter the students Mark1,Mark2,Mark3...");
            Mark1 = Convert.ToInt32(Console.ReadLine());
            Mark2 = Convert.ToInt32(Console.ReadLine());
             Mark3 = Convert.ToInt32(Console.ReadLine());

            Total = Mark1 + Mark2 + Mark3;
            // Console.WriteLine("Total={0}{1}{2}", Mark1, Mark2, Mark3);
            //Console.ReadLine();
            Status(Total);
        }
        public  void Status(int sum)
        {
           
            Console.WriteLine("Total="+sum);
            percentage = ((float)sum*100/300);
            Console.WriteLine("percentage="+ percentage);
            if ( percentage >= 40)
            {
                Console.WriteLine("Student is pass");

            }
            else
            {
                Console.WriteLine("Student is Fail");
            }
            Console.ReadLine();
            

        }
    


    }
}
