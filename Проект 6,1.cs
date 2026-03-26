using System;
class Program
{
    static void Main(string[] args)
    {
        Console.Write("Введите число M: ");
        int M = int.Parse(Console.ReadLine());
        int[] массив = new int[10];

        for (int i = 0; i < массив.Length; i++)
        {
            массив[i] = M;
        }
        Console.WriteLine("Массив:");
        foreach (int элемент in массив)
        {
            Console.Write(элемент + " ");
        }
        Console.ReadKey();
    }
}
