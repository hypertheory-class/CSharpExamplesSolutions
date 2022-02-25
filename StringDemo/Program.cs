

Action<string> logIt = (message) => Console.WriteLine($"At {DateTime.Now} you said {message}");
Action doIt = () => Console.WriteLine("Doing it!");
Action<string, int> doItManyTimes = (what, times) =>
{
    foreach (var time in Enumerable.Range(1, times))
    {
        logIt(what);
    }
};


logIt("Hello, World");
doIt();
logIt("Another thing happened");
doIt();
doItManyTimes("WOW BOB WOW", 100);
