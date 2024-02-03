namespace CommandApp;

public abstract class BaseAppInput : IAppInput
{
    public abstract string InputText { get; }

    public string Get()
    {
        Console.SetCursorPosition(0, Console.WindowHeight);
        Console.Write(InputText + " ");

        string? input = Console.ReadLine() ?? throw new Exception("Input can't be null");

        Console.Clear();

        return input;
    }
}