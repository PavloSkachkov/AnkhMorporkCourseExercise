using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnkhMorporkCourseExercise
{
    interface IEncounter
    {
        void Action(Player player);
        void Acception(Player player);
        void Decline(Player player);

    }
}
