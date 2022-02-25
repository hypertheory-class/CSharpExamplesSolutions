
using CSharpExamples.Examples;

namespace CSharpExamples;

public class ClassDetails
{
    [Fact]
    public void Properties()
    {
        var c = new Customer("Pete");
        //var c2 = new Customer("Laura", 17);
        var c2 = new Customer("Laura") { 
            Age = 17 };

        Assert.Equal("Pete", c.Name);

        Assert.Equal(17, c2.Age);

        


       // c.Name = "Paul";



       
    }
}
