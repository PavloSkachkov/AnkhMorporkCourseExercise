using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnkhMorporkCourseExercise
{
    public class Player
    {
        public double moneyAmount { get; set; }
        public Player()
        {
            this.moneyAmount = 100;
        }
        public override string ToString()
        {
            return $"---------------------------\n You're left with {moneyAmount} AM$ \n---------------------------";
        }
    }
}
