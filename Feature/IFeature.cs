namespace CommandApp;

public interface IFeature
{
    IApp App { get; set; }
    void Run();
}