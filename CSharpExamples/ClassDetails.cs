
using CSharpExamples.Examples;
using System.Collections.Generic;
using CSharpExamples.Extensions;
using System.Linq;

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

    [Fact]
    public void Methods()
    {
        // methods should be cohesive with the data of the class.

        var utils = new JunkDrawer();

        var fullName = utils.FormatName("Luke", "Skywalker");

        Assert.Equal("Skywalker, Luke", fullName);

       
        fullName = utils.FormatName("Han", "Solo", "D");

        Assert.Equal("Solo, Han D.", fullName);
    }

    [Fact]
    public void ReturnTypeStuff()
    {

        var pu = new PritingUtils();

        var response = pu.FormatName("Han", "Solo");

        Assert.Equal("Solo, Han", response.FullName);
        Assert.Equal(9, response.NumberOfLetters);

    }

    [Fact]
    public void MutatingRecords()
    {
        var employee = new Employee("Bob", "Smith", 180000);

        Assert.Equal("Bob", employee.FirstName);
        Assert.Equal(180000, employee.Salary);

        //var updateEmployee = new Employee(
        //        employee.FirstName,
        //        employee.LastName,
        //        190000
        //    );
        var updateEmployee = employee with { Salary = 190000 };

        Assert.Equal("Bob", employee.FirstName);
        Assert.Equal(180000, employee.Salary);

        Assert.Equal("Bob", updateEmployee.FirstName);
        Assert.Equal(190000, updateEmployee.Salary);

    }

    [Fact]
    public void UtilityFunctions()
    {

        var someNumber = 12;

        var tommorow = 30.DaysFromToday();

        if(someNumber.IsEven())
        {
            // something happens.
        } else
        {
            // something else happens.
        }

       // Assert.Equal(2, "Abba".CountVowels());

        var name = "Gonzalez";


        var numbers = "1,2,3,4,5,6,7,8,9";

        var sum = numbers.Split(',')
            .Select(int.Parse)  // => [ 1, 2, 3, 4,5, 6, 7, 8, 9] 
            .Where(n => n.IsEven()) // [2,4,6,8]
            .Sum();

        Assert.Equal(20, sum);

    }
}

