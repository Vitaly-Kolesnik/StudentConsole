using System;
using StudentsConsoleApp;
using StudentsConsoleApp.Commands;

namespace StudentConsole.Commands
{
    class FindComand : Command
    {
        public FindComand(Repository repository, string[] parametrs)
            : base (repository, parametrs)
        {
        }
        public override string Execute()
        {
            var findPosishen = 0;

            foreach (Student s in repository.students)
            {
                if (s != null && s.NameStudent.Contains(parametrs[1]))
                {
                    Console.WriteLine($"{s}\n");
                    findPosishen++;
                    continue;
                }
                else if (s != null && s.SurNameStudents.Contains(parametrs[1]))
                {
                    Console.WriteLine(($"{s}\n"));
                    findPosishen++;
                }
            }
            return (findPosishen == 0 ? "Совпадений не найдено" : $"Количество совпадений: {findPosishen}");
        }
    }
}
