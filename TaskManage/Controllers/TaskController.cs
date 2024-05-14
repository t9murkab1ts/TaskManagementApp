using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;


namespace TaskManage.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TaskController : Controller
    {
        private static List<Task> tasks = new List<Task>()
        {
        new Task { Id = 1, Title = "Task 1", Description = "Description for Task 1", IsCompleted = false },
        new Task { Id = 2, Title = "Task 2", Description = "Description for Task 2", IsCompleted = true },
        new Task { Id = 3, Title = "Task 3", Description = "Description for Task 3", IsCompleted = false }
        };

        [HttpGet]
        public IEnumerable<Task> Get()
        {
            return tasks;
        }

        [HttpGet("{id}", Name = "Get")]
        public IActionResult Get(int id)
        {
            var task = tasks.Find(t => t.Id == id);
            if (task == null)
            {
                return NotFound();
            }
            return Ok(task);
        }
    }
}
