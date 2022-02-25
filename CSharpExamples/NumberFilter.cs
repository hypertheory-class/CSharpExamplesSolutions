using CSharpExamples.Examples;
using System;
using System.Collections.Generic;

namespace CSharpExamples;

public delegate int StringToNumber(string s);

//public delegate bool IncludeInResults(int x);
public class NumberFilter
{
    public List<int> RemoveEvens(List<int> numbers)
    {
        var x = new Predicate<int>(IsOdd);
        return Filter(numbers,x); // explicit delegate instance

    }
    public List<int> RemoveOdds(List<int> numbers)
    {
        // return Filter(numbers,IsEven); // Method Group
        // "Anonymous "function - a function with no name.
        //return Filter(numbers, delegate (int z)
        //{
        //    return z % 2 != 0;
        //});
        return Filter(numbers, (n) => n % 2 != 0);
    }
    private List<int> Filter(List<int> numbers, Predicate<int> check)
    {
        var response = new List<int>();
        foreach (var number in numbers)
        {

            if (check(number))
            {
                response.Add(number);
            }
        }
        return response;
    }

    private bool IsOdd(int number)
    {
        return number % 2 != 0;
    }

    //private bool IsEven(int number)
    //{
    //    return number % 2 == 0;
    //}

    private bool LeftIsBiggerThanRight(int x, int y)
    {
        return x > y;
    }

}
