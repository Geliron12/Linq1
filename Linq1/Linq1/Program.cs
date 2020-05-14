using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq1
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
            for (int i = 0; i < n; i++) {
                current.Add(Convert.ToInt32(Console.ReadLine()));
            }
            var another = from z in current
                          where z % 2 == 1
                          select z;
            another = another.Distinct();
            Console.WriteLine("Отсортированная последовательность: ");
            foreach (int i in another) {
                Console.Write(i+" ");
            }
            Console.ReadKey();

        }
    }
}
