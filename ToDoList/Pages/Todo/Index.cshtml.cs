using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ToDoList.Data;
using ToDoList.Models;

namespace ToDoList.Pages.Todo
{
    public class IndexModel : PageModel
    {
        private readonly ToDoContext _db;
        public IndexModel(ToDoContext db)
        {
            _db = db;
        }
        public List<ToDo> ToDos { get; set; }
        public void OnGet()
        {
            ToDos = _db.ToDos.ToList();
        }

        public void
    }
}
