using System;

namespace ConsoleAskingValuesForLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int no = 0; no <= 255; no++)
            {
                Console.Write(no + "=" + Convert.ToChar(no) + "\t");
            }
            Console.ReadLine();
        }
    }
}
