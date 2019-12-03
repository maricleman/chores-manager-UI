using Microsoft.EntityFrameworkCore;
using Scheduler.BusinessLogic.Data_Access.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Scheduler.BusinessLogic.Data_Access.DbContexts
{
    public class SchedulerContext : DbContext, ISchedulerContext
    {
        /* When the context is being spung up, it takes the options 
         * we specified at startup and passes them into the context 
         * in order to determine what connection string to use.
         */
        public SchedulerContext(DbContextOptions<SchedulerContext> options) : base(options)
        {

        }

        public virtual DbSet<Person> Persons { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

        }
    }
}