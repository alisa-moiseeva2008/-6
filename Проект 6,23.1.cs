using System;
{
    class Program
    {
        static int СуммаЦифр(int число)
        {
            int сумма = 0;
            число = Math.Abs(число);
            while (число > 0)
            {
                сумма += число % 10;
                число /= 10;
            }
            return сумма;
        } 
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
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (СуммаЦифр(массив[j]) > СуммаЦифр(массив[j + 1]))
                    {
                        int temp = массив[j];
                        массив[j] = массив[j + 1];
                        массив[j + 1] = temp;
                    }
                }
            }
            Console.WriteLine("Массив, отсортированный по сумме цифр:");
            foreach (int элемент in массив)
            {
                Console.Write(элемент + " ");
            }
            Console.ReadKey();
        }
    }
}