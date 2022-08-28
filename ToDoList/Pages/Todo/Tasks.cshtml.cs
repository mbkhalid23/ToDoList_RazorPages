using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ToDoList.Data;
using ToDoList.Models;

namespace ToDoList.Pages.Todo
{
    public class TasksModel : PageModel
    {
        private readonly ToDoContext _db;
        public TasksModel(ToDoContext db)
        {
            _db = db;
        }
        public List<ToDo> ToDos { get; set; }
        public void OnGet()
        {
            ToDos = _db.ToDos.ToList();
        }

    }
}
