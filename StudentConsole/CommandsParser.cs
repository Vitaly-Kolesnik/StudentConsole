using StudentConsole.Commands;
using StudentsConsoleApp.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsConsoleApp
{
    class CommandsParser
    {
        private  Repository repository;

        public CommandsParser(Repository repository)
        {
            this.repository = repository;
        }

        public void Parse(string input)
        {
            var inputArr = input.Split();
            string[] parametrs = new string[5]; //Изменил на 5, так как ADD это по факту первый а дальше 2-имя, 3-фамилия, 4-пол, 5-возраст
            int index = 0;

            foreach (var item in inputArr)
            {
                if (!string.IsNullOrEmpty(item) && index < parametrs.Length)//Метод возвращает true если строка пуста или имеет значение null, соответственно мы должны заходить в цикл и присваивать значение, когда метод возвращает false. Добавил (!)
                {
                    parametrs[index] = item;
                    index++;
                }
            }

            switch ( (parametrs[0]).ToUpper() )
            {
                case "ADD":
                    new AddComand(repository, parametrs).Execute(); //добавил сам метод для обработки ввода и использования метода. До этого возвращало значение 
                    Parse(Console.ReadLine());
                    break;
                case "DELETE":
                    new DeleteComand(repository, parametrs).Execute();
                    Parse(Console.ReadLine());
                    break;
                case "END":
                    new EndProgram().Execute(); //добавил метод для выхода из программ. Программа работает - пока пользователь не выйдет из нее. Обернул в объект, что бы предусмотреть в данном объекте мероприятия по сохранию и доработке проги при закрытии
                    break; //был еще вариант использовать методо exit (), пространства имен Environment

                default:

                    new Command(repository, parametrs).Execute();
                    Parse(Console.ReadLine());
                    break;
            }

            //по зацикливанию работы приложения, был вариант еще в данном месте расположить тернарный оператор или оператор ветвлени, посчитал, что это доп нагрузка по вычислению. Проще было все же в каждом блоке case перевызвать метод и работать пока пользовать не введет END
            //вообще команда END немного другого уровня относительно команд ввода и обработки, которые у нас содержит swich, но поскольку команд такого уровня больше нет (Создать новую базу, Сохранить, Изменить данные в конкретной базе данных) - я допустил возможность распарсить тут. По хорошему надо было бы еще один файл над класс над парсером распологать, что бы обернуть данные команды в объекты в дальнейшем
        }
    }
}