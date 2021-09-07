using System.Text;

namespace StudentConsole.Validator
{
    
    public abstract class BaseValidator : IValidator
    {
        protected readonly string[] parameters;
        private StringBuilder sb = new StringBuilder();
        private const int lineLength = 50;
        public string ErrorMessage => sb.ToString();


        protected BaseValidator(string[] parameters)
        {
            this.parameters = parameters;
        }
        protected bool ValidateId(string id)
        {
            if (uint.TryParse(id, out _))//Изменил тип данных на uint, что бы отсечь отридцательные id
            {
                return true;
            }
            sb.AppendLine("Ошибка номера id");
            return false;
        }
        protected bool ValidateTryCommand(int )//Метод для опеределения заполненности строки после команды (корректность введения)
        {
            if (parametrs[1] != null)
            {
                sb.AppendLine("Ошибка ввода команды (строка имееет )");
                return false;
            }
            return true;
        }
        protected bool ValidateFind(string[] parametrs)
        {
            if (parametrs[0].Length < lineLength)
            {
                return ValidateTryCommand(parametrs);
            }
            return true;
        }

        public abstract bool Validate();
    }
}