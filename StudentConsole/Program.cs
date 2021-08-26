using System;
using StudentConsole;

namespace StudentsConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Repository repository = new Repository ();

            var parser = new CommandsParser(repository);

            parser.Parse(Console.ReadLine());

        }
    }
}