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
        public void OnGet()
        {
        }

        public async Task<IActionResult> OnPost()
        {
            await _db.ToDos.AddAsync(task);
            await _db.SaveChangesAsync();
            return RedirectToPage("Tasks");
        }
    }
}
