using System;

namespace StudentsConsoleApp
{
    class Program
    {
        static void Main()
        {
            var repository = new Repository();
            string result;
            do
            {
                string input = Console.ReadLine();
                var parser = new CommandsParser(repository);
                var commandUser = parser.Parse(input); //Записываем переменную типа объекта
                result = commandUser.ExecuteWithValidation(); //Вызываем метод в базовом методе (команды), который или возвращет ошибку, или запускает метод типа объекта, который сохранен в commanduser
                Console.WriteLine(result);
            }
            while (result != "The end!");
        }
    }
}