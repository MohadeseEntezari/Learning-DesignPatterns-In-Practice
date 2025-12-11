using CommandPattern;

var manager = new CommandManager();

var create = new CreateFileCommand("test.txt");
var delete = new DeleteFileCommand("test.txt");

manager.Invoke(create);
manager.Invoke(delete);

Console.WriteLine("---- Undo Last Action ----");
manager.Undo();      
Console.WriteLine("---- Undo Again ----");
manager.Undo(); 
