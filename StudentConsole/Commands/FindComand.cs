using System;
using System.Diagnostics;
using StudentsConsoleApp;
using StudentsConsoleApp.Commands;

namespace StudentConsole.Commands
{
    class FindComand : Command
    {
        public FindComand(Repository repository, string[] parametrs)
            : base(repository, parametrs)
        {
        }
        public override string Execute()
        {
            var findlist = repository.Find(parametrs[1]);

            string findStudent = string.Empty;

            foreach (Student s in findlist)
            {
                findStudent += $"{s}\n";
            }
            return $"{ findStudent.TrimEnd()}";
        }
    }
}
