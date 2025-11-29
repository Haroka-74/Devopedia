// -------------------------------------------------------------------------------
// Use TPL to run multiple tasks and call `WaitAll()` to wait for their completion
// -------------------------------------------------------------------------------

Console.WriteLine("Main started");

Task t1 = Task.Run(() => Run("Timer 01"));
Task t2 = Task.Run(() => Run("Timer 02"));

Task.WaitAll(t1, t2);

Task t3 = Task.Run(() => Run("Timer 03"));
Task t4 = Task.Run(() => Run("Timer 04"));
Task t5 = Task.Run(() => Run("Timer 05"));

Task.WaitAll(t3, t4, t5);

Console.WriteLine("Main ended");

static void Run(string name)
{
    var t = Thread.CurrentThread;

    for (int i = 1; i <= 5; i++)
    {
        Console.WriteLine($"{name}: {i}s, thread: {t.ManagedThreadId}, pool: {t.IsThreadPoolThread}");
        Thread.Sleep(1000);
    }

    Console.WriteLine($"{name} completed");
}