namespace CommandPattern;

public class DeleteFileCommand : ICommand
{
    private readonly string _path;
    private string? _backupContent;

    public DeleteFileCommand(string path)
    {
        _path = path;
    }

    public void Execute()
    {
        if (File.Exists(_path))
        {
            _backupContent = File.ReadAllText(_path);
            File.Delete(_path);
            Console.WriteLine($"File deleted: {_path}");
        }
    }

    public void Undo()
    {
        if (!File.Exists(_path) && _backupContent != null)
        {
            File.WriteAllText(_path, _backupContent);
            Console.WriteLine($"Undo: File restored: {_path}");
        }
    }
}
