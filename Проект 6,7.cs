using System;
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите длину массива n: ");
            int n = int.Parse(Console.ReadLine());      
            int[] фибоначчи = new int[n];
            
            фибоначчи[0] = 0;
            if (n > 1) фибоначчи[1] = 1;  
            for (int i = 2; i < n; i++)
            {
                фибоначчи[i] = фибоначчи[i - 1] + фибоначчи[i - 2];
            } 
            Console.WriteLine("Числа Фибоначчи:");
            foreach (int число in фибоначчи)
            {
                Console.Write(число + " ");
            }
            Console.ReadKey();
        }
    }
}