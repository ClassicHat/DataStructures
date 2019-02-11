using System;
using System.Collections;
using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting
{
    class Driver
    {
        //Class Level Variable
        //This number sets the array size but also the amount of data in the FillArray class.
        public static int ARRAY_SIZE = 100;

        static void Main(string[] args)
        {
            ArrayList mainArray = new ArrayList();

            SameDataArray(mainArray);
            NormSortedArray(mainArray);
            RevsSortedArray(mainArray);
            RandomSortedArray(mainArray);

            ReadKey();
        }//End Main Method
        
        public static void SameDataArray(ArrayList mainArray)
        {
            int[] secondaryArray = new int[ARRAY_SIZE];

            WriteLine("Begin - Same Data Sort");
            FillArray.FillArrayData(mainArray, 0);
            PrintArray(mainArray);
            CountArray(mainArray, secondaryArray);
            WriteLine("\n");
            PrintArray(secondaryArray);
            WriteLine("\n");
            SortArray(mainArray, secondaryArray);
            PrintArray(mainArray);
            WriteLine("End - Same Data Sort");
        }

        public static void NormSortedArray(ArrayList mainArray)
        {
            int[] secondaryArray = new int[ARRAY_SIZE];
            mainArray.Clear();
            WriteLine("Begin - Different Values But Sorted");
            FillArray.FillArrayData(mainArray, 1);
            PrintArray(mainArray);
            CountArray(mainArray, secondaryArray);
            WriteLine("\n");
            PrintArray(secondaryArray);
            WriteLine("\n");
            SortArray(mainArray, secondaryArray);
            PrintArray(mainArray);
            WriteLine("End - Different Values But Sorted");
        }

        public static void RevsSortedArray(ArrayList mainArray)
        {
            int[] secondaryArray = new int[ARRAY_SIZE];
            mainArray.Clear();
            WriteLine("Begin - Different Values Reverse Sorted");
            FillArray.FillArrayData(mainArray, 2);
            PrintArray(mainArray);
            CountArray(mainArray, secondaryArray);
            WriteLine("\n");
            PrintArray(secondaryArray);
            WriteLine("\n");
            SortArray(mainArray, secondaryArray);
            PrintArray(mainArray);
            WriteLine("End - Different Values Reverse Sorted");
        }

        public static void RandomSortedArray(ArrayList mainArray)
        {
            int[] secondaryArray = new int[ARRAY_SIZE];
            mainArray.Clear();
            WriteLine("Begin - Random Data Randomly Ordered");
            FillArray.FillArrayData(mainArray, 3);
            PrintArray(mainArray);
            CountArray(mainArray, secondaryArray);
            WriteLine("\n");
            PrintArray(secondaryArray);
            WriteLine("\n");
            SortArray(mainArray, secondaryArray);
            PrintArray(mainArray);
            WriteLine("End - Random Data Randomly Ordered");
        }

        /// <summary>
        /// Expects: An ArrayList to print
        /// Returns: Nothing
        /// Tasks: When given an array, print the contents of the array.
        /// </summary>
        /// <param name="mainArray"></param>
        public static void PrintArray(ArrayList theArray)
        {
            int count = 0;

            foreach(int num in theArray)
            {
                Write(num + " ");
                count++;

                if(count == 25)
                {
                    WriteLine();
                    count = 0;
                }//End if
            }//End foreach
        }//End PrintArray

        /// <summary>
        /// Expects: An ArrayList to print
        /// Returns: Nothing
        /// Tasks: When given an array, print the contents of the array.
        /// </summary>
        /// <param name="theArray"></param>
        public static void PrintArray(int[] theArray)
        {
            int count = 0;

            foreach (int num in theArray)
            {
                Write(num + " ");
                count++;

                if (count == 25)
                {
                    WriteLine();
                    count = 0;
                }//End if
            }//End foreach
        }//End PrintArray

        public static void CountArray(ArrayList mainArray, int[] secondaryArray)
        {
            foreach(int num in mainArray)
            {
                int value = (int) secondaryArray[num];
                secondaryArray[num] = value + 1;
            }//End foreach
        }//End CountArray

        /// <summary>
        /// Expects: The mainArray and the secondaryArray
        /// Returns: Nothing
        /// Tasks: Depending on the number in the secondaryArray, add the index
        ///     that number of times to the mainArray.
        /// </summary>
        /// <param name="mainArray"></param>
        /// <param name="secondaryArray"></param>
        public static void SortArray(ArrayList mainArray, int[] secondaryArray)
        {
            int value = 0;
            mainArray.Clear();
            foreach(int num in secondaryArray)
            {
                for (int lcv1 = 0; lcv1 < num; lcv1++)
                {
                    mainArray.Add(value);
                }//End for loop
                value++;
            }//End foreach loop
        }//End SortArray

    }//End Class
}//End Namespace
