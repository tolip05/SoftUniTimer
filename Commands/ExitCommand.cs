using SoftUniTimer.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace SoftUniTimer.Commands
{
    public class ExitCommand : ICommand
    {
        public string Execute()
        {
            Console.WriteLine("Buy buy!");
            Environment.Exit(0);
            return null;
        }
    }
}
