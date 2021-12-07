using System;

namespace AnkhMorporkCourseExercise.Models
{
    public class Player
    {
        private decimal _moneyAmount;
        public bool IsAlive => _moneyAmount > 0;

        public Player()
        {
            _moneyAmount = 100;
        }

        public void IncreaseMoneyAmount(decimal amount)
        {
            _moneyAmount += amount;
            Console.WriteLine($" You acquired {MoneyAmountFormatter.FormatMoneyAmount(amount)}");
        }


        public void DecreaseMoneyAmount(decimal amount)
        {
            if (amount > _moneyAmount)
                _moneyAmount = 0;
            else
                _moneyAmount -= amount;
            Console.WriteLine($" You spent {MoneyAmountFormatter.FormatMoneyAmount(amount)}");
        }

        public void Kill() => _moneyAmount = 0;

        public override string ToString()
        {
            return $"{new string('-', 15)}\n You're left with {MoneyAmountFormatter.FormatMoneyAmount(_moneyAmount)} \n{new string('-', 15)}";
        }
    }
}
