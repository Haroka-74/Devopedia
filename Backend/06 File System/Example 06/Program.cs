using Spectre.Console;

string path = "../../../.";

try
{
    if (!Directory.Exists(path))
    {
        Console.WriteLine("Directory does not exist");
        return;
    }

    var table = new Table();

    table.AddColumn(new TableColumn("Name").Centered());
    table.AddColumn(new TableColumn("Size (KB)").Centered());
    table.AddColumn(new TableColumn("Type").Centered());

    foreach (var directory in Directory.GetDirectories(path))
    {
        string name = Path.GetFileName(directory);

        if (name.Length > 27)
            name = string.Concat(name.AsSpan(0, 27), "...");

        table.AddRow(name, "<DIR>", "Folder");
    }

    foreach (var file in Directory.GetFiles(path))
    {
        var fileInfo = new FileInfo(file);

        string name = Path.GetFileNameWithoutExtension(file);

        if (name.Length > 27)
            name = string.Concat(name.AsSpan(0, 27), "...");

        double sizeKB = fileInfo.Length / 1024.0;
        string size = sizeKB < 0.01 ? "< 0.01" : sizeKB.ToString("0.##");
        string extension = fileInfo.Extension.TrimStart('.');

        table.AddRow(name, size, extension);
    }

    AnsiConsole.Write(table);
}
catch (Exception e)
{
    Console.WriteLine($"Exception: {e.Message}");
}