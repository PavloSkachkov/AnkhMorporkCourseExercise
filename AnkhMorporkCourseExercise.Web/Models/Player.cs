namespace AnkhMorporkCourseExercise.Web.Models
{
    public class Player
    {
        private const decimal StartMoneyAmount = 100;
        public decimal CurrentMoneyAmount { get; set; }
        public bool IsAlive => CurrentMoneyAmount > 0;
        public int BeerAmount;

        public Player()
        {
            CurrentMoneyAmount = StartMoneyAmount;
        }

        public void IncreaseMoneyAmount(decimal amount)
        {
            CurrentMoneyAmount += amount;
        }

        public void DecreaseMoneyAmount(decimal amount)
        {
            if (amount > CurrentMoneyAmount)
                CurrentMoneyAmount = 0;
            else
                CurrentMoneyAmount -= amount;
        }

        public void Kill() => CurrentMoneyAmount = 0;
    }
}
