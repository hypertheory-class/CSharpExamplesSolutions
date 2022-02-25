




using System.Diagnostics;
using System.Linq.Expressions;

public class Program
{
    public static void Main()
    {
        Func<int, bool> isItLessThanFive = num => num < 5;
        //Expression<Func<int, bool>> lambda = num => num < 5; // A data structure that describes what the code is doing.
        ///// this is homoiconicity - which is a thing in languages where the code is in data structures the same as data.
        ///// this means you can write code to look at what the code is doing and change it, or translate it or whatever.

        //Console.WriteLine(isItLessThanFive(8));
        //Console.WriteLine(isItLessThanFive(3));

        var context = new List<Customer>
        {
            new() { Name = "Bob", State="CO", Balance = 4999.99M},
            new() { Name = "Sue", State="OH", Balance = 10000},
            new() { Name = "Xavier", State="CO", Balance = 5001},
            new() { Name = "Ray", State ="CO", Balance = 6000}
        };

        var oweMe = context
            .Where(c => c.Balance >= 5000 && c.State == "CO").OrderBy(c => c.Name).Select(n => n.Name);
        
        
        foreach(var c in oweMe)
        {
            Console.WriteLine(c);
        }



        //var friends = new List<string> { "Tim", "Ray", "Sean", "Bill", "Carl", "Sue" };

        //var threeLetterNamedFriends = friends.Where(f => f.Length == 3); // Filter


        //threeLetterNamedFriends = threeLetterNamedFriends.Select(f => f.ToUpper()); // Map

       
        //friends[0] = "Timothy";
        //friends[2] = "Sun";

        //foreach (var friend in threeLetterNamedFriends)
        //{
        //    Console.WriteLine(friend);
        //}

        //Console.WriteLine("About to do it...");
        //var n = new NumberStuff();
        //var sw = new Stopwatch();
        //sw.Start();

        //var allTheNumbers = n.GetNumbersOneToOneHundred();
        //foreach (var num in allTheNumbers.Skip(8).Take(10).Where(IsEven))
        //{
        //    Console.WriteLine(num);
           
        //}
        //sw.Stop();
        //Console.WriteLine($"That took about {sw.ElapsedMilliseconds} ms");
    }

    public static bool IsEven(int x)
    {
        return x %2 == 0;
    }
    
}

public class NumberStuff
{
    public IEnumerable<int> GetNumbersOneToOneHundred()
    {
        
        foreach(var num in Enumerable.Range(1,100))
        {
            Thread.Sleep(100); // 100 MS
            yield return num;
        }
       
    }
}

public class Customer
{
    public string Name { get; set; }
    public decimal Balance { get; set; }
    public string State { get; set; }
}