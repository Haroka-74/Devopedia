string path = "file.txt";

try
{
    if (!File.Exists(path))
    {
        File.Create(path).Close();
        Console.WriteLine("File created successfully");
    }
    else
    {
        Console.WriteLine("File already exists");
    }
}
catch (Exception e)
{
    Console.WriteLine($"Exception: {e.Message}");
}