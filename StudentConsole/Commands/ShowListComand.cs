using StudentsConsoleApp;
using StudentsConsoleApp.Commands;

namespace StudentConsole.Commands
{
    class ShowListComand : Command
    {
        public ShowListComand(Repository repository, string[] parametrs)
            : base(repository, parametrs)
        {
        }

        public override string Execute()
        {
            var list = repository.List();
            string listStudent = string.Empty;

            foreach (Student s in list)
            {
                listStudent += $"{s}\n";
            }

            return $"{ listStudent.TrimEnd()}";
        }
    }
}
