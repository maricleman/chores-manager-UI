using System;
using System.Collections.Generic;
using System.Text;
using static Scheduler.BusinessLogic.DTOs.EnumsDto;

namespace Scheduler.BusinessLogic.DTOs
{
    public class ChoreDto
    {
        public string Name { get; set; }
        public int DifficultyLevel { get; set; }
        public Frequency ChoreFrequency { get; set; }
    }
}
