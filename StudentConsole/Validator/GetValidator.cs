namespace StudentConsole.Validator
{
    public class GetValidator : BaseValidator
    {
        protected override int Count => 1;

        public GetValidator(string[] parameters) : base(parameters)
        {
        }
        public override bool Validate() => ValidateParamsCount() && ValidateId(parameters[0]);
    }
}
