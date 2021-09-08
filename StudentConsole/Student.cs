namespace StudentConsole
{
    class Student
    {
        public string NameStudent { get; }
        public string SurNameStudents { get; }
        public string Gender { get; }
        public int Age { get; }
        public int Id { get; set; }

        public Student(string nameStudent, string surNameStudents,  int age, string gender)
        {
            this.NameStudent = nameStudent;
            this.SurNameStudents = surNameStudents;
            this.Gender = gender;
            this.Age = age;
        }
        public Student(int id, string nameStudent, string surNameStudents, int age, string gender) :
            this (nameStudent, surNameStudents, age, gender)
        {
            Id = id;
        }
        public override string ToString()
        {
            return $"{Id} {NameStudent} {SurNameStudents} {Gender} {Age}";
        }
    }
}
