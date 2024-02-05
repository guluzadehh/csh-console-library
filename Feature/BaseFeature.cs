namespace CommandApp;

public abstract class BaseFeature : IFeature
{
    public IApp App { get; set; }

    protected virtual string QuitCommand { get; } = "quit";

    public abstract void Run();

    protected string GetInput()
    {
        string input = App.Input.Get();

        if (input.Equals(QuitCommand, StringComparison.CurrentCultureIgnoreCase))
        {
            throw new QuitInputRead();
        }

        return input;
    }

    protected void SendResponse(string data)
    {
        App.Output.WriteAndWait(data);
    }
}
