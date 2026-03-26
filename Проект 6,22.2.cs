using System;
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
        for (int i = 0; i < n - 1; i++)
        {
            int минИндекс = i;
            for (int j = i + 1; j < n; j++)
            {
                if (массив[j] < массив[минИндекс])
                {
                    минИндекс = j;
                }
            }
            int temp = массив[i];
            массив[i] = массив[минИндекс];
            массив[минИндекс] = temp;
        }
        Console.WriteLine("Отсортированный массив (выбором):");
        foreach (int элемент in массив)
        {
            Console.Write(элемент + " ");
        }
        Console.ReadKey();
    }
}
