namespace StudentsConsoleApp.Commands
{
    class Command
    {
        protected string[] parametrs;
        protected Repository repository;

        public Command(Repository repository, string[] parametrs)
        {
            this.parametrs = parametrs;
            this.repository = repository;
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
