using CleanApp.Application.Abstractions;
using CleanApp.Domain.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CleanApp.WebApi.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class TodosController : ControllerBase
    {
        ITodoService service;

        public TodosController(ITodoService service)
        {
            this.service = service;
        }

        // GET: api/v1/<TodosController>
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TodoItem>>> Get()
        {
            var todos = await service.GetAllAsync();
            return Ok(todos);
        }

        // GET api/v1/<TodosController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TodoItem>> Get(Guid id)
        {
            var todo = await service.GetByIdAsync(id);
            return Ok(todo);
        }

        // POST api/v1/<TodosController>
        [HttpPost]
        public async Task<ActionResult<TodoItem>> Post([FromBody] TodoItem todo)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var result = await service.AddAsync(todo);
            return Ok(result);
        }
    }
}
