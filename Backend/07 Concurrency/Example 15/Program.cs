int balance = 1000;

// Binary semaphore (max count 1) to ensure only one thread modifies the balance at a time
SemaphoreSlim balanceSemaphore = new(1, 1);

Thread t1 = new(() => Withdraw(500)) { Name = "Thread 01" };
Thread t2 = new(() => Withdraw(700)) { Name = "Thread 02" };

t1.Start();
t2.Start();

t1.Join();
t2.Join();

Console.WriteLine($"Final balance: ${balance}");

void Withdraw(int amount)
{
    balanceSemaphore.Wait();

    try
    {
        if (balance >= amount)
        {
            Console.WriteLine($"{Thread.CurrentThread.Name} withdrawing ${amount}");
            Thread.Sleep(1000);
            balance -= amount;
            Console.WriteLine($"{Thread.CurrentThread.Name} done. Balance: ${balance}");
        }
        else
        {
            Console.WriteLine($"{Thread.CurrentThread.Name} failed - insufficient funds");
        }
    }
    finally
    {
        balanceSemaphore.Release();
    }
}