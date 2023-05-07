using System;

namespace ConsoleFactorial_Function
{
    class Program
    {
        static void Main(string[] args)
        {
            Factorial();
            Console.ReadLine();
        }
        public static void Factorial()
        {
            int fact = 1;
            Console.WriteLine("Enter the number.......");
                int number = Convert.ToInt32(Console.ReadLine());
            for(int i=0;i>=1;i++)
            {
                fact = fact * number;
               // number--;
            }
            Console.WriteLine("factorial=" + fact);    
        }
    }
}
