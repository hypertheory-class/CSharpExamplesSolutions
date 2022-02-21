

using System;

namespace CSharpExamples;

public class DeclaringVariables
{
   
    [Fact]
    public void ExplicitlyDecaringAVariable()
    {
        int x = 12;
        Int32 y;

        y = 0;

        string myName = "Jeff";
        String yourName;
        
        yourName = "Joe";

        Assert.Equal(12, x);
        Assert.Equal(0, y);
        Assert.Equal("Joe", yourName);

    }

    [Fact]
    public void ImplicitlyDeclaringAVariable()
    {
        var x = 12; // any literal number in code that doesn't have a . 
        var myName = "Jeff";

        var something = 3.14; // any number with a decimal is a Double

        Dog rover = new Dog();
        var fido = new Dog();

        Dog fluffy = new(); // C# 9 - don't use it a ton like this.

        var birthday = new DateTime(1969, 4, 20);

    }

    [Fact]
    public void ValuesAndReferences()
    {

        // more on this later.
        int age = default;
        string name = default;
        DateTime birthDay = default;
        decimal pay = default;
        Dog rover = default;

        Assert.Equal(0, pay);
        Assert.Equal(0, age);
        Assert.Equal(null, name);
        Assert.Equal(new DateTime(1, 1, 1, 00, 00, 00), birthDay);
        Assert.Equal(null, rover);
    }
}

public class Dog { }
