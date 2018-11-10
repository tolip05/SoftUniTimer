using SoftUniTimer.Contracts;
using SoftUniTimer.Exstenshions;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace SoftUniTimer.Commands
{
    public class HibernateCommand : ICommand
    {
        private string[] inputArgs;

        public HibernateCommand(string[] inputArgs)
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
            Process.Start("shutdown", $"/h /t {seconds}");

            return $"Windows will be hibernate after {minutes} minutes";
        }
    }
}

