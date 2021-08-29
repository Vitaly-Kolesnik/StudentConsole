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
            return repository.Delete(int.Parse(parametrs[1])) == 1 ? "Удалено" : "Ошибка";
        }
    }
}