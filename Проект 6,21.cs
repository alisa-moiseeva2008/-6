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
            Console.Write("Введите количество сдвигов m: ");
            int m = int.Parse(Console.ReadLine());
            m = m % n;
            int[] сдвинутый = new int[n];
            for (int i = 0; i < n; i++)
            {
                сдвинутый[(i + m) % n] = массив[i];
            }
            Console.WriteLine("Массив после циклического сдвига:");
            foreach (int элемент in сдвинутый)
            {
                Console.Write(элемент + " ");
            }
            Console.ReadKey();
        }
    }
}