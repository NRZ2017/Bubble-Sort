using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bubble_Sort
{
    class Program
    {
        static int[] RandomArray(Random rand)
        {
            int[] array = new int[1];
            for(int i = 0; i < array.Length; i++)
            {
                array[i] = rand.Next();
            }
            return array;
            //throw new NotImplementedException();
        }


        static void Main(string[] args)
        {
            int[] Array = RandomArray(new Random());

            for(int i = 0; i < Array.Length; i++)
            {
                if(Array[0] < Array[1])
                {
                    Array[0]++;
                }
            }

            Console.ReadKey();
        }
    }
}
