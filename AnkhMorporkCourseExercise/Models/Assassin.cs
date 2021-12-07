namespace AnkhMorporkCourseExercise.Models
{
    public class Assassin : NPC
    {
        public decimal MinReward { get; }
        public decimal MaxReward { get; }
        public bool IsOccupied { get; set; }

        public Assassin(string name, decimal minReward, decimal maxReward) : base(name, minReward)
        {
            MinReward = minReward;
            MaxReward = maxReward;
            IsOccupied = false;
        }
    }
}
