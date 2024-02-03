
namespace CommandApp;

public class DefaultDispatcher(ICommandCollection commands) : BaseDispatcher(commands)
{
    protected override Type ExceptionType { get; } = typeof(CommandNotFound);
}