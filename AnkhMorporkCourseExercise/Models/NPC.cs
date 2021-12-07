using System;

namespace AnkhMorporkCourseExercise.Models
{
    public class NPC
    {
        public string Name { get; protected set; }
        public decimal DealMoneyAmount { get; protected set; }
        public NPC (string name, decimal dealMoneyAmount)
        {
            Name = name;
            DealMoneyAmount = dealMoneyAmount;
        }

        public virtual void AnounceDealMoneyAmount()
        {
            Console.WriteLine($" You will spend {MoneyAmountFormatter.FormatMoneyAmount(DealMoneyAmount)}");
        }
    }
}
