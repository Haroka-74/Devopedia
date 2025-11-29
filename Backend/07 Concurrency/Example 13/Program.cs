int balance = 1000;
Mutex balanceMutex = new(false);

Thread t1 = new(() => Withdraw(500)) { Name = "Thread 01" };
Thread t2 = new(() => Withdraw(700)) { Name = "Thread 02" };

t1.Start();
t2.Start();

t1.Join();
t2.Join();

Console.WriteLine($"Final balance: ${balance}");

void Withdraw(int amount)
{
    balanceMutex.WaitOne();

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
        balanceMutex.ReleaseMutex();
    }
}