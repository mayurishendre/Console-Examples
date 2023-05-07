using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_Vowel_Function
{
    class Program
    {
        static void Main(string[] args)
        {
            Vowel();
        }
        public static void Vowel()
        {
            Console.WriteLine("enter the character...");
            char ch = Convert.ToChar(Console.ReadLine());

            if(ch=='a' || ch=='e' || ch=='i' || ch=='o' || ch=='u')
            {
                Console.WriteLine("its a vowel.");
            }
            else
            {
                Console.WriteLine("its a consonant");
            }
            Console.ReadLine();
        }
    }
}
