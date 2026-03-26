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
            int[] квадраты = new int[n];
            for (int i = 0; i < n; i++)
            {
                квадраты[i] = массив[i] * массив[i];
            }   
            Console.WriteLine("Квадраты элементов:");
            foreach (int элемент in квадраты)
            {
                Console.Write(элемент + " ");
            }
            Console.ReadKey();
        }
    }
}