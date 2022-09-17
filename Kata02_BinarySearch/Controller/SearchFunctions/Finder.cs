using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kata02_BinarySearch.Controller.BinaryFunctions
{
    public class Finder
    {
        public static int AskValue()
        {
            Console.Write("Write a value between 0 and 499 to find its index: ");
            int value = 0;

            try
            {
                value = Int16.Parse(Console.ReadLine());
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            return value;
        }

        public static int GetIndexByLinear(int[] array, int userValue)
        {
            int index = -1;

            for (int i = 0; i < array.Length; i++)
            {
                if (userValue == array[i])
                {
                    index = i;
                    break;
                }
            }

            if (index < 0)
            {
                Console.WriteLine("Value not found");
                Environment.Exit(0);
            }


            return index;
        }

        public static int GetIndexByBinaryIterative(int[] array, int userInput)
        {
            int min = 0;
            int max = array.Length - 1;
            while (min <= max)
            {
                int mid = (min + max) / 2;
                if (userInput == array[mid])
                {
                    return (mid++);
                }
                else if (userInput < array[mid])
                {
                    max = mid - 1;
                }
                else
                {
                    min = mid + 1;
                }
            }
            //return -1 when the value is not found
            return -1;
        }
    }
}
