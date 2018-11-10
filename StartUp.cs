using SoftUniTimer.Contracts;
using SoftUniTimer.Core;
using System;

namespace SoftUniTimer
{
   public class StartUp
    {
       public static void Main(string[] args)
        {
            // shotDown 30
            // restart 30
            // hibernate 30
            // abort
            // exit
            // Engine => run()
            // CommandParset/CommandInterpreter
            // CommandPatern

            Commandinterpreter commandinterpreter = new Commandinterpreter();
            IEngine engine = new Engine(commandinterpreter);
            engine.Run();


        }
    }
}
