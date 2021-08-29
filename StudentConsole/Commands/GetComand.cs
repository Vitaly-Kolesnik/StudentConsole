using System;
using StudentsConsoleApp;
using StudentsConsoleApp.Commands;

namespace StudentConsole.Commands
{
    class GetComand : Command
    {
        public GetComand(Repository repository, string[] parameters)
            : base(repository, parameters)
        {
        }

        public override string Execute()
        {
            if (repository.Get(int.Parse(parametrs[1])) != null)
            {
                return $"{repository.Get(int.Parse(parametrs[1]))}";
            }
            return "Ошибка";
        }
    }
}
