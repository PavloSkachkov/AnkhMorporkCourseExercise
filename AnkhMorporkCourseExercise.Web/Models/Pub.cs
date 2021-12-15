using System.ComponentModel.DataAnnotations.Schema;

namespace AnkhMorporkCourseExercise.Web.Models
{
    [Table("Pubs")]
    public class Pub : NPC
    {
        public Pub(string name) : base(name, 2)
        {
        }
        public Pub() : base()
        {
            
        }
    }
}