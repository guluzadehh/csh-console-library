namespace CommandApp;

public interface IApp
{
    bool Running { get; set; }
    ICommandCollection Commands { get; }
    IDispatcher Dispatcher { get; }
    ICommandOutput CommandOutput { get; }
    IAppOutput Output { get; }
    IAppInput Input { get; }
    Dictionary<string, object> Context { get; }
    void Start();
}