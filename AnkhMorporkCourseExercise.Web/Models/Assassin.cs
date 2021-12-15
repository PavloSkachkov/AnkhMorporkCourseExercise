using System.ComponentModel.DataAnnotations.Schema;

namespace AnkhMorporkCourseExercise.Web.Models
{
    [Table("Assassins")]
    public class Assassin : NPC
    {
        public decimal MinReward { get; set; }
        public decimal MaxReward { get; set; }
        public bool IsOccupied { get; set; }

        public Assassin(string name, decimal minReward, decimal maxReward) : base(name, minReward)
        {
            MinReward = minReward;
            MaxReward = maxReward;
            IsOccupied = false;
        }

        public Assassin() : base()
        {
            
        }
        
    }
}
