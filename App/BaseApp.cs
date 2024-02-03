namespace CommandApp;

public abstract class BaseApp : IApp
{
    public bool Running { get; set; } = true;
    public abstract ICommandCollection Commands { get; }
    public abstract IDispatcher Dispatcher { get; }
    public abstract ICommandOutput CommandOutput { get; }
    public abstract IAppInput Input { get; }
    public abstract IAppOutput Output { get; }
    public abstract Dictionary<string, object> Context { get; }

    public void Start()
    {
        while (Running)
        {
            Output.Clear();

            DisplayCommands();

            string input = Input.Get();

            try
            {
                Dispatcher.Dispatch(input, this);
            }
            catch (CommandNotFound exc)
            {
                Output.WriteAndWait(exc.Message);
            }
        }
    }

    protected virtual void DisplayCommands()
    {
        foreach (ICommand command in Commands)
        {
            Output.Write(CommandOutput.Display(command));
        }
    }
}
