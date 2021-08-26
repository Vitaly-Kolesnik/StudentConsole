using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentConsole;

namespace StudentsConsoleApp
{
    class Repository
    {
        public Student[] students = new Student[10];

        public void Add(Student student)
        {
            int firstNullElemetArrayStudent = Array.IndexOf(students,null); //метод ищущий первый пустой элемент в массиве и возвращающий его индекс

            if (firstNullElemetArrayStudent == -1)
            {
                Console.WriteLine("База данных заполнена. Удалите далите поле для ввода данных");
            }
            else
            {
                students[firstNullElemetArrayStudent] = student;
            }
        }

        public void Delete(int idForDelet)
        {

            for (int index =0; index<students.Length;index++)
            {
                if (index == (idForDelet-=1)) //сразу отнимаю, что бы положить в одну систему счета
                {
                    students[index] = null; //на случай если пользователь хочет удалить последний id в журнале
                }

                if (index > (idForDelet) && students[index]!=null)
                {
                    students[index - 1] = students[index]; //все записи перезаписываются, что бы сдвинуться на один элемент при удалении. При создании массива туда записываются значения 0. Надо проверить как будет работа этого if 
                    students[index] = null; 
                }
            }

            
        }
    }
}
