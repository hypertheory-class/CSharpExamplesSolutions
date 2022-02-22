
using System.Linq;
using System.Text;

namespace CSharpExamples;

public class StringsAndStuff
{
    [Fact]
    public void StringsAreImmutable()
    {
        // Immutable means you can't change it.

        var name = "William";
        Assert.Equal("William", name);

        // name = name + " Blake";
        name += " Blake";
        Assert.Equal("William Blake", name);

    }

    [Fact]
    public void CreatingABigHonkingString()
    {
        //var starter = "";
        // StringBuilder is a "mutable" (changeable) string.
        // Use this if:
        // --- You are making ANY changes to "big" strings.
        // --- You are making lots of changes to a string.
        // --- It will use way less memory, though is slightly slower
        // --- and more awkward than a string, so don't think
        // --- Well, to be safe, I'll always use this.
        var starter = new StringBuilder();
        foreach (var num in Enumerable.Range(1, 1000))
        {
            starter.Append(num + ", ");
        }

        //Assert.StartsWith(starter.ToString(), "1, 2, 3, 4");
    }

    [Fact]
    public void FormattingStrings()
    {
        var name = "Bob Smith";
        var age = 39;
        var pay = 120000.32M; // "M" means deciMal. I didn't make this up.

        // var message = "The name is " + name + ", they are " + age + " years old, and make " + pay.ToString("c") + " a year";

        //var message = string.Format("The name is {0}, they are {1} years old, and make {2:c} a year", name, age, pay);

        var message = $"The name is {name}, they are {age} years old, and make {pay:c} a year";

        Assert.Equal(message, "The name is Bob Smith, they are 39 years old, and make $120,000.32 a year");

    }

    [Fact]
    public void StringLiterals()
    {

        var message = "Hello, Welcome\n\t\tWelcome to The App";
        var pathToFile = @"c:\dev\learningcsharp\solution.sln";

        var story = @"Chapter 1

        It was a dark and stormy night


The End";
       

    }

    [Fact]
    public void CharacterLiterals()
    {
        // characters are a single unicode code point.
        // a single "letter";

        var x = "X";
        char y = 'Y';

        //Assert.Equal(x, y);
    }
}
