using System;
using System.Collections.Generic;
using System.Linq;
public static class LINQArray
{
    public static int GetMaxNoFromArry(Int32[] array)
    {
        return array.Max();
    }


    public static int[] ArrayNumberLeftRotation(int[] array, int rotationNo)
    {
        return array.Skip(rotationNo).Concat(array.Take(rotationNo)).ToArray();
    }

public static int GetSecondMaxNoFromArry(Int32[] array)
    {
        return array.OrderByDescending(i => i).Distinct().Skip(1).First();
    }

    public static int GetNthMaxNoFromArry(Int32[] array, int nth)
    {
        return array.OrderByDescending(i => i).Distinct().Skip(nth-1).First();
    }

    public static int GetMinNoFromArry(Int32[] array)
    {
        return array.Min();
    }

    public static int GetSecondMinNoFromArry(Int32[] array)
    {
        return array.OrderBy(i => i).Distinct().Skip(1).First();
    }

    public static int GetNthMinNoFromArry(Int32[] array, int nth)
    {
        return array.OrderBy(i => i).Distinct().Skip(nth-1).First();
    }

    public static List<Tuple<int,int>> GetPairNumbersWhereSumIsGivenNumber(Int32[] numbersArray, int numbersum, WayofOperation waytodo)
    {
        List<Tuple<int, int>> pairs = new List<Tuple<int, int>>();
        if (waytodo == WayofOperation.Query)
        {
            pairs = (from numberone in numbersArray
                         from numbertwo in numbersArray
                         where numberone + numbertwo == numbersum
                         select new Tuple<int, int>(numberone, numbertwo)).Distinct().ToList();
        }
        else
        {
            pairs = numbersArray.Join(numbersArray,
                noone => true,
                notwo => true,
                (noone, notwo) => new Tuple<int, int>( noone, notwo )
                ).Where( a => a.Item1 + a.Item2 == numbersum).Distinct().ToList() ;

        }
        return pairs;
    }


    public static int GetMaxOccurredNumber(Int32[] numbersArray, WayofOperation waytodo)
    {
        int maxOccuredNo = 0;
        if (waytodo == WayofOperation.Query)
        {
            maxOccuredNo = (from a in numbersArray
                            group a by a into g
                            orderby g.Count() descending
                            select new { g.Key }
                            ).First().Key;
        }
        else
        {
            maxOccuredNo = numbersArray.GroupBy(i => i).OrderByDescending(i => i.Count()).First().Key;
        }

        return maxOccuredNo;
    }


    public static Tuple<int, int> GetSumOfEvenandOddNumbers(Int32[] numbersArray)
    {
        int sumOfEven = 0, sumOfOdd = 0;

        numbersArray.ToList().ForEach(

            i =>
            {

                if(i % 2 == 0)
                {
                    sumOfEven += i;
                }
                else
                {
                    sumOfOdd += i;
                }

            }

            );

        return new Tuple<int, int>(sumOfEven,sumOfOdd);
    }

    public static string CustomFormat(this string s, string arg)
    {
         return string.Format("{0} : {1}", arg, s);
    }

    public static string ToStringForTuple(this Tuple<int,int> s)
    {
        return string.Format("      ( {0} , {1} )", s.Item1, s.Item2);
    }

    public enum WayofOperation
    {
        Query,
        Lambda
    }
}