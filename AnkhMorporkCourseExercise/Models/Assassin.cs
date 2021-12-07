namespace AnkhMorporkCourseExercise.Models
{
    public class Assassin
    {
        public decimal MinReward { get; }
        public decimal MaxReward { get; }
        public bool IsOccupied { get; set; }

        public Assassin(decimal minReward, decimal maxReward)
        {
            MinReward = minReward;
            MaxReward = maxReward;
            IsOccupied = false;
        }
    }
}
