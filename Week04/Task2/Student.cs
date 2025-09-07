using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week5Part2
{
    internal class Student
    {
        public int StudentId { get; set; }
        public int Age { get; set; }
        public string Name { get; set; }

        List<Course> Courses = new();

        public Student(int  studentId, int Age, string Name)
        {
            StudentId = studentId;
            this.Age = Age;
            this.Name = Name;
        }

        public bool Enroll(Course course)
        {
            for(int i = 0; i < Courses.Count; i++)
            {
                if(course.CourseId == Courses[i].CourseId)
                {
                    return false;
                }
            }
            Courses.Add(course);
            return true;
        }

        public string PrintDetails()
        {
            return $"StudentId: {StudentId}, Name: {Name}, Age: {Age} ";
        }

        public bool IsEnrolled(int courseId)
        {
            for(int i = 0;i < Courses.Count; i++)
            {
                if(courseId == Courses[i].CourseId) { return true; }
                
            }
            return false;
        }

    }
}
