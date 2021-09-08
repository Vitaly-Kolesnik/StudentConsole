namespace StudentConsole.Validator
{
    public class FindValidator : BaseValidator
    {
        private const int countParametr = 1;

        public FindValidator(string[] parameters) : base(parameters)
        {
        }
        public override bool Validate()
        {
            return ValidateParamsCount(countParametr, parameters) && ValidateString(parameters[0]);
        }
    }
}