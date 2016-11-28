using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class School
    {
        public int NumberOfStudent { get; set; }
        public int NumberOfTeacher { get; set; }
        public bool InSession { get; set; }

        public School()
        {
            this.NumberOfStudent = 0;
            this.NumberOfTeacher = 0;
            this.InSession = true;
        }

        public void TeacherStudentRatio(int NumberOfTeacher, int NumberOfStudent)
        {
            Console.WriteLine($"{NumberOfTeacher} : {NumberOfStudent}");
        }
    }
}
