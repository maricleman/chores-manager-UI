using Microsoft.EntityFrameworkCore;
using Scheduler.BusinessLogic.Data_Access.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Scheduler.BusinessLogic.Data_Access.DbContexts
{
    public interface ISchedulerContext
    {
        DbSet<Person> Persons { get; set; }
    }
}
