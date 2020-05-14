using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq4
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            var current = new List<string>();
            Console.WriteLine("Введите количество элементов в последовательности");
            n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите элементы последовательности");
            for (int i = 0; i < n; i++)
            {
                current.Add((Console.ReadLine()));
            }
            var another = from z in current
                          select z;
            another = another.Select(s => s.Substring(0, 1));
            another = another.Reverse();
            Console.WriteLine("Отсортированная последовательность: ");
            foreach (var i in another)
            {
                Console.Write(i + " ");
            }
            Console.ReadKey();

        }
    }
}
