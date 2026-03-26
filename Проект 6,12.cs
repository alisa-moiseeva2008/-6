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
            int[] новыйМассив = new int[n];
            
            for (int i = 0; i < n; i++)
            {
                if (массив[i] % 2 != 0)
                {
                    новыйМассив[i] = массив[i] + 1;
                }
                else
                {
                    новыйМассив[i] = массив[i];
                }
            }
            Console.WriteLine("Новый массив (все элементы четные):");
            foreach (int элемент in новыйМассив)
            {
                Console.Write(элемент + " ");
            }
            Console.ReadKey();
        }
    }
}