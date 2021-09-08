namespace StudentConsole.Validator
{
    public class DeleteValidator : BaseValidator
    {
        private const int countParametr = 1;

        public DeleteValidator(string[] parameters) : base(parameters)
        {
        }
        public override bool Validate()
        {
            return ValidateParamsCount(countParametr, parameters) && ValidateId(parameters[0]);
        }
    }
}