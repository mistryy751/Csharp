using Csharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern1
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args is null)
            {
                throw new ArgumentNullException(nameof(args));
            }
            /* Console.WriteLine("Enter The Number of lines:");
            int n = Convert.ToInt32(Console.ReadLine());
             for(int i=0;i<n;i++)
             {
                 for (int j = 0; j <= i; j++)
                 {
                   Console.Write(i % 2 == 0 ? "*" : "#");    
                 }
                  Console.WriteLine("");
             } */

            // Array.Singlearraytest();
            //Array.BubbleSort();
            //Calender.Simple();
            cal_task2.tempo();
            Console.ReadKey();
        }
        
    }
}
