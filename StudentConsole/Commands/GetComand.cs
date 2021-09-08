using StudentConsole.Validator;
using StudentsConsoleApp;
using StudentsConsoleApp.Commands;

namespace StudentConsole.Commands
{
    class GetComand : Command
    {
        public GetComand(Repository repository, string[] parameters)
            : base(repository, parameters) => validator = new DeleteValidator(parameters);

        public override string Execute() => repository.Get(int.Parse(parametrs[0])) != null ? $"{repository.Get(int.Parse(parametrs[0]))}":"Такой id отсутствует";
    }
}