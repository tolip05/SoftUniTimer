using System;
using System.Collections.Generic;
using System.Text;

namespace SoftUniTimer.Contracts
{
   public interface ICommandInterpreter
    {
        string Read(string[] inputArgs);
    }
}
