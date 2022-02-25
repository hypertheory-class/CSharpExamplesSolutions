

namespace CSharpExamples;

public static class HtmlUtils
{
    public static string MakeTag(string tag, string content)
    {
        return $"<{tag}>{content}</{tag}>";
    }
}

public class TagMaker
{
    private string _tag;

    public TagMaker(string tag)
    {
        _tag = tag;
    }

    public string Make(string content)
    {
        return $"<{_tag}>{content}</{_tag}>";
    }
}