string path = "./Directory";

try
{
    if(!Directory.Exists(path))
    {
        Directory.CreateDirectory(path);
        Console.WriteLine("Directory created successfully");
    }
    else
    {
        Console.WriteLine("Directory already exists");
    }
}
catch(Exception e)
{
    Console.WriteLine($"Exception: {e.Message}");
}