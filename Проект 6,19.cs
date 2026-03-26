using System;
using System.Collections.Generic;
using System.Linq;
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите размер массива n: ");
            int n = int.Parse(Console.ReadLine());
            int[] массивN = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Введите элемент {i + 1} массива n: ");
                массивN[i] = int.Parse(Console.ReadLine());
            }       
            Console.Write("Введите размер массива m: ");
            int m = int.Parse(Console.ReadLine());
            int[] массивM = new int[m];
            for (int i = 0; i < m; i++)
            {
                Console.Write($"Введите элемент {i + 1} массива m: ");
                массивM[i] = int.Parse(Console.ReadLine());
            }
            List<int> толькоN = new List<int>();
            foreach (int элемент in массивN)
            {
                if (!массивM.Contains(элемент))
                {
                    толькоN.Add(элемент);
                }
            }
            List<int> общие = new List<int>();
            foreach (int элемент in массивN)
            {
                if (массивM.Contains(элемент) && !общие.Contains(элемент))
                {
                    общие.Add(элемент);
                }
            }
            List<int> всеКромеОбщих = new List<int>();
            foreach (int элемент in массивN)
            {
                if (!общие.Contains(элемент))
                {
                    всеКромеОбщих.Add(элемент);
                }
            }
            foreach (int элемент in массивM)
            {
                if (!общие.Contains(элемент))
                {
                    всеКромеОбщих.Add(элемент);
                }
            }
            Console.WriteLine("Элементы из n, которых нет в m:");
            foreach (int эл in толькоN) Console.Write(эл + " ");
            Console.WriteLine();
            Console.WriteLine("Элементы, присутствующие в обоих массивах:");
            foreach (int эл in общие) Console.Write(эл + " ");
            Console.WriteLine();
            Console.WriteLine("Элементы из обоих массивов, кроме общих:");
            foreach (int эл in всеКромеОбщих) Console.Write(эл + " ");
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}