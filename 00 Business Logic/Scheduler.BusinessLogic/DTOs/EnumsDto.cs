using System;
using System.Collections.Generic;
using System.Text;

namespace Scheduler.BusinessLogic.DTOs
{
    public class EnumsDto
    {
        public enum Frequency
        {
            OddWeeks = 0,
            EvenWeeks = 1,
            OnceAMonth = 2
        }
    }
}
