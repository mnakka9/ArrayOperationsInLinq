using System;
using static System.Console;

namespace ArrayOperationInLinq
{
    class Program
    {
        static void Main(string[] args)
        {
            var givenArray = new Int32[] { 1, 4, 5, 6, 7, 8, 9, 9, 9, 9, 9, 9, 3, 4, 5, 7, 5, 3, 4, 5, 4, 9, 2, 6, 9, 4, 3, 7 };

            // Get the Maximum Number
            WriteLine(LINQArray.GetMaxNoFromArry(givenArray).ToString().CustomFormat("Max number in Given array is"));

            // Get the second Maximum Number
            WriteLine(LINQArray.GetSecondMaxNoFromArry(givenArray).ToString().CustomFormat("Second Max number in Given array is"));

            // Get the nth Maximum Number
            WriteLine(LINQArray.GetNthMaxNoFromArry(givenArray, 5).ToString().CustomFormat("5th Max number in Given array is"));

            // Get the Minimum Number
            WriteLine(LINQArray.GetMinNoFromArry(givenArray).ToString().CustomFormat("Min number in Given array is"));

            // Get the 2nd Minimum Number
            WriteLine(LINQArray.GetSecondMinNoFromArry(givenArray).ToString().CustomFormat("Second Min number in Given array is"));

            // Get the nth Minimum Number
            WriteLine(LINQArray.GetNthMinNoFromArry(givenArray, 5).ToString().CustomFormat("Fifth Min number in Given array is"));

            WriteLine("Possible Combinations of Pair of Numbers using Lamba :");

            foreach (var tuple in LINQArray.GetPairNumbersWhereSumIsGivenNumber(givenArray, 9, LINQArray.WayofOperation.Lambda))
            {
                WriteLine(tuple.ToStringForTuple());
            }

            WriteLine("Possible Combinations of Pair of Numbers using Query :");

            foreach (var tuple in LINQArray.GetPairNumbersWhereSumIsGivenNumber(givenArray, 9, LINQArray.WayofOperation.Query))
            {
                WriteLine(tuple.ToStringForTuple());
            }

            // Get the Max Occured Number
            WriteLine(LINQArray.GetMaxOccurredNumber(givenArray, LINQArray.WayofOperation.Lambda).ToString().CustomFormat("Maximum occured number in array is"));

            // Get the Sum of even & odd Numbers
            var sumTuple = LINQArray.GetSumOfEvenandOddNumbers(givenArray);

            WriteLine(sumTuple.Item1.ToString().CustomFormat("Sum of Even numbers in Array"));

            WriteLine(sumTuple.Item2.ToString().CustomFormat("Sum of Odd numbers in Array"));

            Read();

        }
    }
}
