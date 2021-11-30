namespace AnkhMorporkCourseExercise.Models
{
    public class Assassin
    {
        public decimal MinReward { get; private set; }
        public decimal MaxReward { get; private set; }
        public bool IsOccupied { get; set; }

        public Assassin(decimal minReward, decimal maxReward)
        {
            this.MinReward = minReward;
            this.MaxReward = maxReward;
            this.IsOccupied = false;
        }
    }
}
