﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnkhMorporkCourseExercise
{
    public class Beggar
    {
        public string Name { get; private set; }
        public double Alm { get; private set; }

        public Beggar(string name, double alm)
        {
            this.Name = name;
            this.Alm = alm;
        }
    }
}
