using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week5Part2
{
    internal class StudentManger
    {
        public List<Student> Students { get; } = new();
        public List<Course> Courses { get; } = new();
        public List<Instructor> Instructors { get; } = new();

        public bool AddStudent(Student student)
        {
            for (int i = 0; i < Students.Count; i++)
            {
                if (student.StudentId == Students[i].StudentId)
                {
                    return false;
                }
            }
            Students.Add(student);
            return true;
        }
        public bool AddCourse(Course course)
        {
            for (int i = 0; i < Courses.Count; i++)
            {
                if (course.CourseId == Courses[i].CourseId)
                {
                    return false;
                }
            }
            Courses.Add(course);
            return true;
        }
        public bool AddInstructor(Instructor instructor)
        {
            for (int i = 0; i < Instructors.Count; i++)
            {
                if (instructor.InstructorId == Instructors[i].InstructorId)
                {
                    return false;
                }
            }
            Instructors.Add(instructor);
            return true;
        }


        public Student FindStudent(int studentId)
        {
            //to check if it found 
            bool flag = false;
            //to save index if it found
            int index = 0;
            for(int i = 0; i < Students.Count; i++)
            {
                if (studentId == Students[i].StudentId)
                {
                    return Students[i];
                }
            }
            return null;
        }
        public Course FindCourse(int courseId)
        {
            for(int i = 0; i < Courses.Count; i++)
            {
                if (courseId == Courses[i].CourseId)
                {
                      return Courses[i];
                }
            }
            return null;
        }
        public Instructor FindInstructor(int instructorId)
        {
            for(int i = 0; i < Instructors.Count; i++)
            {
                if (instructorId == Instructors[i].InstructorId)
                {
                   return Instructors[i];
                }
            }
            return null;

        }

        public bool EnrollStudentInCourse(int studentId, int courseId)
        {
            Student student = FindStudent(studentId);
            Course course = FindCourse(courseId);

            if(student == null || course == null)
            {
                return false;
            }
            return student.Enroll(course);

        }


    }
}
