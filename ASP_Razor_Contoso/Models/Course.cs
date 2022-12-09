using System.ComponentModel.DataAnnotations.Schema;

namespace ASP_Razor_Contoso.Models
{
    public class Course
    {
        
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CourseID { get; set; }

        public string CourseCode { get; set; } = string.Empty;
        public string Title { get; set; } = string.Empty;
        public int Credits { get; set; }

        public virtual ICollection<Enrollment> Enrollments { get; set; }
        
    
   }
}
