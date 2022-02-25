

namespace CSharpExamples.Examples;

public class JunkDrawer
{

    public string FormatName(string firstName, string lastName, string mi)
    {

        return this.FormatName(firstName, lastName) + $" {mi}.";

    }

    public string FormatName(string firstName, string lastName)
    {
        return $"{lastName}, {firstName}";
        // return `${lastName}, ${firstName}`;
    }

  
}

public class PritingUtils
{
    public FormatNameResponse FormatName(string first, string last)
    {
        var fullName = $"{last}, {first}";
        return new FormatNameResponse(fullName, fullName.Length);
        
    }

    public int Add(int a, int b)
    {
        return a + b;
    }
}

//public class FormatNameResponse
//{
//    public FormatNameResponse(string fullName, int numberOfLetters)
//    {
//        FullName = fullName;
//        NumberOfLetters = numberOfLetters;
//    }
//    public string FullName { get; private set; } = string.Empty;
//    public int NumberOfLetters { get; private set ; }
//}

public record FormatNameResponse(string FullName, int NumberOfLetters);


public record Employee(string FirstName, string LastName, decimal Salary);