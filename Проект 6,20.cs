using System;
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
            Console.WriteLine("Элементы в обратном порядке:");
            for (int i = n - 1; i >= 0; i--)
            {
                Console.Write(массив[i] + " ");
            }
            Console.ReadKey();
        }
    }
}