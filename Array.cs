using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern1
{
    class Array
    {
        private static int i;

        public static void Singlearraytest()
        {
            int[] a;
            int n, sum = 0;
            Console.WriteLine("Enter the Size of Array:");
            n = Convert.ToInt32(Console.ReadLine());
            a = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write("Enter [{0}]:", i);
                a[i] = Convert.ToInt32(Console.ReadLine());

            }
            for (i = 0; i < n; i++)

            {
                Console.WriteLine("[{0}] : {1}", i, a[i]);
            }

            for (i = 0; i < n; i++)
            {
                sum += a[i];
            }

            int max = a[0];
            for (i = 0; i < n; i++)
            {
                if (max < a[i])
                {
                    max = a[i];

                }
            }
            int min = a[0];

            for (i = 0; i < n; i++)
            {
                if (min > a[i])
                {
                    min = a[i];
                }
            }

            Console.WriteLine("The Sum is {0},Maximum is {1},Minimum {2}", sum, max, min);

        }

        public static void BubbleSort()
        {
            int[] a;
            int n,temp;
            Console.WriteLine("Enter the Size of Array:");
            n = Convert.ToInt32(Console.ReadLine());
            a = new int[n];
          for (int i = 0; i < n; i++)
            {
                Console.Write("Enter a[{0}]:", i);
                a[i] = Convert.ToInt32(Console.ReadLine());

            }
            /*     for (i = 0; i < n; i++)
               {
                   for (int j = 0; j < n - i; j++)
                   {
                       if (a[j + 1] > a[j])
                       {
                           int temp = a[j - i];
                           a[j - i] = a[j];
                           a[j] = temp;

                       }
                   }

               }*/
            for (int j = 0; j <= a.Length - 2; j++)
            {
                for (int i = 0; i <= a.Length - 2; i++)
                {
                    if (a[i] > a[i + 1])
                    {
                        temp = a[i + 1];
                        a[i + 1] = a[i];
                        a[i] = temp;
                    }
                }
            }
            for (i = 0; i < n; i++)
            {
                Console.WriteLine("{0}", a[i]);
            }

        }
    }
}
