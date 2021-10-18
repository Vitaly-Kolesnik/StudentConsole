namespace StudentConsole.Validator
{
    public class RndValidator : BaseValidator
    {
        protected override int Count => 0;

        public RndValidator(string[] parameters) : base(parameters)
        {
        }
        public override bool Validate() => ValidateParamsCount();
    }
}