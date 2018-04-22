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
        static void Main(string[] args)
        {
            int[] array = RandomArray(10, new Random());

            //array = BubbleSort(array);
            //array = SelectionSort(array);
            array = InsertionSort(array);
            //print array

            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"{array[i]} ");
            }
            Console.ReadKey();
        }
    }
}
