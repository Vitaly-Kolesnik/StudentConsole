using System;
using StudentsConsoleApp;
using StudentsConsoleApp.Commands;

namespace StudentConsole.Commands
{
    class GetComand:Command
    {
        public GetComand(Repository repository, string[] parameters)
            : base(repository, parameters)
        {
        }
        public override string Execute()
        {
            if (checkId.Checking() == -1)
            {
                return "Введенного ID не существует!";
            }
            else
            {
                foreach (Student s in repository.students)
                {
                    if (s != null && s.Id == Int32.Parse(parametrs[1]))
                    {
                        return $"{ s}";
                    }
                }
                return "Ошибка";
            }
        }
    }
}
