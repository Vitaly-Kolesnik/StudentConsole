namespace StudentConsole.Validator
{
    public class GetValidator : BaseValidator
    {
        public GetValidator(string[] parameters) : base(parameters)
        {
        }
        public override bool Validate() => ValidateId(parameters);
    }
}
