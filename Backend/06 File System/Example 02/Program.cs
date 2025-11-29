string path = "./Directory";

try
{
    if(Directory.Exists(path))
    {
        Directory.Delete(path, true);
        Console.WriteLine("Directory deleted successfully");
    }
    else
    {
        Console.WriteLine("Directory does not exist");
    }
}
catch(Exception e)
{
    Console.WriteLine($"Exception: {e.Message}");
}