using System;
{
    class Program
    {
        static void БыстраяСортировка(int[] массив, int лево, int право)
        {
            if (лево >= право) return;
            
            int опорный = массив[(лево + право) / 2];
            int i = лево;
            int j = право;
            
            while (i <= j)
            {
                while (массив[i] < опорный) i++;
                while (массив[j] > опорный) j--;
                
                if (i <= j)
                {
                    int temp = массив[i];
                    массив[i] = массив[j];
                    массив[j] = temp;
                    i++;
                    j--;
                }
            } 
            БыстраяСортировка(массив, лево, j);
            БыстраяСортировка(массив, i, право);
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
            БыстраяСортировка(массив, 0, n - 1);
            
            Console.WriteLine("Отсортированный массив (быстрая сортировка):");
            foreach (int элемент in массив)
            {
                Console.Write(элемент + " ");
            }
            Console.ReadKey();
        }
    }
}