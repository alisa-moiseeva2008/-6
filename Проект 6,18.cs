using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Введите длину массива n: ");
        int n = int.Parse(Console.ReadLine());

        int[] массив = new int[n];

        for (int i = 0; i < n; i++)
        {
            Console.Write($"Введите элемент {i + 1}: ");
            массив[i] = int.Parse(Console.ReadLine());
        }
        List<int> уникальные = new List<int>();

        foreach (int элемент in массив)
        {
            if (!уникальные.Contains(элемент))
            {
                уникальные.Add(элемент);
            }
        }
        int[] новыйМассив = уникальные.ToArray();
        Console.WriteLine("Уникальные элементы:");
        foreach (int элемент in новыйМассив)
        {
            Console.Write(элемент + " ");
        }
        Console.ReadKey();
    }
}