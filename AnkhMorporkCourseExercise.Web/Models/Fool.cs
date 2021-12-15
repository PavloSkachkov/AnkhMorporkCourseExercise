using System.ComponentModel.DataAnnotations.Schema;

namespace AnkhMorporkCourseExercise.Web.Models
{
    [Table("Fools")]
    public class Fool : NPC
    {
        public Fool(string name, decimal dealMoneyAmount) : base(name, dealMoneyAmount)
        {
        }

        public Fool() : base()
        {
        }
    }
}
