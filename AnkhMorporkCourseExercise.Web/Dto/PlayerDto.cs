namespace AnkhMorporkCourseExercise.Web.Dto
{
    public class PlayerDto
    {
        public decimal CurrentMoneyAmount = 100;
        public bool IsAlive => CurrentMoneyAmount > 0;
    }
}