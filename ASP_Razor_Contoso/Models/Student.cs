

namespace ASP_Razor_Contoso.Models
{
    public class Student
    {
            public int StudentID { get; set; }
            public string LastName { get; set; }
            public string FirstName { get; set; }
            public DateTime EnrollmentDate { get; set; }

            public virtual ICollection<Enrollment> Enrollments { get; set; }
        
    
     }
}
