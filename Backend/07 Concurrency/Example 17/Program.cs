// ---------------------------------------------------------------------
// Prevent deadlocks by enforcing a consistent lock order across threads
// ---------------------------------------------------------------------

object lock1 = new();
object lock2 = new();

Thread t1 = new(Run1) { Name = "Thread 01" };
Thread t2 = new(Run2) { Name = "Thread 02" };

t1.Start();
t2.Start();

t1.Join();
t2.Join();

Console.WriteLine("Both threads completed - no deadlock");

void Run1()
{
    lock(lock1)
    {
        Console.WriteLine($"{Thread.CurrentThread.Name} acquired lock1");

        Thread.Sleep(1000);

        Console.WriteLine($"{Thread.CurrentThread.Name} waiting for lock2...");
        lock(lock2)
        {
            Console.WriteLine($"{Thread.CurrentThread.Name} acquired lock2");
            Console.WriteLine($"{Thread.CurrentThread.Name} completed");
        }
    }
}

void Run2()
{
    lock(lock1)
    {
        Console.WriteLine($"{Thread.CurrentThread.Name} acquired lock1");

        Thread.Sleep(1000);

        Console.WriteLine($"{Thread.CurrentThread.Name} waiting for lock2...");
        lock(lock2)
        {
            Console.WriteLine($"{Thread.CurrentThread.Name} acquired lock2");
            Console.WriteLine($"{Thread.CurrentThread.Name} completed");
        }
    }
}