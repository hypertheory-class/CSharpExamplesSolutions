

using System;
using Xunit;

namespace CSharpExamples;

public class TestingDemo
{
    [Fact]
    public void CanAddTwoIntegers()
    {
        // Setup / Given / Arrange More Notes
        
        int x = 10;
        int y = 20;

        // Do It / When / Act
        int answer = x + y;

        // Did it work right? / Then / Assert
        Assert.Equal(30, answer);
    }
}
