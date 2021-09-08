namespace StudentConsole.Validator
{
    public class RndValidator : BaseValidator
    {
        private const int countParametr = 0;

        public RndValidator(string[] parameters) : base(parameters)
        {
        }
        public override bool Validate() => ValidateParamsCount(countParametr, parameters);
    }
}