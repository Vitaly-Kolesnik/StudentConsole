namespace StudentConsole.Validator
{
    public class AddValidator : BaseValidator
    {
        private const int countParametr = 4;

        public AddValidator(string[] parameters) : base(parameters)
        {
        }
        public override bool Validate()
        {
            return ValidateParamsCount(countParametr, parameters) && ValidateString(parameters[0]) & ValidateString(parameters[1]) & ValidateAge(parameters[2]) & ValidateGender(parameters[3]);
        }
    }
}