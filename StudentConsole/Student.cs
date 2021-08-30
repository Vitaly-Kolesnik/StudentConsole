namespace StudentConsole
{
    class Student
    {
        public string NameStudent { get; }
        public string SurNameStudents { get; }
        public string Gender { get; }
        public string Age { get; }
        public int Id { get; set; }

        public Student(string nameStudent, string surNameStudents, string gender, string age)
        {
            this.NameStudent = nameStudent;
            this.SurNameStudents = surNameStudents;
            this.Gender = gender;
            this.Age = age;
        }
        public override string ToString()
        {
            return $"{Id} {NameStudent} {SurNameStudents} {Gender} {Age}";
        }
    }
}
