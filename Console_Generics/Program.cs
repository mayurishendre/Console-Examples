using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            //step2
            Check obj = new Check();
            bool Status = obj.compare(2, 2);
            Console.WriteLine("result :" + Status);
            Console.ReadLine();

            //step4
            DemoClass<int> Dc = new DemoClass<int>();
            bool newstatus = Dc.compare(4, 5);
            Console.WriteLine("results :" + newstatus);
            Console.ReadLine();
        }
    }
}
