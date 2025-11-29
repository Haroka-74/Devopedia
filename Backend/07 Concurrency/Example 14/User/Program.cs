using Mutex mutex = new(false, "Global\\SharedMutex", out bool createdNew);

if (!createdNew)
{
    Console.WriteLine("Another process owns this mutex!");
    return;
}

Console.WriteLine("Process 2 acquired mutex. Press Enter to release");
Console.ReadLine();

Console.WriteLine("Mutex released");