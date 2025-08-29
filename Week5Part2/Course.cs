using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week5Part2
{
    internal class Course
    {
        public int CourseId { get; set; }
        public string Title { get; set; }
        public Instructor Instructor { get; set; }

        public Course(int CourseId, string Title, Instructor instructor)
        {
            this.CourseId = CourseId;
            this.Title = Title;
            Instructor = instructor;
        }

        public string PrintDetails()
        {
            return $"CourseId: {CourseId}, Title: {Title}, Instructor Name: {Instructor.Name} ";
        }
    }
}
