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
        List<int> новыйСписок = new List<int>();
        bool начатьКопировать = false;

        foreach (int элемент in массив)
        {
            if (!начатьКопировать && элемент >= 20)
            {
                начатьКопировать = true;
            }
            if (начатьКопировать)
            {
                новыйСписок.Add(элемент);
            }
        }
        int[] новыйМассив = новыйСписок.ToArray();
        Console.WriteLine("Новый массив:");
        foreach (int элемент in новыйМассив)
        {
            Console.Write(элемент + " ");
        }
        Console.ReadKey();
    }
}
