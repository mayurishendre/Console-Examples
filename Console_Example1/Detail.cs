using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_Example1
{
    class Detail
    {
        private string Name;
        private int age;
        private string clg;
        private int std;

        public void candidates()
        {
            Console.WriteLine(" Name of Candidate");
            Name = Console.ReadLine();
            age = Convert.ToInt32(Console.ReadLine());
            Education(Name);

        }
        public void Education( string name)
        {
            Console.WriteLine("Education of Candidate :");
            name = Console.ReadLine();
            clg = Console.ReadLine();
            std = Convert.ToInt32(Console.ReadLine());
            Project();
        }
        public void Project()
        {
            string Domain = Convert.ToString(Console.ReadLine());
        }
        public void display(string nam,string edu)
        {
            Console.WriteLine(" Name of candidate:" + nam);
            Console.WriteLine("Education of Candidate:" + edu);
            //Console.WriteLine("Project Name:" + Project);
        }
       // Console.Readline();


    }
}
