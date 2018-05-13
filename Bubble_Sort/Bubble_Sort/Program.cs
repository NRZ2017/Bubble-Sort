using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bubble_Sort
{
    class Program
    {
        static int[] RandomArray(int size, Random rand)
        {
            int[] array = new int[size];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rand.Next(0, size);
            }
            return array;
        }


        static int[] BubbleSort(int[] array)
        {
            bool sorting = true;
            while (sorting)
            {
                sorting = false;
                for (int i = 1; i < array.Length; i++)
                {
                    if (array[i] < array[i - 1])
                    {
                        sorting = true;
                        //swap
                        int tempValue = array[i];
                        array[i] = array[i - 1];
                        array[i - 1] = tempValue;
                    }

                }
            }
            return array;

        }

        //split
        static int[] MergeSort(int[] array, int low, int high)
        {
            //recursive
            if (high - low <= 1)
            {
                return array;
            }

            int mid = (low + high) / 2;
            MergeSort(array, low, mid);
            MergeSort(array, mid, high);

            Merge(array, low, mid);
            Merge(array, mid + 1, high);
            return array;
        }

        static int[] Merge(int[] array, int low, int high)
        {
            //array1 = low to mid
            //array2 = mid+1 to high

            bool sorting = true;
            while (sorting)
            {
                sorting = false;
                for (int i = 1; i < array.Length; i++)
                {
                    if (array[i] < array[i - 1])
                    {
                        sorting = true;
                        //swap
                        int tempValue = array[i];
                        array[i] = array[i - 1];
                        array[i - 1] = tempValue;
                    }

                }
            }


            return array;
            // throw new NotImplementedException();
        }



        static int[] SelectionSort(int[] array)
        {
            //find the smallest number in the array

            for (int j = 0; j < array.Length; j++)
            {

                int small = j;
                for (int i = j + 1; i < array.Length; i++)
                {
                    if (array[i] < array[small])
                    {
                        small = i;
                    }
                }
                //swap swap starting index with small index
                int TempValue = array[small];
                array[small] = array[j];
                array[j] = TempValue;
            }

            return array;
        }

        static int[] InsertionSort(int[] array)
        {

            for (int sorted = 0; sorted < array.Length - 1; sorted++)
            {
                for (int i = sorted + 1; i > 0; i--)
                {
                    if (array[i] < array[i - 1])
                    {
                        int tempValue = array[i];
                        array[i] = array[i - 1];
                        array[i - 1] = tempValue;
                    }
                    else
                    {
                        break;
                    }
                }
            }
            return array;
        }


        static int[] QuickSort(int[] array)
        {
            int left = 0;
            int right = array.Length - 2;
            int pivot = array.Length - 1;
            for (int i = 0; i < right; i++)
            {
                left++;
                for (int u = array.Length; u >= 0; u++)
                {
                    right--;
                    if (left > right)
                    {
                        pivot = left - 1;
                        pivot = right + 1;
                        left = 0;
                    }
                }
            }


            return array;
            // throw new NotImplementedException();
        }





        static void Main(string[] args)
        {
            int[] array = RandomArray(20, new Random());
            int[] copy = array.OrderBy(x => x).ToArray();

            //array = BubbleSort(array);
            //array = SelectionSort(array);

            array = QuickSort(array);

            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine($"{copy[i]}");
            }
            Console.ReadKey();
        }
    }
}
