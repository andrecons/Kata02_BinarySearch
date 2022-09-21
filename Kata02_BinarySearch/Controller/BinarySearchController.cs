using Kata02_BinarySearch.Controller.BinaryFunctions;
using Kata02_BinarySearch.Controller.Configs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kata02_BinarySearch.Controller
{
    public static class BinarySearchController
    {
        public static void Start(int boundary)
        {
            //Creating the array
            int[] array = StartupConfigs.CreateArray(501);

            int userInput = Finder.AskValue();

            Console.WriteLine("\n");

            int indexOfUserInput = Finder.IndexByLinear2(array, userInput);
            Console.WriteLine("Index by Linear method: " + indexOfUserInput);

            indexOfUserInput = Finder.IndexByBinaryIterative(array, userInput);
            Console.WriteLine("Index by Binary Iterative method: " + indexOfUserInput);

            indexOfUserInput = Finder.IndexByBinaryRecursive(array, userInput, 0, (array.Length - 1));
            Console.WriteLine("Index by Binary Recursive method: " + indexOfUserInput);

        }

    }
}
