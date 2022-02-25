

namespace CSharpExamples.Examples;


public class Customer
{
    public Customer(string name)
    {
        Name = name;
    }

    // data (state)
    // fields
   
    public int Age { get; init; }
    // behavior 
    // Methods, etc. that use that data

    public string Name {  get; private set; } = string.Empty;
}