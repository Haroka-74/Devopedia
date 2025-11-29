// --------------------------------------------------
// Execute two timers sequentially on the main thread
// --------------------------------------------------

Console.WriteLine("Main started");

Run("Timer 01");
Run("Timer 02");

Console.WriteLine("Main ended");

static void Run(string name)
{
    for (int i = 1; i <= 5; i++)
    {
        Console.WriteLine($"{name}: {i}s, thread: {Environment.CurrentManagedThreadId}");
        Thread.Sleep(1000);
    }

    Console.WriteLine($"{name} completed");
}