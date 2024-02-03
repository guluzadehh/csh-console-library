namespace CommandApp;

public interface IDispatcher
{
    ICommandCollection Commands { get; }
    void Dispatch(string value, IApp app);
}