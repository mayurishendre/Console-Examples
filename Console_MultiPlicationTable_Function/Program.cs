using System;

namespace Console_MultiPlicationTable_Function
{
    class Program
    {
        static void Main(string[] args)
        {
            Multiply();
            Console.ReadLine();
        }
        public static void Multiply()
        {
            int number, count = 1;
            Console.WriteLine("enter the number...");
            number = Convert.ToInt32(Console.ReadLine());

            for(int i=0;i<10;i++)
            {
                Console.WriteLine(number + "*" + count + "=" + (number * count));
                count++;
            }
        }
    }
}
