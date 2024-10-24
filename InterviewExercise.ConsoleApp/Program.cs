static async Task RunAndWait(Action[] actions)
{
    var tasks = new List<Task>();
    foreach (var act in actions)
        tasks.Add(Task.Run(() => act()));
    await Task.WhenAll([.. tasks]);
}

var actions = new Action[]
{
    () => {
        Thread.Sleep(800);
        Console.WriteLine("Slow function");
    },
    () => {
        Thread.Sleep(100);
        Console.WriteLine("Fast function");
    }
};
// Expected output:
// Fast function
// Slow function
// Returned from the method!
await RunAndWait(actions);
Console.WriteLine("Returned from the method!");