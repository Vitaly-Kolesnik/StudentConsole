using System;
using StudentsConsoleApp;
using StudentsConsoleApp.Commands;

namespace StudentConsole.Commands
{
    class RndComand : Command
    {
        public RndComand(Repository repository, string [] parametrs)
            : base (repository,parametrs)
        {
        }

        public override string Execute()
        {
            Random rnd = new Random();
            Student result = null; // для возвращения результат заданного типа

            while (result == null)
            {
                var randomNumber = rnd.Next(repository.students.Length); //Повышаю читабельность кода

                if ( repository.students[randomNumber] != null)
                {
                    result = repository.students[randomNumber];
                }
            }
            return $"{result}";
        }
    }
}
