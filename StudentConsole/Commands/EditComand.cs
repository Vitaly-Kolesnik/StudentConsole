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
            if (checkId.Checking() == -1)
            {
                return "Введенного ID не существует!";
            }
            else
            {
                repository.Edit( new Student(parametrs[2], parametrs[3], parametrs[4], parametrs[5]), Int32.Parse(parametrs[1]) );

                return "Изменено";
            }
        }
    }
}
