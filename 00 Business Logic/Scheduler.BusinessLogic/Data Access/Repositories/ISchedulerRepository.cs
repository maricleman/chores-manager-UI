using Scheduler.BusinessLogic.Data_Access.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Scheduler.BusinessLogic.Data_Access.Repositories
{
    public interface ISchedulerRepository
    {
        List<Person> GetAllPeopleInHousehold();
    }
}
