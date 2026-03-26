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
            bool всеЧетные = true;
            foreach (int элемент in массив)
            {
                if (элемент % 2 != 0)
                {
                    всеЧетные = false;
                    break;
                }
            }  
            Console.WriteLine($"Все элементы четные: {всеЧетные}");
            Console.ReadKey();
        }
    }
}