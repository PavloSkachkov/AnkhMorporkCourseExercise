namespace AnkhMorporkCourseExercise.Models
{
    public class Beggar
    {
        public string Name { get; private set; }
        public decimal Alm { get; private set; }

        public Beggar(string name, decimal alm)
        {
            this.Name = name;
            this.Alm = alm;
        }
    }
}
