using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_Constructor_Overloading
{
    class Employee
    {
        int ID;
        string EmpName;
        decimal BasicSalary;
        decimal GrossSalary;
        decimal TA, DA, HRA;

        public  Employee()   //Default Constructor
        {
           ID=1;
            EmpName="Mayuri";
            BasicSalary=5000;

        }
        public Employee(int id,string Name,decimal Salary)         //3argument constructor
        {
                ID=id;
                EmpName=Name;
                BasicSalary=Salary;

        }
        public void GetData()
        {
            Console.WriteLine("enter Id,name,salary of employee..");
            ID = Convert.ToInt32(Console.ReadLine());
            EmpName = Console.ReadLine();
            BasicSalary = Convert.ToInt32(Console.ReadLine());

        }
        private void CalculateSalary()
        {
            TA = BasicSalary * Convert.ToDecimal(12.5f / 100);
            DA = BasicSalary * Convert.ToDecimal(27.1f / 100);
            HRA = BasicSalary * Convert.ToDecimal(33.5f / 100);
            GrossSalary = BasicSalary + TA + DA + HRA;
        }

        public void Display()
        { 
            Console.WriteLine("ID=" + ID);
            Console.WriteLine("BasicSalary=" + BasicSalary);
            Console.WriteLine("EmployeeName=" + EmpName);
            CalculateSalary();
            Console.WriteLine("GrossSalary=" + GrossSalary);

        } 
        // copy constructor
        public Employee(Employee emp)
        {
            ID = emp.ID;
            EmpName = emp.EmpName;
            BasicSalary = emp.BasicSalary;
        }

    }
}
