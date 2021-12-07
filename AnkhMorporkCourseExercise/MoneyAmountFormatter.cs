using System;

namespace AnkhMorporkCourseExercise
{
    public static class MoneyAmountFormatter
    {
        public static string FormatMoneyAmount(decimal amount)
        {
            return $"{Math.Truncate(amount)} AM$ and {Math.Truncate(100 * (amount - Math.Truncate(amount)))} pennies";
        }
    }
}
