using StudentConsole;

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
            return repository.Add(new Student(parametrs[1], parametrs[2], parametrs[3], parametrs[4])) == 1 ? "Ok" : "Ошибка";
        }
    }
}
