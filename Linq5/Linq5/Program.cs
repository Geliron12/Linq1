﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq5
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            var current = new List<int>();
            Console.WriteLine("Введите количество элементов в последовательности");
            n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите элементы последовательности");
            for (int i = 0; i < n; i++)
            {
                current.Add(Convert.ToInt32(Console.ReadLine()));
            }
            var another = from z in current
                          where z>0
                          select z;
            another = another.Select(s => (s % 10));
            another = another.Distinct();
            Console.WriteLine("Отсортированная последовательность: ");
            foreach (int i in another)
            {
                Console.Write(i + " ");
            }
            Console.ReadKey();

        }
    }
}
