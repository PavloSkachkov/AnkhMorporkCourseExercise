using System;

namespace AnkhMorporkCourseExercise.Models
{
    public class Fool : NPC
    {
        public Fool(string name, decimal dealMoneyAmount) : base(name, dealMoneyAmount)
        {
        }

        public override void AnounceDealMoneyAmount()
        {
            Console.WriteLine($"You will receive {Math.Truncate(DealMoneyAmount)} AM$ and {Math.Truncate(10 * (DealMoneyAmount - Math.Truncate(DealMoneyAmount)))} pennies");
        }
    }
}
