

var numbers = new List<int> { 1, 8, 12, 32 };


foreach(var number in numbers)
{
    Console.WriteLine(number);
}


var friends = new Dictionary<char, string>
{
    { 's', "Sean" },
    { 'v', "Violet" },
    { 'r', "Ray" }
};

foreach(var friend in friends.Values)
{
    Console.WriteLine(friend);
}

foreach(var friendKey in friends.Keys)
{
    Console.WriteLine(friendKey);
}

foreach(var kvp in friends)
{
    Console.WriteLine($"The key {kvp.Key} is for {kvp.Value}");
}

foreach (var (k,v) in friends) // this is destructuring into a tuple.
{
    Console.WriteLine($"The key {k} is for {v}");
}

