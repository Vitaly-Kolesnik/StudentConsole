using StudentConsole.Validator;
using StudentsConsoleApp;
using StudentsConsoleApp.Commands;

namespace StudentConsole.Commands
{
    class DeleteComand : Command
    {
        public DeleteComand(Repository repository, string[] parametrs)
            : base(repository, parametrs) => validator = new DeleteValidator(parametrs);

        public override string Execute() => repository.Delete(int.Parse(parametrs[0])) == 1 ? "Удалено" : "Ошибка";
    }
}