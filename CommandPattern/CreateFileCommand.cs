namespace CommandPattern;

public class CreateFileCommand : ICommand
{
    private readonly string _path;

    public CreateFileCommand(string path)
    {
        _path = path;
    }

    public void Execute()
    {
        File.WriteAllText(_path, "Hello World!");
        Console.WriteLine($"File created: {_path}");
    }

    public void Undo()
    {
        if (File.Exists(_path))
        {
            File.Delete(_path);
            Console.WriteLine($"Undo: File deleted: {_path}");
        }
    }
}
