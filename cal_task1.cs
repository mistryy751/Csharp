
using Csharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp
{
    internal class cal_task1
    {

        public static void Simple()
        {
            char[] dys = { 'S', 'M', 'T', 'W', 'T', 'F', 'S' };
            int[,] da = new int[,] { { 1, 2, 3, 4, 5, 6, 7 }, { 8, 9, 10, 11, 12, 13, 14 }, { 15, 16, 17, 18, 19, 20, 21 }, { 22, 23, 24, 25, 26, 27, 28 },{ 29, 30, 31 ,0,0,0,0} };
            System.Console.WriteLine(dys+"\n");
            Console.WriteLine(da);
            /* for (int i = 0; i <da.Length; i++)
            {
                for (int j = 0; j < 7; j++) 
                {
                    da[i, j] = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine(da[i,j]);
                }
            }*/
           
        }
    }
}
