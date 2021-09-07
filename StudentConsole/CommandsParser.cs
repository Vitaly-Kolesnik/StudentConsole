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
            Array.Copy(parametrs, 1, newparametrs, 0,newparametrs.Length);
            parametrs = newparametrs;

            switch (command.ToUpper())
            {
                case "ADD":
                    return new AddComand(repository, parametrs);
                case "DELETE":
                    return new DeleteComand(repository, parametrs);
                case "END":
                    return new EndProgram();
                case "EDIT":
                    return new EditComand(repository, parametrs);
                case "LIST":
                    return new ShowListComand(repository, parametrs);
                case "RANDOM":
                    return new RndComand(repository, parametrs);
                case "FIND":
                    return new FindComand(repository, parametrs);
                case "GET":
                    return new GetComand(repository, parametrs);
                default:
                    return new UnknowComand(repository, parametrs);
            }
        }
    }
}
