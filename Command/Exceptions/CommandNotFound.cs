namespace CommandApp;

public class CommandNotFound(string value) : Exception
{
    public override string Message { get; } = $"Command `{value}` doesn't exist.";
}