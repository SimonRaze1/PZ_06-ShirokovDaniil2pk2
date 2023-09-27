using System;

class Program
{
    static void Main(string[] args)
    {
        int[] array = new int[10];
        Random random = new Random();
        // Заполнение массива случайными числами
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = random.Next(-10, 11);
        }
        Console.WriteLine("Исходный массив:");
            PrintArray(array);
        // Циклический сдвиг вправо
        int lastElement = array[array.Length - 1];
        for (int i = array.Length - 1; i > 0; i--)
        {
            array[i] = array[i - 1];
        }
        array[0] = lastElement;
        Console.WriteLine("Массив после цикличекого сдвига вправо:");
            PrintArray(array);
    }
            static void PrintArray(int[] array) 
            {
                foreach (int element in array)
                {
                    Console.WriteLine(element + " ");
                }
                Console.WriteLine();
            }
}
