
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
}
