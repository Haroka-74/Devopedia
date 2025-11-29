// --------------------------------------------------
// Start two foreground threads that run concurrently
// --------------------------------------------------

Console.WriteLine("Main started");

Thread t1 = new(() => Run("Timer 01")) { Name = "01" };
Thread t2 = new(() => Run("Timer 02")) { Name = "02" };

t1.Start();
t2.Start();

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