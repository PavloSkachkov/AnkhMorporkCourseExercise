namespace AnkhMorporkCourseExercise.Models
{
    public class Beggar
    {
        public string Name { get; }
        public decimal Alm { get; }

        public Beggar(string name, decimal alm)
        {
            Name = name;
            Alm = alm;
        }
    }
}
