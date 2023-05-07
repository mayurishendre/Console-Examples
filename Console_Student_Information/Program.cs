using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_Student_Information
{
    class Program
    {
        static void Main(string[] args)
        {
            //StudentInformation[] obj=new StudentInformation(); .....constructor

            StudentInformation[] Arrobj = new StudentInformation[4];
            Console.WriteLine("enter recordes...");
            for(int i=0;i<4;i++)
            {
                Arrobj[i] = new StudentInformation();
                Arrobj[i].GetData();

            }
            Console.WriteLine("...Records...");
            for(int i=0;i<4; i++)
            {
               // Console.WriteLine("Record no.:" + i);
                Arrobj[i].Display();

            }
            Console.ReadLine();
        }
    }
}
