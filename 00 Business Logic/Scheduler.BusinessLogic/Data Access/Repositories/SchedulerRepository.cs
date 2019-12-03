using Scheduler.BusinessLogic.Data_Access.DbContexts;
using Scheduler.BusinessLogic.Data_Access.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Scheduler.BusinessLogic.Data_Access.Repositories
{
    public class SchedulerRepository
    {
        private readonly ISchedulerContext _schedulerContext;

        public SchedulerRepository(ISchedulerContext schedulerContext)
        {
            _schedulerContext = schedulerContext;
        }
        /// <summary>
        /// Getting a list of all people in the house
        /// who contribute to the household chores.
        /// </summary>
        /// <returns>List of the Person entity</returns>
        public List<Person> GetAllPeopleInHousehold()
        {
            var listOfPeople = new List<Person>();
            listOfPeople.AddRange(_schedulerContext.Persons.ToList());
            return listOfPeople;
        }
    }
}
