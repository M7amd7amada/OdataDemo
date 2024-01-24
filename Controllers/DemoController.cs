using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.OData.Formatter;
using Microsoft.AspNetCore.OData.Query;
using Microsoft.AspNetCore.OData.Results;
using Odata.Models;
using Odata.Repositories;

namespace Odata.Controllers;

[ApiController]
[Route("api/[controller]/[action]")]
public class DemoController : ControllerBase
{
    private readonly IDemoRepository _repo;

    public DemoController(IDemoRepository repo)
    {
        _repo = repo;
    }

    [HttpGet]
    [EnableQuery]
    public ActionResult<IQueryable<DemoModel>> GetAll()
    {
        return Ok(_repo.GetAll());
    }

    [HttpGet]
    [EnableQuery]
    public ActionResult<SingleResult<DemoModel>> GetById([FromODataUri] int id)
    {
        return Ok(SingleResult.Create(_repo.GetById(id)));
    }
}