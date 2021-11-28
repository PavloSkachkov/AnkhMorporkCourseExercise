namespace AnkhMorporkCourseExercise
{
    public class Player
    {
        public double moneyAmount { get; set; }
        public Player()
        {
            this.moneyAmount = 100;
        }
        public override string ToString()
        {
            return $"---------------------------\n You're left with {moneyAmount} AM$ \n---------------------------";
        }
    }
}
