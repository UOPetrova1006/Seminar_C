using System;

    class Program
    {
        static int[] CreateArray(int number) // функция принимает число и отдает массив
        {
            int[] array = new int[number];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = i+1;
            }
            return array;
        }
        static void WriteArray(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
        }
        static int[] Shuffle(int[] array) // перемешивает значенния в массиве
        {
            for (int i = 0; i < array.Length; i++)
            {
                int j = new Random().Next(0,i+1);
                int number = array[j];
                array[j] = array[i];
                array[i] = number;
            }
            return array;
        }
        static void Main (string[] args)
        {
            int[] array = CreateArray(20); // выводит ммассив из 20 чисел по порядку от 1 до 20
            WriteArray(array);
            Console.WriteLine(" ");
            array = Shuffle(array); // перемешивает значения в массиве
            WriteArray(array);
        }
    }