using System;

namespace homework_6_arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int N = 10;
            int[] array = new int[N];

            int i = 0;

            var random = new Random();
            int[] randomArray = new int[N];
            for (i = 0; i < N; i++)
            {
                randomArray[i] = random.Next(100);
            }

            i = 0;
            foreach (int item in randomArray)
            {
                Console.WriteLine($"{i++} item of array is {item}");
            }

            Console.WriteLine("------------------------------------");

            i = 0;
            foreach (int item in Sort(randomArray))
            {
                Console.WriteLine($"{i++} item of array is {item}");
            }

            Console.WriteLine("------------------------------------");

            i = 0;
            foreach (int item in SelectionSort(randomArray))
            {
                Console.WriteLine($"{i++} item of array is {item}");
            }

            Console.WriteLine("------------------------------------");

            i = 0;
            foreach (int item in InsertionSort(randomArray,10))
            {
                Console.WriteLine($"{i++} item of array is {item}");
            }
        }
        static int[] InsertionSort(int[] array,int N)
        {
            int i, key, j;
            for (i = 1; i < N; i++)
            {
                key = array[i];
                j = i - 1;
                while (j >= 0 && array[j] > key)
                {
                    array[j + 1] = array[j];
                    j = j - 1;
                }
                array[j + 1] = key;
            }
            return array;
        }

        static int[] SelectionSort(int[] array)
        {
            int n = array.Length;
            for (int i = 0; i < n - 1; i++)
            {
                int minIdx = i;
                for (int j = i + 1; j < n; j++)
                    if (array[j] < array[minIdx])
                        minIdx = j;

                int temp = array[minIdx];
                array[minIdx] = array[i];
                array[i] = temp;
            }
            return array;
        }

    static int[] Sort(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array.Length - 1; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        int temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                    }
                }
            }

            return array;
        }
    }
}
