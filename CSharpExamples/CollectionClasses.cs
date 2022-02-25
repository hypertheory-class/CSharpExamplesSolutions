using System.Collections; // Largely deprecated - don't use them for reasons I will show you.
using System.Collections.Generic;

namespace CSharpExamples;

public class CollectionClasses
{
    [Fact]
    public void HavingAListOfThings()
    {
        var favoriteNumbers = new ArrayList();
        favoriteNumbers.Add(1);
        favoriteNumbers.Add(9);
        favoriteNumbers.Add(20);
        favoriteNumbers.Add(108);

        Assert.Equal(1, favoriteNumbers[0]); // "Indexer" means the square brackets
        Assert.Equal(108, favoriteNumbers[3]);
        favoriteNumbers[1] = 19;

        Assert.Equal(19, favoriteNumbers[1]);
        Assert.Equal(4, favoriteNumbers.Count);
       
        Assert.Throws<ArgumentOutOfRangeException>(() => favoriteNumbers[4] = 999);

        favoriteNumbers.Add("Tyranosaurex Rex");
        
        var sum = ((int)favoriteNumbers[2]) + ((int)favoriteNumbers[3]);

        Assert.Equal(128, sum);
    }

    [Fact]
    public void UsingGenericsCollections()
    {
        // "Parametric Polymorphism" - 
        var favoriteNumbers = new List<int>() { 1, 9, 20, 108 };
        //favoriteNumbers.Add(1);
        //favoriteNumbers.Add(9);
        //favoriteNumbers.Add(20);
        //favoriteNumbers.Add(108);

        var sum = favoriteNumbers[2] + favoriteNumbers[3];
        Assert.Equal(128, sum);
    }

    [Fact]
    public void Dictionaries()
    {
        var favoriteNumbers = new Dictionary<int, int>();
        favoriteNumbers.Add(32, 8);

        Assert.Equal(8, favoriteNumbers[32]);

        var stateCodes = new Dictionary<string, string> {
            { "OH", "Ohio" },  // Key-Value Pairs
            { "KY", "Kentucky" },
            { "CO", "Colorado" }
        };

        Assert.Equal("Ohio", stateCodes["OH"]);

        Assert.True(stateCodes.ContainsKey("OH"));
        Assert.False(stateCodes.ContainsKey("CA"));
    }
}
