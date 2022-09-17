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
            int[] array = StartupConfigs.CreateArray(boundary);
            int userInput = Finder.AskValue();

            int indexOfUserInput = Finder.GetIndexByLinear(array, userInput);
            Console.WriteLine("Index by Linear method: " + indexOfUserInput);

            indexOfUserInput = Finder.GetIndexByBinaryIterative(array, userInput);
            Console.WriteLine("Index by Binary Iterative method: " + indexOfUserInput);
            
        }

    }
}
