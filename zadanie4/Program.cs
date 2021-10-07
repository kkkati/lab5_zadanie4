using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie4
{
    class Program
    {
        static void Main(string[] args)
        {

            const int n = 20;
            int[] array = new int[n];
            int a = 0;
            int kolichestvo = 0;
            Random random = new Random();

            for (int i = 0; i < n; i++)
            {
                array[i] = random.Next(-50, 50);
                Console.Write("{0} ", array[i]);
            }
            Console.WriteLine();
            for (int i = 2; i < n; i +=2)
            {
                if (array[i] > 0)
                {
                    if (array[i] % 2 != 0)
                    {
                        Console.Write("{0} ", array[i]);
                        kolichestvo++;
                    }
                }
                a++;
            }


            Console.WriteLine();            
            Console.WriteLine(kolichestvo);
            Console.ReadKey();
        }
    }
}
