using System;
using StudentsConsoleApp;
using StudentsConsoleApp.Commands;

namespace StudentConsole.Commands
{
    class EditComand : Command
    {
        public EditComand(Repository repository, string[] parametrs)
            : base(repository, parametrs)
        {
        }

        public override string Execute()
        {
            return repository.Edit(new Student(Int32.Parse(parametrs[0]), parametrs[1], parametrs[2], parametrs[3], int.Parse(parametrs[4]))) == 1 ? "Изменено" : "Ошибка";
        }
    }
}
