// ----------------------------------------------------------------
// Use a Task's Result to block the calling thread until completion
// ----------------------------------------------------------------

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

int result = task.Result;

Console.WriteLine($"Result: {result}");

Console.WriteLine("Main ended");