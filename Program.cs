using System;

namespace SortApp
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Введите длинну массива:");
            int length = int.Parse(Console.ReadLine());

            int[] arr = new int[length];
            Console.WriteLine($"Введите {length} чисел:");

            int counter = 0;

            while (counter < arr.Length)
            {
                Console.WriteLine($"{counter + 1}-е число:");
                arr[counter] = int.Parse(Console.ReadLine());
                counter++;
            }

            int tmp;

            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] > arr[j])
                    {
                        tmp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = tmp;
                    }
                }
            }

            Console.WriteLine();
            Console.WriteLine($"||||||||||||||||");
            Console.WriteLine();

            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }
        }
    }
}