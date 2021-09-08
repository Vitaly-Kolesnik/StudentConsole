using System;
using StudentConsole.Commands;
using StudentsConsoleApp.Commands;

namespace StudentsConsoleApp
{
    class CommandsParser
    {
        private readonly Repository repository;

        public CommandsParser(Repository repository)
        {
            this.repository = repository;
        }

        public Command Parse(string input)
        {
            var inputArr = input.Split();
            string[] parametrs = new string[6];
            int index = 0;

            foreach (string item in inputArr)
            {
                if (!string.IsNullOrEmpty(item) && index < parametrs.Length)
                {
                    parametrs[index] = item;
                    index++;
                }
            }
            var command = parametrs[0];
            string[] newparametrs = new string[5];
            Array.Copy(parametrs, 1, newparametrs, 0, newparametrs.Length);
            parametrs = newparametrs;

            switch (command.ToUpper(), repository != null) //Пока база пуста сработать может только команда add
            {
                case ("ADD", true):
                case ("ADD", false):
                    return new AddComand(repository, parametrs);
                case ("DELETE", true):
                    return new DeleteComand(repository, parametrs);
                case ("END", true):
                    return new EndProgram();
                case ("EDIT", true):
                    return new EditComand(repository, parametrs);
                case ("LIST", true):
                    return new ShowListComand(repository, parametrs);
                case ("RANDOM", true):
                    return new RndComand(repository, parametrs);
                case ("FIND", true):
                    return new FindComand(repository, parametrs);
                case ("GET", true):
                    return new GetComand(repository, parametrs);
                default:
                    return new UnknowComand(repository, parametrs);
            }
        }
    }
}
