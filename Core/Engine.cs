using SoftUniTimer.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace SoftUniTimer.Core
{
    public class Engine : IEngine
    {
        private readonly Commandinterpreter commandinterpreter;

        public Engine(Commandinterpreter commandinterpreter)
        {
            this.commandinterpreter = commandinterpreter;
        }
        public void Run()
        {
            
            while (true)
            {
                try
                {
                    string[] inputArgs = Console.ReadLine()
                    .ToLower()
                    .Split();
                    var result = this.commandinterpreter
                        .Read(inputArgs);
                    Console.WriteLine(result);
                }
                catch (ArgumentNullException ex)
                {

                    Console.WriteLine(ex.Message);
                }
            }
        }
    }
}
