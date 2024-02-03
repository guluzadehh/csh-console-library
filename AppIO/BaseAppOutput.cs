namespace CommandApp;

public abstract class BaseAppOutput : IAppOutput
{
    public abstract string WaitText { get; }

    public void ClearAndWrite(string data)
    {
        Console.Clear();
        Write(data);
    }

    public void Wait()
    {
        Write(WaitText);
        Console.ReadLine();
        Console.Clear();
    }

    public void WriteAndWait(string data)
    {
        Write(data);
        Wait();
    }

    public void Write(string data)
    {
        Console.WriteLine(data);
    }

    public void Clear()
    {
        Console.Clear();
    }
}