using System;
using System.Collections.Generic;
using System.Text;

namespace Scheduler.BusinessLogic.Data_Access.Entities
{
    public class Chore
    {
        public string Name { get; set; }
        public int DifficultyLevel { get; set; }
        public string ChoreFrequency { get; set; }
    }
}
