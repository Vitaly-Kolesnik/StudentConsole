using System;
namespace StudentConsole.Validator
{
    public class ListValidator : BaseValidator
    {
        private const int countParametr = 0;

        public ListValidator(string[] parameters) : base(parameters)
        {
        }
        public override bool Validate() => ValidateParamsCount(countParametr, parameters);
    }
}
