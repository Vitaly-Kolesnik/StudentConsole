using StudentConsole;
namespace StudentsConsoleApp.Commands
{
    abstract class Command
    {
        protected string[] parametrs;
        protected Repository repository;
        protected IValidator validator;

        public Command(Repository repository, string[] parametrs)
        {
            this.parametrs = parametrs;
            this.repository = repository;   
        }
        public Command()
        {
        }
        public string ExecuteWithValidation()
        {
            if (validator != null)
            {
                if (validator.Validate())
                {
                    return Execute();
                }
                return validator.ErrorMessage;
            }
            return Execute();
        }
        public abstract string Execute();
    }
}
