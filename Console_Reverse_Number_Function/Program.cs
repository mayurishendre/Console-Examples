using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_Reverse_Number_Function
{
    class Program
    {
        static void Main(string[] args)
        {
            ReverseNumber();

        }
        public static void ReverseNumber()
        {
            Console.WriteLine("enter the number...");
            int number = Convert.ToInt32(Console.ReadLine());

            for(int i=0;i<number;i++)
            {
                int R4 = number % 10;
                number = number / 10;

                int R3 = number % 10;
                number = number / 10;

                int R2 = number % 10;
                number = number / 10;

                Console.WriteLine("ReverseNumber={0}{1}{2}{3}",R4,R3,R2,number);
                Console.ReadLine();
            }
        }
    }
}
