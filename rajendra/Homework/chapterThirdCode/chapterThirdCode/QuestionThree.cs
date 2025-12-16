using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chapterThirdCode
{
    class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

    class Grade
    {
        public int StudentId { get; set; }
        public string Course { get; set; }
        public string GradeLetter { get; set; }
    }
    internal class QuestionThree
    {
        public void three()
        {
            List<Student> students = new List<Student>
        {
            new Student { Id = 1, Name = "Alice" },
            new Student { Id = 2, Name = "Bob" }
        };

            List<Grade> grades = new List<Grade>
        {
            new Grade { StudentId = 1, Course = "Math", GradeLetter = "A" },
            new Grade { StudentId = 2, Course = "Science", GradeLetter = "B" }
        };


            var studentGrades = from s in students
                                join g in grades
                                on s.Id equals g.StudentId
                                select new
                                {
                                    s.Name,
                                    g.Course,
                                    g.GradeLetter
                                };

            Console.WriteLine("Student Grades:");
            foreach (var sg in studentGrades)
            {
                Console.WriteLine($"Name: {sg.Name}, Course: {sg.Course}, Grade: {sg.GradeLetter}");
            }
        }
    }
}
