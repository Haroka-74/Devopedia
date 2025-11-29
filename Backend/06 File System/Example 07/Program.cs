string path = "image.jpg";

try
{
    if (!File.Exists(path))
    {
        Console.WriteLine("Image file does not exist");
        return;
    }

    using var fileStream = new FileStream(path, FileMode.Open, FileAccess.Read);

    byte[] header = new byte[8];
    int bytesRead = fileStream.Read(header, 0, header.Length);

    if (bytesRead < 4)
    {
        Console.WriteLine("File is too small to determine type");
        return;
    }

    // https://en.wikipedia.org/wiki/List_of_file_signatures
    if (header[0] == 0x89 && header[1] == 0x50 && header[2] == 0x4E && header[3] == 0x47)
        Console.WriteLine("Image Type: PNG (Portable Network Graphics)");
    else if (header[0] == 0xFF && header[1] == 0xD8 && header[2] == 0xFF)
        Console.WriteLine("Image Type: JPEG (Joint Photographic Experts Group)");
    else if (header[0] == 0x47 && header[1] == 0x49 && header[2] == 0x46)
        Console.WriteLine("Image Type: GIF (Graphics Interchange Format)");
    else if (header[0] == 0x42 && header[1] == 0x4D)
        Console.WriteLine("Image Type: BMP (Bitmap)");
    else
        Console.WriteLine("Unknown or unsupported image format");
}
catch (Exception e)
{
    Console.WriteLine($"Exception: {e.Message}");
}