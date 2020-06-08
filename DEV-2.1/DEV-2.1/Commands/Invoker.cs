namespace DEV_2._1.Commands
{
    class Invoker
    {
        private ICommand _command;

        public void SetCommand(ICommand command)
        {
            this._command = command;
        }

        public void ExecuteCommand()
        {
            _command.Execute();
        }
    }
}