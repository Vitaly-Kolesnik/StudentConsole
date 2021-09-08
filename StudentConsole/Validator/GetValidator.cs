namespace StudentConsole.Validator
{
    public class GetValidator : BaseValidator
    {
        private const int countParametr = 1;

        public GetValidator(string[] parameters) : base(parameters)
        {
        }
        public override bool Validate() => ValidateParamsCount(countParametr, parameters) && ValidateId(parameters[0]);
    }
}
