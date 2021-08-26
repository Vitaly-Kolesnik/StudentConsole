using System;
namespace StudentConsole
{
    public class Student
    {
        public string NameStudent { get; set; }
        public string SurNameStudents { get; set; }
        public string Gender { get; set; }
        public string Age { get; set; }

        public Student(string nameStudent, string surNameStudents, string gender, string age)
        {
            this.NameStudent = nameStudent;
            this.SurNameStudents = surNameStudents;
            this.Gender = gender;
            this.Age = age;
        }



    }
}
