using StudentConsole;

namespace StudentsConsoleApp
{
    class Repository
    {
        public Student[] students = new Student[10];

        private int studentID = 0;

        public int Add(Student student)
        {
            int emptyNumber = -1;
            for (int index =0; index<this.students.Length; index++)
            {
                if (this.students[index] == null)
                {
                    this.students[index] = student;
                    this.students[index].Id = studentID+=1;
                    return (emptyNumber += 1);
                }
            }
            return emptyNumber;
        }

        public void Delete(int numberId) //Нет необходимости возвращать результат, мы точно знаешь, что такой ID есть
        {
            for (int index = 0; index < students.Length; index++ )
            {
                if (students[index].Id == numberId)
                {
                    students[index] = null;
                    return;
                }
            }
        }

        public Student Get (int numberId)
        {
            Student variable = null;

            foreach (Student s in students)
            {
                if (s != null && s.Id == numberId)
                {
                    variable = s;
                }
            }
            return variable;
        }

        public void Edit (Student student, int id)
        {
            for (int index = 0; index<students.Length; index++)
            {
                 if (students[index] !=null && students[index].Id==id)
                 {
                    students[index] = student;
                 }
            }
        }
    }
}
