using System;
using System.Collections.Generic;

namespace CSharpExamples;

public class NumberFilter
{
    public List<int> RemoveEvens(List<int> numbers)
    {
        var response = new List<int>();
        foreach(var number in numbers)
        {
            if(number % 2 == 0)
            {
                response.Add(number);
            }
        }
        return response;

    }
}
