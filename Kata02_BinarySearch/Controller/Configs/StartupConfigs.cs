using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kata02_BinarySearch.Controller.Configs
{
    class StartupConfigs
    {
        public static int[] CreateArray(int size)
        {
            int[] array = new int[size - 1];
            for (int i = 0; i < size - 1; i++)
            {
                array[i] = i;
            }

            //PrintArray(array);

            return array;
        }

        public static void PrintArray(int[] inputArray)
        {
            int arrayLenght = inputArray.ToList().Count();
            for (int i = 0; i < arrayLenght; i++)
            {
                Console.Write(" " + inputArray[i]);
            }
        }
    }
}
