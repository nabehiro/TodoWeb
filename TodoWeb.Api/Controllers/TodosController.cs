using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using TodoWeb.Api.Models;

namespace TodoWeb.Api.Controllers
{
    public class TodosController : ApiController
    {
        static List<Todo> Todos = new List<Todo>
        {
            new Todo { Id = 1, Title = "React Study", Completed = true },
            new Todo { Id = 2, Title = "Flux Study", Completed = false },
            new Todo { Id = 3, Title = "Redux Study", Completed = false }
        };

        static int nextId = Todos.Count == 0 ? 1 : Todos.OrderByDescending(t => t.Id).First().Id + 1;

        // GET: api/Todos
        public IEnumerable<Todo> GetAllTodos()
        {
            return Todos;
        }

        // GET: api/Todos/5
        public IHttpActionResult GetTodo(int id)
        {
            var todo = Todos.FirstOrDefault(t => t.Id == id);
            if (todo == null)
                return NotFound();
            else
                return Ok(todo);
        }

        // PUT: api/Todos/5
        public IHttpActionResult PutTodo(int id, Todo todo)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var curTodo = Todos.FirstOrDefault(t => t.Id == id);
            if (curTodo == null)
                return NotFound();

            curTodo.Title = todo.Title;
            curTodo.Completed = todo.Completed;

            return StatusCode(HttpStatusCode.NoContent);    // 204:No Content
        }

        // POST: api/Todos
        public IHttpActionResult PostTodo(Todo todo)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            todo.Id = nextId++;
            Todos.Add(todo);

            return CreatedAtRoute("DefaultApi", new { id = todo.Id }, todo);    // 201:Created
        }

        // DELETE: api/Todos/5
        public IHttpActionResult DeleteTodo(int id)
        {
            var todo = Todos.FirstOrDefault(t => t.Id == id);
            if (todo == null)
                return NotFound();

            Todos.RemoveAll(t => t.Id == id);

            return Ok(todo);
        }
    }
}
