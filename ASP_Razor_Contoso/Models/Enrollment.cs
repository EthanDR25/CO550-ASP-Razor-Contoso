using System.ComponentModel.DataAnnotations;

namespace ASP_Razor_Contoso.Models
{
    public class Enrollment
    {
        public enum Grades
        {
            A, B, C, D, F
        }

            public int EnrollmentID { get; set; }
            public int CourseID { get; set; }
            public int StudentID { get; set; }

            [DisplayFormat(NullDisplayText = "No grade")]

            public Nullable<Grades> Grade { get; set; }

            public virtual Course Course { get; set; }
            public virtual Student Student { get; set; }
        
    }
}

