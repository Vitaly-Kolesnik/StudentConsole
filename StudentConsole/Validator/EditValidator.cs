namespace StudentConsole.Validator
{
    public class EditValidator : BaseValidator
    {
        private const int countParametr = 5;

        public EditValidator(string[] parameters) : base(parameters)
        {
        }
        public override bool Validate()
        {
            return ValidateParamsCount(countParametr, parameters) && ValidateId(parameters[0]) & ValidateString(parameters[1]) & ValidateString(parameters[2]) & ValidateAge(parameters[3]) & ValidateGender(parameters[4]);
        }
    }
}
