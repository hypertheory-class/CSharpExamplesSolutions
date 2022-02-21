


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
    [Theory]
    [InlineData(10,2, 12)]
    [InlineData(2,2, 4)]
    [InlineData(2,20, 22)]
    public void CanAddTwoIntegersTheory(int x, int y, int expected)
    {
        int answer = x + y;

        Assert.Equal(expected, answer);
    }
}
