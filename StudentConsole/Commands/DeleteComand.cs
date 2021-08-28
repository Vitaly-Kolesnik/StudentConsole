using System;
using System.Diagnostics;
using StudentsConsoleApp;
using StudentsConsoleApp.Commands;

namespace StudentConsole.Commands
{
    class DeleteComand : Command
    {
        public DeleteComand(Repository repository, string[] parametrs)
            : base(repository, parametrs)
        {
        }
        public override string Execute()
        {
            if (checkId.Checking()== -1)
            {
                return "Введенного ID не существует!";
            }
            else
            {
                repository.Delete(int.Parse(parametrs[1]));

                return "Удалено";
            }
        }
    }
}