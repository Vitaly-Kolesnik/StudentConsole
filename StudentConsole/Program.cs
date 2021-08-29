using System;

namespace StudentsConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var repository = new Repository();
            string result;

            do
            {
                string input = Console.ReadLine();
                var parser = new CommandsParser(repository);
                var commandUser = parser.Parse(input);
                result = commandUser.Execute();
                Console.WriteLine(result);
            }
            while (result != "The end!");
        }
    }
}