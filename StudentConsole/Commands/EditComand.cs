using System;
using StudentConsole.Validator;
using StudentsConsoleApp;
using StudentsConsoleApp.Commands;

namespace StudentConsole.Commands
{
    class EditComand : Command
    {
        public EditComand(Repository repository, string[] parametrs)
            : base(repository, parametrs)
        {
            validator = new EditValidator(parametrs);
        }
        public override string Execute()
        {
            string nameStudent = (parametrs[0].Substring(0, 1).ToUpper() + parametrs[0].Remove(0, 1).ToLower());
            string surNameStudent = (parametrs[1].Substring(0, 1).ToUpper() + parametrs[1].Remove(0, 1).ToLower());
            return repository.Edit(new Student(Int32.Parse(parametrs[0]),nameStudent, surNameStudent, int.Parse(parametrs[3]), parametrs[4])) == 1 ? "Изменено" : "Ошибка";
        }
    }
}