using System.ComponentModel.DataAnnotations.Schema;

namespace AnkhMorporkCourseExercise.Web.Models
{
    [Table("Thives")]
    public class Thief : NPC
    {
        public Thief(string name) : base(name, 10m)
        {
        }

        public Thief() : base()
        {
            
        }
       
    }
}
