namespace Week5Part2
{
    internal class Program
    {
        static void Main(string[] args)
        {
           StudentManger manger = new StudentManger();

            while (true)
            {
                Console.WriteLine("\n========== Student Management System ==========");
                Console.WriteLine("1. Add Student");
                Console.WriteLine("2. Add Instructor");
                Console.WriteLine("3. Add Course");
                Console.WriteLine("4. Enroll Student in Course");
                Console.WriteLine("5. Show All Students");
                Console.WriteLine("6. Show All Courses");
                Console.WriteLine("7. Show All Instructors");
                Console.WriteLine("8. Find Student by ID or Name");
                Console.WriteLine("9. Find Course by ID or Name");
                Console.WriteLine("10. Check if Student is Enrolled in Specific Course");
                Console.WriteLine("11. Get Instructor Name by Course Title");
                Console.WriteLine("12. Exit");
                Console.Write("Enter choice (from 1 to 12): ");

                string choice = Console.ReadLine();
                Console.WriteLine();

                switch(choice)
                {
                    case "1":
                        Console.WriteLine("Enter Student ID: ");
                        int studentID = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter Student Name: ");
                        string studentName = Console.ReadLine();
                        Console.WriteLine("Enter Age: ");
                        int age = Convert.ToInt32(Console.ReadLine());

                        Student student = new Student(studentID, age ,studentName);

                        if (manger.AddStudent(student))
                        {
                            Console.WriteLine("Student added successfully");
                        }

                        else
                        {
                            Console.WriteLine("Student already exit");
                        }
                        break;
                    case "2":
                        Console.WriteLine("Enter Instructor ID: ");
                        int instructorID = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter Instructor Name: ");
                        string instructorName = Console.ReadLine();
                        Console.WriteLine("Enter Specialization: ");
                        string instructorspecialization = Console.ReadLine();
                        
                        Instructor instructor = new Instructor (instructorID, instructorName, instructorspecialization);


                        if (manger.AddInstructor(instructor))
                        {
                            Console.WriteLine("Instructor added successfully");
                        }

                        else
                        {
                            Console.WriteLine("Instructor already exit");
                        }
                        break;
                    case "3":
                        Console.WriteLine("Enter Course ID: ");
                        int courseID = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter Course Title: ");
                        string courseTitle = Console.ReadLine();
                        Console.WriteLine("Enter Instructor ID: ");
                        int instID = Convert.ToInt32(Console.ReadLine());

                        Instructor inst = manger.FindInstructor(instID);

                        if(inst == null)
                        {

                            Console.WriteLine("Instructor not found");
                            break;
                        }

                        Course course = new Course(courseID, courseTitle, inst);

                        if (manger.AddCourse(course))
                        {
                            Console.WriteLine("Course added successfully");
                        }

                        else
                        {
                            Console.WriteLine("Course already exit");
                        }
                        break;
                    case "4":
                        Console.WriteLine("Enter Student ID: ");
                        int enrollStudentId = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter Course ID");
                        int enrollCourseId = Convert.ToInt32(Console.ReadLine());

                        if (manger.EnrollStudentInCourse(enrollStudentId, enrollCourseId))
                        {
                            Console.WriteLine("Enrollment Successful.");

                        }
                        else
                        {
                            Console.WriteLine("Enrollment failed.");
                        }
                        break;
                    case "5":
                        if(manger.Students.Count == 0)
                        {
                            Console.WriteLine("There is no students ");
                                break;
                        }
                        for (int i = 0; i < manger.Students.Count; i++)
                        {
                            Console.WriteLine(manger.Students[i].PrintDetails());
                        } 
                        break;
                    case "6":
                        if (manger.Courses.Count == 0)
                        {
                            Console.WriteLine("There is no courses ");
                            break;
                        }
                        for (int i = 0; i < manger.Courses.Count; i++)
                        {
                            Console.WriteLine(manger.Courses[i].PrintDetails());
                        }
                        break;
                    case "7":
                        if (manger.Instructors.Count == 0)
                        {
                            Console.WriteLine("There is no Instructors ");
                            break;
                        }
                        for (int i = 0; i < manger.Instructors.Count; i++)
                        {
                            Console.WriteLine(manger.Instructors[i].PrintDetails());
                        }
                        break;
                    case "8":
                        Console.WriteLine("Enter Student by 1.ID or 2.Name Please choice number from 1 to 2: ");
                        int number = Convert.ToInt32(Console.ReadLine());

                        switch (number)
                        {
                            case 1:
                                Console.WriteLine("Enter Student ID");
                                int sid = Convert.ToInt32(Console.ReadLine());
                                Student stu = manger.FindStudent(sid);
                                if(stu != null)
                                {
                                    Console.WriteLine(stu.PrintDetails());
                                }
                                else
                                {
                                    Console.WriteLine("Student not found");
                                }
                                break;
                            case 2:
                                Console.WriteLine("Enter Student Name");
                                string sname = Console.ReadLine();
                                List<Student>listOfStudent = manger.Students;
                                for(int i = 0;i < listOfStudent.Count;i++)
                                {
                                    if(listOfStudent[i].Name.ToLower() ==  sname.ToLower())
                                    {
                                        Console.WriteLine(listOfStudent[i].PrintDetails());
                                    }
                                }
                                break;
                            default:
                                Console.WriteLine("Invalid Input");
                                break;

                        }
                        break;
                    case "9":
                        Console.WriteLine("Enter Course by 1.ID or 2.Name Please choice number from 1 to 2: ");
                        int num = Convert.ToInt32(Console.ReadLine());

                        switch (num)
                        {
                            case 1:
                                Console.WriteLine("Enter Course ID");
                                int cid = Convert.ToInt32(Console.ReadLine());
                                Course ct = manger.FindCourse(cid);
                                if (ct != null)
                                {
                                    Console.WriteLine(ct.PrintDetails());
                                }
                                else
                                {
                                    Console.WriteLine("Course not found");
                                }
                                break;
                            case 2:
                                Console.WriteLine("Enter Course Name");
                                string ctitle = Console.ReadLine();
                                List<Course> listOfCourse = manger.Courses;
                                for (int i = 0; i < listOfCourse.Count; i++)
                                {
                                    if (listOfCourse[i].Title.ToLower() == ctitle.ToLower())
                                    {
                                        Console.WriteLine(listOfCourse[i].PrintDetails());
                                    }
                                }
                                break;
                            default:
                                Console.WriteLine("Invalid Input");
                                break;

                        }
                        break;
                    case "10":
                        Console.WriteLine("Enter Student ID: ");
                        int Checksid = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter Course ID: ");
                        int checkcid = Convert.ToInt32(Console.ReadLine());

                        Student st = manger.FindStudent(Checksid);
                        if (st == null)
                        {
                            Console.WriteLine("Student Not Found");
                            break;
                        }
                        bool enrolled = st.IsEnrolled(checkcid);
                        Console.WriteLine(enrolled? "Student in this course.": "Student is not enrolled");
                        break;

                    case "11":
                        Console.WriteLine("Enter Course Name");
                        string coursetitle = Console.ReadLine();
                        List<Course> courses = manger.Courses;
                        bool flag = false;
                        for (int i = 0; i < courses.Count; i++)
                        {
                            if (courses[i].Title.ToLower() == coursetitle.ToLower())
                            {
                                Console.WriteLine($"Instructor Name: {courses[i].Instructor.Name}");
                                flag = true;
                                break;
                            }
                            if (!flag)
                            {
                                Console.WriteLine("No Course By that name");
                            }
                        }
                        break;
                    case "12":
                        return;
                     
                    default :
                        Console.WriteLine("Invalid Input Please Try agani later :)");
                        break;



                }
            }
        }
    }
}
