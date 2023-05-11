using System.Collections.Generic;
using Home_test.Api.Models.Entities;
using Microsoft.AspNetCore.Mvc;

namespace MyApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class InfectedPeopleController : ControllerBase
    {
        private readonly Database _database;

        public InfectedPeopleController(Database database)
        {
            _database = database;
        }

        [HttpPost]
        public IActionResult Post(InfectedPerson infectedPerson)
        {
            _database.AddInfectedPerson(infectedPerson);
            return Ok();
        }

        [HttpGet("{id}")]
        public ActionResult<InfectedPerson> Get(int id)
        {
            var infectedPerson = _database.GetInfectedPersonById(id);

            if (infectedPerson == null)
            {
                return NotFound();
            }

            return infectedPerson;
        }

        [HttpGet]
        public ActionResult<List<InfectedPerson>> Get()
        {
            var infectedPeople = _database.GetAllInfectedPeople();

            if (infectedPeople == null || infectedPeople.Count == 0)
            {
                return NotFound();
            }

            return infectedPeople;
        }
    }
}

