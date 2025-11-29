using Mutex mutex = new(false, "Global\\SharedMutex");

Console.WriteLine("Process 1 acquired mutex. Press Enter to release");
Console.ReadLine();

Console.WriteLine("Mutex released");