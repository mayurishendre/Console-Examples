using System;

namespace ConsoleAdditionFunction
{
    class Program
    {
        static void Main(string[] args)
        {
            AdditionFunction();
            Console.ReadLine();
        }
       public static void AdditionFunction()
        {
            int a, b, add;
            Console.WriteLine("enter the number");
             a = Convert.ToInt32(Console.ReadLine());
             b = Convert.ToInt32(Console.ReadLine());
            

            add = a + b;
            Console.WriteLine("addition = "+add);
            Console.ReadLine();

            
        }
    }
}
