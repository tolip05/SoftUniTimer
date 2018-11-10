using SoftUniTimer.Contracts;
using SoftUniTimer.Exstenshions;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace SoftUniTimer.Commands
{
    public class RestartCommand : ICommand
    {
        private readonly string[] inputArgs;

        public RestartCommand(string[]inputArgs)
        {
            this.inputArgs = inputArgs;
        }

        public string Execute()
        {
            if (inputArgs.Length < 1 || string.IsNullOrEmpty(inputArgs[0]))
            {
                throw new ArgumentNullException("Parameters count mismatch!");
            }
            int minutes = int.Parse(inputArgs[0]);
            int seconds = minutes.ToSeconds();
            Process.Start("shutdown", $"/r /t {seconds}");
            return $"Your windows will be restart after {minutes} minutes";

        }
    }
}
