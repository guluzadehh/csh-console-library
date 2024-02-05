namespace CommandApp.Exceptions;

public class QuitInputRead : Exception
{
}

public class CommandNotFound(string value) : Exception
{
    public override string Message { get; } = $"Command `{value}` doesn't exist.";
}