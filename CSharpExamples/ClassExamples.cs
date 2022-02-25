

namespace CSharpExamples.Examples;


public class Customer
{
    
    public Customer(string name)
    {
        Name = name;
    }

    // data (state)
    // fields
    private decimal _creditLimit;

    public decimal GetCreditLimit()
    {
        return _creditLimit;
    }
   
    public void RaiseCreditLimit(decimal amount)
    {
        // do your business rules and all that...
        // then...
        _creditLimit += amount;
    }

    public void LowerCreditLimit(decimal amount)
    {

        _creditLimit -= amount;
    }
    public int Age { get; init; }
    // behavior 
    // Methods, etc. that use that data

    public string Name {  get; private set; } = string.Empty;

    public void DanceAJig()
    {
        // doesn't use any of the data of the class.
    }
}