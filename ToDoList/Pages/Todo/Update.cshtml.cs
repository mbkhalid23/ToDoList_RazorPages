using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ToDoList.Data;
using ToDoList.Models;

namespace ToDoList.Pages.Todo
{
    public class UpdateModel : PageModel
    {
        [BindProperty]
        public ToDo task { get; set; }

        private readonly ToDoContext _db;
        public UpdateModel(ToDoContext db)
        {
            _db = db;
        }
        public void OnGet(int id)
        {
            task = _db.ToDos.Find(id);
        }

        public async Task<IActionResult> OnPost()
        {
            if (ModelState.IsValid)
            {
                _db.ToDos.Update(task);
                await _db.SaveChangesAsync();
                return RedirectToPage("Tasks");
            }
            return Page();
        }
    }
}
