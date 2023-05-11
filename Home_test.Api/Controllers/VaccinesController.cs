using System.Collections.Generic;
using Home_test.Api.Models.Entities;
using Microsoft.AspNetCore.Mvc;

namespace MyApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class VaccinesController : ControllerBase
    {
        private readonly Database _database;

        public VaccinesController(Database database)
        {
            _database = database;
        }

        [HttpPost]
        public IActionResult Post(Vaccine vaccine)
        {
            _database.AddVaccine(vaccine);
            return Ok();
        }

        [HttpGet("{workerId}")]
        public ActionResult<List<Vaccine>> Get(int workerId)
        {
            var vaccines = _database.GetVaccinesByWorkerId(workerId);

            if (vaccines == null || vaccines.Count == 0)
            {
                return NotFound();
            }

            return vaccines;
        }
    }
}
