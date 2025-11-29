WriteToFile("file.txt", "Hello world 01!", false);
WriteToFile("file.txt", "Hello world 02!", true);

static void WriteToFile(string path, string content, bool append)
{
    try
    {
        if (append)
        {
            File.AppendAllText(path, content + Environment.NewLine);
            Console.WriteLine("Content appended successfully");
        }
        else
        {
            File.WriteAllText(path, content + Environment.NewLine);
            Console.WriteLine("Content written successfully (previous content replaced)");
        }
    }
    catch (Exception e)
    {
        Console.WriteLine($"Exception: {e.Message}");
    }
}