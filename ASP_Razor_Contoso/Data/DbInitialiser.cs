using ASP_Razor_Contoso.Models;
using static ASP_Razor_Contoso.Models.Enrollment;

namespace ASP_Razor_Contoso.Data
{
    public class DbInitialiser
    {
        public static void Initialize(ApplicationDbContext context)
        {
            // Look for any students.
            if (context.Students.Any())
            {
                AddCourses(context);
                AddStudents(context);
           
                // DB has been seeded
            }
        }

        public static void AddStudents(ApplicationDbContext context)
        {
            var students = new Student[]
            {
                new Student{FirstName="Ethan",LastName="Richards",EnrollmentDate=DateTime.Parse("2019-09-01")},
                new Student{FirstName="Jonathan",LastName="Harris",EnrollmentDate=DateTime.Parse("2017-09-01")},
                new Student{FirstName="Jordan",LastName="Williamson",EnrollmentDate=DateTime.Parse("2018-09-01")},
                new Student{FirstName="Gareth",LastName="Peters",EnrollmentDate=DateTime.Parse("2017-09-01")},
                new Student{FirstName="Daniel",LastName="Sanders",EnrollmentDate=DateTime.Parse("2017-09-01")},
                new Student{FirstName="Peter",LastName="James",EnrollmentDate=DateTime.Parse("2016-09-01")},
                new Student{FirstName="Harry",LastName="Newman",EnrollmentDate=DateTime.Parse("2018-09-01")},
                new Student{FirstName="Nathan",LastName="Johnson",EnrollmentDate=DateTime.Parse("2019-09-01")}
            };

            context.Students.AddRange(students);
            
        }

        public static void AddCourses(ApplicationDbContext context)
        {
            var courses = new Course[]
            {
                new Course{CourseID=1050,Title="Data Science Bsc",Credits=3},
                new Course{CourseID=4022,Title="Computer Science Bsc",Credits=3},
                new Course{CourseID=4041,Title="Computing Bsc",Credits=3},
                new Course{CourseID=1045,Title="Software Engineering Bsc",Credits=4},
                new Course{CourseID=3141,Title="Computing and Web Development Bsc",Credits=4},
                new Course{CourseID=2021,Title="Artifical Intelligence Bsc",Credits=3},
                new Course{CourseID=2042,Title="Games Development Bsc",Credits=4}
            };

            context.Courses.AddRange(courses);

        }

        public static void AddEnrollments(ApplicationDbContext context)
        {
            var enrollments = new Enrollment[]
            {
                new Enrollment{StudentID=1,CourseID=1050,Grade=Grades.A},
                new Enrollment{StudentID=1,CourseID=4022,Grade=Grades.C},
                new Enrollment{StudentID=1,CourseID=4041,Grade=Grades.B},
                new Enrollment{StudentID=2,CourseID=1045,Grade=Grades.B},
                new Enrollment{StudentID=2,CourseID=3141,Grade=Grades.F},
                new Enrollment{StudentID=2,CourseID=2021,Grade=Grades.F},
                new Enrollment{StudentID=3,CourseID=1050},
                new Enrollment{StudentID=4,CourseID=1050},
                new Enrollment{StudentID=4,CourseID=4022,Grade=Grades.F},
                new Enrollment{StudentID=5,CourseID=4041,Grade=Grades.C},
                new Enrollment{StudentID=6,CourseID=1045},
                new Enrollment{StudentID=7,CourseID=3141,Grade=Grades.A},
            };

            context.Enrollments.AddRange(enrollments);
            

        }
       
        
}
}
