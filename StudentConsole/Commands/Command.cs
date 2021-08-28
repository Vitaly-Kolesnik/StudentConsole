using StudentConsole;

namespace StudentsConsoleApp.Commands
{
    class Command
    {
        protected string[] parametrs;
        protected Repository repository;
        protected CheckID checkId;
        public Command(Repository repository, string[] parametrs)
        {
            this.parametrs = parametrs;
            this.repository = repository;
            this.checkId = new CheckID(repository, parametrs);
        }
        public Command()
        {
        }
        public virtual string Execute()
        { 
            return "Ничего не вышло";
        }
    }
}
