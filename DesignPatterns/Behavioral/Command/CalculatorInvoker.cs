using System;
using System.Collections.Generic;

namespace DesignPatterns.Behavioral.Command
{
    public class CalculatorInvoker
    {
        private readonly List<ICommand> _commandsHistory;
        private ICommand _command;

        public CalculatorInvoker()
        {
            _commandsHistory = new List<ICommand>();
        }

        public void SetCommand(ICommand command)
        {
            _command = command;
        }

        public void Execute()
        {
            _command.Execute();
            _commandsHistory.Add(_command);
        }

        public void UndoAllOperations()
        {
            for (var i = _commandsHistory.Count - 1; i >= 0; i--)
            {
                _commandsHistory[i].Undo();
            }

            _commandsHistory.Clear();
        }

        public void DisplayHistory()
        {
            _commandsHistory.ForEach(p => Console.WriteLine(p.ToString()));
        }
    }
}
