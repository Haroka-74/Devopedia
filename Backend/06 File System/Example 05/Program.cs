string path = "file.txt";

try
{
    if (!File.Exists(path))
    {
        Console.WriteLine("File does not exist");
        return;
    }

    string content = File.ReadAllText(path);

    Console.WriteLine(new string('-', 50));
    Console.WriteLine(content);
    Console.WriteLine(new string('-', 50));
}
catch (Exception e)
{
    Console.WriteLine($"Exception: {e.Message}");
}