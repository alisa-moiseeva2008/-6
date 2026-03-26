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
            bool естьОтрицательный = false;
            foreach (int элемент in массив)
            {
                if (элемент < 0)
                {
                    естьОтрицательный = true;
                    break;
                }
            }   
            Console.WriteLine($"Есть хотя бы один отрицательный: {естьОтрицательный}");
            Console.ReadKey();
        }
    }
}