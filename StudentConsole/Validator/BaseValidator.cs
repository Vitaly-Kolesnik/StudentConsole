using System;
using System.Text;

namespace StudentConsole.Validator
{

    public abstract class BaseValidator : IValidator
    {
        protected readonly string[] parameters;
        private StringBuilder sb = new StringBuilder();
        public string ErrorMessage => sb.ToString();
        protected abstract int Count { get; }

        protected BaseValidator(string[] parameters)
        {
            this.parameters = parameters;
        }
        protected bool ValidateParamsCount()//Метод для опеределения заполненности строки после команды (корректность введения)
        {
            int index = 0;

            foreach (string s in parameters)
            {
                if (s != null) index++;
            }
            if (Count == index) return true;
            sb.AppendLine("Ошибка ввода команды");
            return false;
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
        protected bool ValidateString(string name)
        {
            if (name.Length > 50) //Специально разными ифами
            {
                sb.AppendLine("Недопустимая длинна ФИ");
                return false;
            }
            for (int i = 0; name.Length > i; i++)
            {
                if (Char.IsDigit(name, i))
                {
                    sb.AppendLine("ФИ не должны содержать цифр");
                    return false;
                }
            }
            return true;
        }
        protected bool ValidateAge(string age)
        {
            if (uint.TryParse(age, out uint numberAge))
            {
                if (numberAge >= 18 && numberAge <= 99) return true;
                sb.AppendLine("Не допустимое значение возвраста");
                return false;
            }
            sb.AppendLine("Не допустимое значение возвраста");
            return false;
        }
        protected bool ValidateGender(string gender)
        {
            string[] allowableValues = { "М", "Ж", "Мужской", "Женский", "Муж", "Жен" };

            foreach (string s in allowableValues)
            {
                if (gender.ToLower() == s.ToLower())
                {
                    return true;
                }
            }
            sb.AppendLine("Не допустимое значение пола");
            return false;
        }
        public abstract bool Validate();
    }
}