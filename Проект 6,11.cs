using System;
using System.Collections.Generic;
{
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
            foreach (int элемент in массив)
            {
                if (элемент % 2 == 0)
                {
                    новыйСписок.Add(элемент);
                }
            }  
            int[] новыйМассив = новыйСписок.ToArray(); 
            Console.WriteLine("Новый массив (без нечетных):");
            foreach (int элемент in новыйМассив)
            {
                Console.Write(элемент + " ");
            }
            Console.ReadKey();
        }
    }
}