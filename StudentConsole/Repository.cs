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
                    return this.students[index].Id = studentID += 1;
                }
            }
            return -1;
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
            foreach (Student s in students)
            {
                if (s != null && s.Id == numberId)
                {
                    return s;
                }
            }
            return null;
        }
        public int Edit(Student student)
        {
            for (int index = 0; index < students.Length; index++)
            {
                if (students[index] != null && students[index].Id == student.Id)
                {
                    students[index] = student;
                    return 1;
                }
            }
            return -1;
        }
        public Student[] List()
        {
            Student[] newStudents = new Student[students.Length];

            int sizeArray = 0;

            foreach (Student s in students)
            {
                if (s != null)
                {
                    newStudents[sizeArray] = s;
                    sizeArray += 1;
                }
            }
            Array.Resize(ref newStudents, sizeArray+1);
            return newStudents;
        }
        public Student[] Find(string parametr)
        {
            Student[] newStudents = new Student[students.Length];

            int sizeFindArray = 0;

            foreach (Student s in students)
            {
                if (s != null && s.SurNameStudents.Contains(parametr) || s.NameStudent.Contains(parametr))
                {
                    newStudents[sizeFindArray] = s;
                    sizeFindArray += 1;
                }
            }
            Array.Resize(ref newStudents, sizeFindArray + 1);
            return newStudents;
        }
    }
}