using Microsoft.EntityFrameworkCore;
using Scheduler.BusinessLogic.Data_Access.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Scheduler.BusinessLogic.Data_Access.DbContexts
{
    public class SchedulerContext : DbContext, ISchedulerContext
    {

        public SchedulerContext(DbContextOptions<SchedulerContext> options) : base(options)
        {

        }

        public virtual DbSet<Person> Persons { get; set; }
        public virtual DbSet<Chore> Chores { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

        }
    }
}