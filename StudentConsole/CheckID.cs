using System;
using StudentsConsoleApp;

namespace StudentConsole
{
    class CheckID
    {
        private readonly Repository repository;
        private readonly string [] parametrs;

        public CheckID(Repository repository, string [] parametrs)
        {
            this.parametrs = parametrs;
            this.repository = repository;
        }

        public int Checking()
        {
            for (int index = 0; repository.students.Length>index; index++)
            {
                if (repository.students[index] != null && repository.students[index].Id == Convert.ToInt32(parametrs[1]))
                {
                    return index;
                }
            }
            return -1;
        }
    }
}
