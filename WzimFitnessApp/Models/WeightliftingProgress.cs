﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WzimFitnessApp.Models
{
    public class WeightliftingProgress : GoalProgress
    {
        public float Weight { get; set; }
        public int Reps { get; set; }

    }
}
