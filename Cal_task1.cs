using System;

namespace CP_Csharp
{
    internal class Cal_task1
    {
        public static void Simple()
        {
            int i, j, k = 1;
            Console.Write("S  M  T  W  T  F  S\n");
            for (i = 0; i < 7; i++)
            {
                for (j = 0; j < 7; j++)
                {

                    if (k > 8)
                    {
                        Console.Write(k + " ");
                    }
                    else
                    {
                        Console.Write(k + "  ");
                    }

                    if (k == 31)
                    {
                        goto exit;
                    };
                    k++;
                }
                Console.WriteLine("\n");

            }
        exit: Console.WriteLine("");
        }
    }
}
