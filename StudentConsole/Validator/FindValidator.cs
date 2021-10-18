namespace StudentConsole.Validator
{
    public class FindValidator : BaseValidator
    {
        protected override int Count => 1;

        public FindValidator(string[] parameters) : base(parameters)
        {
        }
        public override bool Validate()
        {
            return ValidateParamsCount() && ValidateString(parameters[0]);
        }
    }
}