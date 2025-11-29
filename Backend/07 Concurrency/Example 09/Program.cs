// ----------------------------------------------------------------------
// Use `await` to pause the async method here without blocking the thread
// ----------------------------------------------------------------------

Console.WriteLine("Main started");

Task<int> task = Task.Run(async () =>
{
    Console.WriteLine("Preparing result...");

    await Task.Delay(2000);

    Console.WriteLine("Result ready");

    return 78;
});

for(int i = 1; i <= 10; i++)
    Console.Write(i == 10 ? $"{i}\n" : $"{i} ");

int result = await task;

Console.WriteLine($"Result: {result}");

Console.WriteLine("Main ended");