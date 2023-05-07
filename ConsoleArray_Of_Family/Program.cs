using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleArray_Of_Family
{
    class Program
    {
        static void Main(string[] args)
        {
            GrandParent[] Arrobj = new GrandParent[2];
            Parents[] arrobj = new Parents[2];
           // Console.WriteLine("GrandParent Information_____");
            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine("GrandParent Information_____");
                Arrobj[i] = new GrandParent();
                Arrobj[i].GPGetData();
                Console.WriteLine("Parent Information_____");
                arrobj[i] = new Parents();
                arrobj[i].PGetData();

            }
            Console.WriteLine("...information...");
            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine("Record no.:" + i);
                Arrobj[i].GPDisplay();
                Console.WriteLine("Parent Record no.:" + i);
                arrobj[i].PDisplay();

            }
            Console.ReadLine();
        }
    }
}
