
using CSharpExamples.Extensions;
using System.Collections.Generic;

namespace CSharpExamples;

public class NumberFilterTests
{

    [Fact]
    public void CanFilterOutEvens()
    {
        var filter = new NumberFilter();
        var numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

        List<int> evens = filter.RemoveEvens(numbers);

        Assert.Equal(5, evens.Count);
        Assert.Equal(1, evens[0]);
        Assert.Equal(3, evens[1]);
        Assert.Equal(5, evens[2]);
        Assert.Equal(7, evens[3]);
        Assert.Equal(9, evens[4]);

    }

    [Fact]
    public void CanFilterOutOdds()
    {
        var filter = new NumberFilter();
        var numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

        List<int> evens = filter.RemoveOdds(numbers);

        Assert.Equal(4, evens.Count);
        Assert.Equal(2, evens[0]);
        Assert.Equal(4, evens[1]);
        Assert.Equal(6, evens[2]);
        Assert.Equal(8, evens[3]);
    }

    [Fact]
    public void BuiltInDelegateTypes()
    {

        // any method that returns a value and takes from 0 - 16 paramaters
        // can use a built-in delegate type called a "Func"

        Func<int, int, int> mathOp;

        mathOp = (a, b) => a + b;
        Assert.Equal(4, mathOp(2, 2));
        mathOp = (a, b) => a - b;
        Assert.Equal(0, mathOp(2, 2));

        //Predicate<int> check;
        Func<int, bool> check;
        check = (a) => a % 2 == 0;
        Assert.True(check(4));
        check = (a) => a % 2 != 0;
        Assert.False(check(4));

        // Actions are for void methods that take up to 16 arguments.

        Action<string, string> thing;
        thing = (a, b) => Console.WriteLine($"{b}, {a}");


    }

    public int CountLetters(string x)
    {
        return x.Length;
    }
}
