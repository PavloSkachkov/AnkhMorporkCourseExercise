namespace AnkhMorporkCourseExercise.Web.Dto
{
    public class AssassinDto 
    {
        public string Name { get; set; }
        public decimal DealMoneyAmount { get; set; }
        public decimal MinReward { get; set; }
        public decimal MaxReward { get; set; }
        public bool IsOccupied { get; set; }
    }
}