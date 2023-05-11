using Microsoft.AspNetCore.Mvc;

namespace Home_test.Api.Controllers
{
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

[ApiController]
[Route("api/[controller]")]
public class WorkersController : ControllerBase
{
    private readonly IWorkersRepository _repository;

    public WorkersController(IWorkersRepository repository)
    {
        _repository = repository;
    }

    [HttpGet]
    public ActionResult<IEnumerable<Worker>> GetAllWorkers()
    {
        var workers = _repository.GetAllWorkers();
        return Ok(workers);
    }

    [HttpGet("{id}")]
    public ActionResult<Worker> GetWorkerById(int id)
    {
        var worker = _repository.GetWorkerById(id);

        if (worker == null)
        {
            return NotFound();
        }

        return Ok(worker);
    }

    [HttpPost]
    public ActionResult<Worker> CreateWorker(Worker worker)
    {
        _repository.CreateWorker(worker);
        return CreatedAtAction(nameof(GetWorkerById), new { id = worker.Id }, worker);
    }
}

    }
}
