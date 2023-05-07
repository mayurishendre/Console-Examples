using System;

namespace Console_Pyramid_Function
{
    class Program
    {
        static void Main(string[] args)
        {
            Pyramid();
            Console.ReadLine();
        }
        public static void Pyramid()
        {
            int nol, no, star = 1, space = 5;

            for (nol = 1; nol <= 5; nol++)
            {
                for (no = 1; no <= space; no++)
                    Console.Write(" ");
                for (no = 1; no <= star; no++)
                    Console.Write("* ");
                star++;
                space--;
                Console.WriteLine();
            }
        }
    }
}
