using System;

namespace Console_PrintArray_Function
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintArray();
            
            Console.ReadLine();
        }
        public static void PrintArray()
        {
            int[] ArrayName = new int[10];
            Console.WriteLine("enter the elements of array...");

            for(int i=0;i<10;i++)
            {
                ArrayName[i] = Convert.ToInt32(Console.ReadLine());
            
            }
            Display(ArrayName);
        }
        public static void Display(int[] arr)
        {
            /*int[] arrayName = new int[10];*/
            Console.WriteLine("input elements are...\n");
            for(int i=0;i<10;i++)
            {
              
                Console.WriteLine("ArrayName[" + i + "] = " + 
                    arr[i]);
            }
        }
    }
}
