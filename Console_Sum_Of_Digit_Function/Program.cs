using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_Sum_Of_Digit_Function
{
    class Program
    {
        static void Main(string[] args)
        {
            //int SOD=SumOfDigit(3456)
            Console.WriteLine("Sum Of Digit =" + SumOfDigit(3456));
            Console.ReadLine();
        }
        public static int SumOfDigit(int num)
        {
            int sum = 0;
            while (num != 0)
            {
                sum += Convert.ToInt32(num % 10);
                num = num / 10;
            }
           // Console.WriteLine("SumOfDigit=" + sum);
            return sum;
        }
    }
}
