using System.ComponentModel.DataAnnotations.Schema;

namespace AnkhMorporkCourseExercise.Web.Models
{
    [Table("Beggars")]
    public class Beggar : NPC
    {
        public Beggar(string name, decimal dealMoneyAmount) : base(name, dealMoneyAmount)
        {
        }

        public Beggar() : base()
        {
            
        }
    }
}
