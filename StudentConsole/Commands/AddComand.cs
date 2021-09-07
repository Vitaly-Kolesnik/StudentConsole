using StudentConsole;
using StudentConsole.Validator;

namespace StudentsConsoleApp.Commands
{
    class AddComand : Command
    {
        public AddComand(Repository repository, string[] parametrs)
            : base(repository, parametrs)
        {
            
        }

        public override string Execute()
        {
            return repository.Add(new Student(parametrs[0], parametrs[1], parametrs[2], int.Parse(parametrs[3]))) > 0 ? "Ok" : "Ошибка";
        }
    }
}
