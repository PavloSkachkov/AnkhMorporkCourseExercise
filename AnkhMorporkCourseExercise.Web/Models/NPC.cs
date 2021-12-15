using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AnkhMorporkCourseExercise.Web.Models
{
    public class NPC
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Name { get; protected set; }
        public decimal DealMoneyAmount { get; protected set; }
        public NPC (string name, decimal dealMoneyAmount)
        {
            Name = name;
            DealMoneyAmount = dealMoneyAmount;
        }

        public NPC()
        {
            
        }
    }
}
