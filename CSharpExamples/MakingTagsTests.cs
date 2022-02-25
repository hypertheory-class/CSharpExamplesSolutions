

namespace CSharpExamples;

public class MakingTagsTests
{
    [Theory]
    [InlineData("h1", "Hello", "<h1>Hello</h1>")]
    [InlineData("h1", "Goodbye", "<h1>Goodbye</h1>")]
    [InlineData("p", "content", "<p>content</p>")]
    public void MakingTagsWithAMethod(string el, string content, string expected)
    {

        Assert.Equal(expected, HtmlUtils.MakeTag(el, content));
    }

    [Fact]
    public void UsingAClass()
    {
        var h1Maker = new TagMaker("h1");
        Assert.Equal("<h1>Hello</h1>", h1Maker.Make("Hello"));
        Assert.Equal("<h1>Goodbye</h1>", h1Maker.Make("Goodbye"));

        var pMaker = new TagMaker("p");
        Assert.Equal("<p>Stuff</p>", pMaker.Make("Stuff"));
    }

    [Fact]
    public void HigherOrderFunctionalWay()
    {

        // Higher-Order Function
        // It is using a closure
        Func<string, Func<string, string>>  tagMaker = (tag) => (content) => $"<{tag}>{content}</{tag}>";

        var h1Maker = tagMaker("h1");
        var pMaker = tagMaker("p");

        Assert.Equal("<h1>Hello</h1>", h1Maker("Hello"));
        Assert.Equal("<h1>Goodbye</h1>", h1Maker("Goodbye"));
        Assert.Equal("<p>Stuff</p>", pMaker("Stuff"));


    }
}
