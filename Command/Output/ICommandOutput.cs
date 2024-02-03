namespace CommandApp;

public interface ICommandOutput
{
    string Display(ICommand command);
}