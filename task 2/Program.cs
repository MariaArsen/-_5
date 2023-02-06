using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[15];
            Random random = new Random();
            for (int i = 0; i < 15; i++)
            {
                array[i] = random.Next(0, 50);
                Console.Write("{0} ", array[i]);
            }
            Console.WriteLine();
            int min = array[0];
            int max = array[0];
            for (int i = 0; i < 15; i++)
            {   if (array[i] < min)
                    min = array[i];
                if (array[i] > max)
                    max = array[i];
            }
            Console.WriteLine(max+min);
            Console.ReadKey();
        }
    }
}

