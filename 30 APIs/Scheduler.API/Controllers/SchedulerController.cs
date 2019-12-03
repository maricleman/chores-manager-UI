using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Scheduler.BusinessLogic.Data_Access.DbContexts;
using Scheduler.BusinessLogic.Data_Access.Repositories;
using Scheduler.BusinessLogic.DTOs;

namespace Scheduler.API.Controllers
{
    public class SchedulerController : Controller
    {
        private readonly ISchedulerRepository _schedulerRepository;

        public SchedulerController(ISchedulerRepository schedulerRepository)
        {
            _schedulerRepository = schedulerRepository;
        }
        public IEnumerable<PersonDto> Index()
        {
            //var results = _schedulerRepository.GetAllPeopleInHousehold();
            var megan = new PersonDto();
            megan.FirstName = "Megan";
            megan.LastName = "Barnicles";
            megan.Age = 52;
            megan.HouseholdRole = "Sister";

            var david = new PersonDto();
            david.FirstName = "David";
            david.LastName = "Barnicles";
            david.Age = 62;
            david.HouseholdRole = "Head";

            var results = new List<PersonDto>();
            results.Add(megan);
            results.Add(david);
            return results;
        }
    }
}