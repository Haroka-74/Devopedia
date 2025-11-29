await foreach(var line in ReadLogFileAsync("log.txt"))
    Console.WriteLine(line);

static async IAsyncEnumerable<string> ReadLogFileAsync(string path)
{
    using var fs = new FileStream(path, FileMode.Open, FileAccess.Read);
    using var r = new StreamReader(fs);

    while (!r.EndOfStream)
    {
        var line = await r.ReadLineAsync();

        if (line != null)
            yield return line;
    }
}