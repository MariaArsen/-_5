﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_4
{
    class Program
    {
        static void Main(string[] args)
        {
            const int n = 20;
            int[] array = new int[n];
            Random random = new Random();
            int k = 0;
            for (int i = 0; i < n; i++)
            {
                array[i] = random.Next(-50, 50);
                Console.Write("{0} ", array[i]);
            }
            Console.WriteLine();
            for (int i=1; i < n; i+=2)
            {
                if ((array[i] % 2 == 1)&&(array[i] > 0))
                {
                    k++; 
                }
            }
            Console.WriteLine(k);
            Console.ReadKey();
        }
    }
}
