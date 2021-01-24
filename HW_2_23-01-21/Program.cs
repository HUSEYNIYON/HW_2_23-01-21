using System;
using System.Linq;

namespace HW_2_23_01_21
{
    class Program
    {
        static void Main(string[] args)
        {
            // Task 2
            //Console.Write("Enter ArraySize = ");
            //int arraySize = Convert.ToInt32(Console.ReadLine());
            //double[] array = new double[arraySize];
            //Random rand = new Random();
            //for (int i = 0; i < array.Length; i++)
            //{
            //    array[i] = rand.Next(-1000,1000);
            //}
            //double maxVal = array.Max();
            //double minVal = array.Min();
            //double totalSum = array.Sum();
            //double avarageVal = array.Average();

            //for (int i = 0; i < array.Length; i++)
            //{
            //    Console.WriteLine($"array[{i}] = " + array[i]);
            //}
            //Console.WriteLine($"\nMax = {maxVal} \nMin = {minVal} \nSum = {totalSum} \nAvg = {avarageVal}\n");
            //for (int i = 0; i < array.Length; i++)
            //{
            //    if (array[i] % 2 != 0)
            //        Console.WriteLine($"Odd {i} = {array[i]}");
            //}

            //Task 3
            //double[] arr = new double[5]{1,2,3,4,5};
            //Console.WriteLine("Array:");
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    Console.WriteLine($"Arr[{i}] = {arr[i]}");
            //}
            //Console.WriteLine("\nReversed:");
            //Array.Reverse(arr);
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    Console.WriteLine($"Arr[{i}] = {arr[i]}");
            //}

            //Task 4
            Console.WriteLine("Enter arrSize = ");
            int arrSize = Convert.ToInt32(Console.ReadLine());
            int[] firstArray = new int[arrSize];
            Random random = new Random();
            for (int i = 0; i < firstArray.Length; i++)
            {
                firstArray[i] = random.Next(-1000,1000);
            }
            Console.WriteLine();
            for (int i = 0; i < firstArray.Length; i++)
            {
                Console.WriteLine($"firstArray=[{i}]=" + firstArray[i]);
            }
            Console.Write("\ncount=");
            int Count = Convert.ToInt32(Console.ReadLine());  //3
            Console.Write("index=");
            int index = Convert.ToInt32(Console.ReadLine());  //2
            int[] secondArray = new int[Count];
            for (int j = 0; j < Count; j++)
            {
                if (j + index < firstArray.Length)
                {
                    secondArray[j] = firstArray[j + index];
                }
                else
                {
                    secondArray[j] = 1;
                }
            }
            for (int j = 0; j < secondArray.Length; j++)
            {
                Console.WriteLine($"arr[{j}]=" + secondArray[j]);
            }
        }
    }
}
