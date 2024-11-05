using System;

class Program
{
    static void Main(string[] args)
    {
        int arraySize = 10; // размер массивов

        // пишем массивы
        int[] intArray = new int[arraySize];
        float[] floatArray = new float[arraySize];
        string[] stringArray = new string[arraySize];

        // заполняеем массивы
        FillIntArray(intArray);
        FillFloatArray(floatArray);
        FillStringArray(stringArray);

        // вывод массивов до сорта
        Console.WriteLine("Массив целых чисел:");
        PrintArray(intArray);
        Console.WriteLine("Массив чисел с плавающей запятой:");
        PrintArray(floatArray);
        Console.WriteLine("Массив строк:");
        PrintArray(stringArray);

        // сортироыка массивов
        SortIntArray(intArray);
        SortFloatArray(floatArray);
        SortStringArray(stringArray);

        // вывод массивов после сорта
        Console.WriteLine("\nОтсортированный массив целых чисел:");
        PrintArray(intArray);
        Console.WriteLine("Отсортированный массив чисел с плавающей запятой:");
        PrintArray(floatArray);
        Console.WriteLine("Отсортированный массив строк:");
        PrintArray(stringArray);
    }

    // функция для заполнения массива целых чисел
    static void FillIntArray(int[] array)
    {
        Random rand = new Random();
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = rand.Next(1, 101);
        }
    }

    // фнкция для заполнения массива чисел с плавающей запятой
    static void FillFloatArray(float[] array)
    {
        Random rand = new Random();
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = (float)(rand.NextDouble() * 99 + 1);
        }
    }

    // функция для заполнения массива строк
    static void FillStringArray(string[] array)
    {
        Random rand = new Random();
        for (int i = 0; i < array.Length; i++)
        {
            int length = rand.Next(3, 6); 
            char[] chars = new char[length];
            for (int j = 0; j < length; j++)
            {
                chars[j] = (char)rand.Next('а', 'я' + 1);
            }
            array[i] = new string(chars);
        }
    }

    // сортировка массива целых чисел
    static void SortIntArray(int[] array)
    {
        Array.Sort(array);
    }

    // сортировка массива чисел с плавающей запятой
    static void SortFloatArray(float[] array)
    {
        Array.Sort(array);
    }

    // сортировка массива строк
    static void SortStringArray(string[] array)
    {
        Array.Sort(array);
    }

    // вывод массива на экран
    static void PrintArray<T>(T[] array)
    {
        Console.WriteLine(string.Join(", ", array));
    }
}
