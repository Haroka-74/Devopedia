// ----------------------------------------------------
// Use `ThreadPool` to efficiently reuse worker threads
// ----------------------------------------------------

Console.WriteLine("Main started");

ThreadPool.QueueUserWorkItem(_ => Run("Timer 01"));
ThreadPool.QueueUserWorkItem(_ => Run("Timer 02"));

Thread.Sleep(6000);

ThreadPool.QueueUserWorkItem(_ => Run("Timer 03"));
ThreadPool.QueueUserWorkItem(_ => Run("Timer 04"));
ThreadPool.QueueUserWorkItem(_ => Run("Timer 05"));

Thread.Sleep(6000);

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