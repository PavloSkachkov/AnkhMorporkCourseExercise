using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnkhMorporkCourseExercise
{
    public class Assassin
    {
        public double MinReward { get; private set; }
        public double MaxReward { get; private set; }
        public bool IsOccupied { get; set; }

        public Assassin(double minReward, double maxReward)
        {
            this.MinReward = minReward;
            this.MaxReward = maxReward;
            this.IsOccupied = false;
        }
    }
}
