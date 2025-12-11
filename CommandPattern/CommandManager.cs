namespace CommandPattern;

public class CommandManager
{
    private readonly Stack<ICommand> _history = new();

    public void Invoke(ICommand command)
    {
        command.Execute();
        _history.Push(command);
    }

    public void Undo()
    {
        if (_history.Count > 0)
        {
            var last = _history.Pop();
            last.Undo();
        }
    }
}