using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ToDoList.Data;
using ToDoList.Models;

namespace ToDoList.Pages.Todo
{
    public class DeleteModel : PageModel
    {
        [BindProperty]
        public ToDo task { get; set; }

        private readonly ToDoContext _db;
        public DeleteModel(ToDoContext db)
        {
            _db = db;
        }
        public void OnGet(int id)
        {
            task = _db.ToDos.Find(id);
        }

        public async Task<IActionResult> OnPost()
        {
            var id = _db.ToDos.Find(task.Id);
            if(id != null)
            {
                _db.ToDos.Remove(id);
                await _db.SaveChangesAsync();
                return RedirectToPage("Tasks");
            }
            return Page();
            
        }
    }
}
