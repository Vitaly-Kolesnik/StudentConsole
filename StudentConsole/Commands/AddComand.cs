using StudentConsole;

namespace StudentsConsoleApp.Commands
{
    class AddComand : Command
    {
        public AddComand(Repository repository, string[] parametrs)
            : base(repository, parametrs)
        {
        }
        public override string Execute()
        {
            int answerNumber = repository.Add(new Student(parametrs[1], parametrs[2], parametrs[3], parametrs[4]));
            if (answerNumber > -1)
            {
                return "Ok";
            }
            else return "Нету свободных мест";
        }
    }
}
