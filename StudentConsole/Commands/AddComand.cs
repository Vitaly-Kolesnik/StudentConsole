using StudentConsole;
using StudentConsole.Validator;

namespace StudentsConsoleApp.Commands
{
    class AddComand : Command
    {
        public AddComand(Repository repository, string[] parametrs)
            : base(repository, parametrs)
        {
            validator = new AddValidator(parametrs);
        }

        public override string Execute()
        {
            string nameStudent = (parametrs[0].Substring(0, 1).ToUpper() + parametrs[0].Remove(0, 1).ToLower());
            string surNameStudent = (parametrs[1].Substring(0, 1).ToUpper() + parametrs[1].Remove(0, 1).ToLower());
            return repository.Add(new Student(nameStudent, surNameStudent, int.Parse(parametrs[2]), parametrs[3])) > 0 ? "Ok" : "Ошибка";
        }
    }
}