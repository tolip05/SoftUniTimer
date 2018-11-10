using SoftUniTimer.Contracts;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace SoftUniTimer.Commands
{
    public class AbortCommand : ICommand
    {
        public string Execute()
        {
            Process.Start("shutdown", $"/a");
            return $"Command abort succesfully.";
        }
    }
}
