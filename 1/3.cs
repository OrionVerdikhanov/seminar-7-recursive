using System;

class Program
{
    static void Main(string[] args)
    {
        // Произвольный массив чисел
        int[] array = { 1, 2, 3, 4, 5 };

        PrintArrayReverse(array, array.Length);
    }

    static void PrintArrayReverse(int[] arr, int length)
    {
        if (length > 0)
        {
            Console.WriteLine(arr[length - 1]);
            PrintArrayReverse(arr, length - 1);
        }
    }
}

