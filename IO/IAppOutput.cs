namespace CommandApp.IO
{
    public interface IAppOutput
    {
        void WriteAndWait(string data);
        void ClearAndWrite(string data);
        void Wait();
        void Write(string data);
        void Clear();
    }
}