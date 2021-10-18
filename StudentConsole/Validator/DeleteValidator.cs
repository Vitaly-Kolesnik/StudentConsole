namespace StudentConsole.Validator
{
    public class DeleteValidator : BaseValidator
    {
        protected override int Count => 1;

        public DeleteValidator(string[] parameters) : base(parameters)
        {
        }
        public override bool Validate()
        {
            return ValidateParamsCount() && ValidateId(parameters[0]);
        }
    }
}