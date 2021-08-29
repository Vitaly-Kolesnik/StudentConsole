using System;
using StudentsConsoleApp;
using StudentsConsoleApp.Commands;

namespace StudentConsole.Commands
{
    class RndComand : Command
    {
        public RndComand(Repository repository, string[] parametrs)
            : base(repository, parametrs)
        {
        }

        public override string Execute()
        {
            var list = repository.List();

            Random rnd = new Random();

            Student rndStudent = list[rnd.Next(list.Length)];

            while (rndStudent == null)
            {
                rndStudent = list[rnd.Next(list.Length)];
            }
            return $"{ rndStudent}";
        }
    }
}
