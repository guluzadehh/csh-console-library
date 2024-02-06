namespace CommandApp.IO
{
    public abstract class BaseAppInput : IAppInput
    {
        public abstract string InputText { get; }

        public abstract string QuitCommand { get; }

        public string Get()
        {
            Console.SetCursorPosition(0, Console.WindowHeight);
            Console.Write(InputText + " ");

            string input = Console.ReadLine() ?? throw new Exceptions.BaseException("Input can't be null");

            Console.Clear();

            ValidateInput(input);

            return input;
        }

        protected virtual void ValidateInput(string input)
        {
            if (input.Equals(QuitCommand, StringComparison.CurrentCultureIgnoreCase))
            {
                throw new Exceptions.QuitInputRead();
            }
        }
    }
}
