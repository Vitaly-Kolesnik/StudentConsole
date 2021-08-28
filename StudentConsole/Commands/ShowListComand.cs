using System;
using StudentsConsoleApp;
using StudentsConsoleApp.Commands;

namespace StudentConsole.Commands
{
    class ShowListComand : Command
    {
        public ShowListComand(Repository repository, string[] parametrs)
            : base(repository,parametrs)
        {
        }

        public override string Execute()
        {
            var size = 0;
            foreach (Student s in repository.students)
            {
                if (s != null )
                {
                    Console.WriteLine($"{s}\n");
                    size++;
                }
            }
            return $"Количество элементов: {size}";
        }
    }
}
