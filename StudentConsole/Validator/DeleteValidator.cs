namespace StudentConsole.Validator
{ 
    public class DeleteValidator : BaseValidator
    {
        const int countParametr = 1;

        public DeleteValidator(string[] parameters) : base(parameters)
        {
        }
        public override bool Validate()
        {
            return ValidateId(parameters[0]) && ;
        } 
    }
}

