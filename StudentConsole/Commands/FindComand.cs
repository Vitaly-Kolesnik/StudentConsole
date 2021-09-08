using System.Text;
using StudentConsole.Validator;
using StudentsConsoleApp;
using StudentsConsoleApp.Commands;

namespace StudentConsole.Commands
{
    class FindComand : Command
    {
        public FindComand(Repository repository, string[] parametrs)
            : base(repository, parametrs)
        {
            validator = new FindValidator(parametrs);
        }
        public override string Execute()
        {
            Student[] findlist = repository.Find(parametrs[0]);

            StringBuilder result = new StringBuilder();

            foreach (Student s in findlist)
            {
                result.AppendLine($"{ s}");
            }
            return result.ToString();
        }
    }
}