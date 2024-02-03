namespace CommandApp;

public abstract class BaseCommand : ICommand
{
    public abstract string Value { get; }
    public abstract string Description { get; }

    public abstract IFeature Feature { get; }

    public void Execute(IApp app)
    {
        Feature.App = app;
        Feature.Run();
    }
}