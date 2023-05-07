using System;

namespace ConsoleAdditionByParameter
{
    class Program
    {
        static void Main(string[] args)
        {
            input();
            
            Console.ReadLine();
        }
        //function without argument
        public static void input()
        {
           float num1;
            float num2;
            Console.WriteLine("enter the numbers...");
            num1 = Convert.ToSingle(Console.ReadLine());
            num2 = Convert.ToSingle(Console.ReadLine());
            
            calculate(num1, num2);
            Console.ReadLine();
                
        }
        //function with argument
        public static void calculate(float n1,float n2)
        {
            float sum = n1 + n2;
            display(sum);
        }
        public static void display( float add)
        {
            Console.WriteLine("addition" + add);
        }
    }
}
