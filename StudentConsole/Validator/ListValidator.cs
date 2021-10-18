using System;
namespace StudentConsole.Validator
{
    public class ListValidator : BaseValidator
    {
        protected override int Count => 0;

        public ListValidator(string[] parameters) : base(parameters)
        {
        }
        public override bool Validate() => ValidateParamsCount();
    }
}