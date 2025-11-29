// -----------------------------------------------------------------------------
// Use `GetAwaiter()` to get a task's result without blocking the calling thread
// -----------------------------------------------------------------------------

Console.WriteLine("Main started");

Task<int> task = Task.Run(() =>
{
    Console.WriteLine("Preparing result...");

    Thread.Sleep(2000);

    Console.WriteLine("Result ready");

    return 78;
});

for(int i = 1; i <= 10; i++)
    Console.Write(i == 10 ? $"{i}\n" : $"{i} ");

var awaiter = task.GetAwaiter();

awaiter.OnCompleted(() => Console.WriteLine($"Result: {awaiter.GetResult()}"));

Console.WriteLine("Main ended");

Console.ReadLine();