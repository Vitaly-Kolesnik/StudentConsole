namespace StudentConsole.Validator
{
    public class AddValidator : BaseValidator
    {
        protected override int Count => 4;

        public AddValidator(string[] parameters) : base(parameters)
        {
        }
        public override bool Validate()
        {
            return ValidateParamsCount() && ValidateString(parameters[0]) & ValidateString(parameters[1]) & ValidateAge(parameters[2]) & ValidateGender(parameters[3]);
        }
    }
}