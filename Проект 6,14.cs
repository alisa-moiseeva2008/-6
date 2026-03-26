using System;
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите длину массива n (n > 4): ");
            int n = int.Parse(Console.ReadLine());           
            int[] массив = new int[n];          
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Введите элемент {i + 1}: ");
                массив[i] = int.Parse(Console.ReadLine());
            }         
            int[] новыйМассив = new int[n - 4];
            
            for (int i = 4; i < n; i++)
            {
                новыйМассив[i - 4] = массив[i];
            }         
            Console.WriteLine("Новый массив (без первых 4 элементов):");
            foreach (int элемент in новыйМассив)
            {
                Console.Write(элемент + " ");
            }
            Console.ReadKey();
        }
    }
}