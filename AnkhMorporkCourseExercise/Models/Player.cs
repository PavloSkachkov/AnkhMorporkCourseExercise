using System;

namespace AnkhMorporkCourseExercise.Models
{
    public class Player
    {
        private const decimal StartMoneyAmount = 100;
        public decimal CurrentMoneyAmount;
        public bool IsAlive => CurrentMoneyAmount > 0;

        public Player()
        {
            CurrentMoneyAmount = StartMoneyAmount;
        }

        public void IncreaseMoneyAmount(decimal amount)
        {
            CurrentMoneyAmount += amount;
            Console.WriteLine($" You acquired {MoneyAmountFormatter.FormatMoneyAmount(amount)}");
        }


        public void DecreaseMoneyAmount(decimal amount)
        {
            if (amount > CurrentMoneyAmount)
                CurrentMoneyAmount = 0;
            else
                CurrentMoneyAmount -= amount;
            Console.WriteLine($" You spent {MoneyAmountFormatter.FormatMoneyAmount(amount)}");
        }

        public void Kill() => CurrentMoneyAmount = 0;

        public override string ToString()
        {
            return $"{new string('-', 15)}\n You're left with {MoneyAmountFormatter.FormatMoneyAmount(CurrentMoneyAmount)} \n{new string('-', 15)}";
        }
    }
}
