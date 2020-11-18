/* Date: 11/18/2020
 * Purpose: To demonstrate arrays and static methods of arrays
 *          Also demonstrates that Arrays use IEnumerable.
 * 
 */

using System;
using System.Collections;
using static System.Array;

namespace Spr2019CS_ArrayCollections
{
    class Program
    {
        private static int[] intValues = { 1, 2, 3, 4, 5, 6, 7 };
        private static double[] dValues = { 8.4, 9.3, 0.2, 7.9, 3.4 };
        private static int[] intValuesCopy;
        static void Main(string[] args)
        {
            intValuesCopy = new int[intValues.Length]; // Initialized to zero

            Console.WriteLine("Initial array values:\n");
            PrintArrays();

            // Sort dValues
            Sort(dValues);  // Call to the Array static method Sort
            // Copy intValues into intValuesCopy
            Array.Copy(intValues, intValuesCopy, intValues.Length);
            PrintArrays();
            Console.WriteLine();

            // Search for 5 in intValues
            int result = Array.BinarySearch(intValues, 5);
            Console.WriteLine(result >= 0 ? $"5 found at element {result}" +
                $" in intValues" : "5 not found in intValues");

            // Search for 8763 in intValues
            result = Array.BinarySearch(intValues, 8763);
            Console.WriteLine(result >= 0 ? $"8763 found at element {result}" +
                $" in intValues" : "8763 not found in intValues");
        }   // end Main()

        // Output array content with enumerators
        private static void PrintArrays()
        {
            Console.Write("dValues: ");
            // iterate thru the double array with an enumerator
            IEnumerator enumerator = dValues.GetEnumerator();
            while (enumerator.MoveNext())
                Console.Write($"{enumerator.Current} ");

            Console.Write("\nintValues: ");

            // Iterate thru the int array with an enumerator
            enumerator = intValues.GetEnumerator();
            while (enumerator.MoveNext())
                Console.Write($"{enumerator.Current} ");

            Console.Write("\nintValuesCopy: ");
            foreach (var element in intValuesCopy)
                Console.Write($"{element} ");
            Console.WriteLine();
        }   // end PrintArrays()
    }   // end class
}   // end namespace
