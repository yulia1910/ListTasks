using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ListTaskLab.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ListTasks.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FundsController : ControllerBase
    {
        private readonly ITodoService _todoService;

        public FundsController(ITodoService todoService)
        {
            _todoService = todoService;
        }

        
        [HttpGet("{title}")]
        public IActionResult GetTodo(string title)
        {
            var result = _todoService.returnTasks(title);
            return Ok(result);
        }

        [HttpGet]
        public IActionResult GetTodo()
        {
            return Ok(_todoService.getAllTasks());
        }
    }
}
