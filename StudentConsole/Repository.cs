using System;
using StudentConsole;

namespace StudentsConsoleApp
{
    class Repository
    {
        private readonly Student[] students = new Student[10];

        private int studentID = 0;

        public int Add(Student student)
        {
            for (int index = 0; index < this.students.Length; index++)
            {
                if (this.students[index] == null)
                {
                    this.students[index] = student;
                    this.students[index].Id = studentID += 1;
                    return 1;
                }
            }
            return -1;
        }

        internal object Find(object p)
        {
            throw new NotImplementedException();
        }

        public int Delete(int numberId)
        {
            for (int index = 0; index < students.Length; index++)
            {
                if (students[index].Id == numberId)
                {
                    students[index] = null;
                    return 1;
                }
            }
            return -1;
        }

        public Student Get(int numberId)
        {
            Student std = null;

            foreach (Student s in students)
            {
                if (s != null && s.Id == numberId)
                {
                    std = s;
                }
            }
            return std;
        }

        public int Edit(Student student, int id)
        {
            for (int index = 0; index < students.Length; index++)
            {
                if (students[index] != null && students[index].Id == id)
                {
                    students[index] = student;
                    return 1;
                }
            }
            return -1;
        }

        public Student[] List()
        {
            return students;
        }

        public Student[] Find(string parametr)
        {
            int sizeFindArray = 0;

            foreach (Student s in students)
            {
                if (s != null && s.SurNameStudents.Contains(parametr))
                {
                    sizeFindArray += 1;
                    break;
                }

                if (s != null && s.NameStudent.Contains(parametr))
                {
                    sizeFindArray += 1;
                }
            }
            Student[] findArray = new Student[sizeFindArray];

            int index = 0;

            foreach (Student s in students)
            {
                if (s != null && s.SurNameStudents.Contains(parametr))
                {
                    findArray[index] = s;
                    index++;
                    break;
                }

                if (s != null && s.NameStudent.Contains(parametr))
                {
                    findArray[index] = s;
                    index++;
                }
            }
            return findArray;
        }
    }
}
