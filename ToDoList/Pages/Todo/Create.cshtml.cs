using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ToDoList.Data;
using ToDoList.Models;

namespace ToDoList.Pages.Todo
{
    public class CreateModel : PageModel
    {
        [BindProperty]
        public ToDo task { get; set; }

        private readonly ToDoContext _db;
        public CreateModel(ToDoContext db)
        {
            _db = db;
        }
        public void OnGet()
        {
        }

        public async Task<IActionResult> OnPost()
        {
            if (ModelState.IsValid)
            {
                await _db.ToDos.AddAsync(task);
                await _db.SaveChangesAsync();
                return RedirectToPage("Tasks");
            }
            return Page();
        }
    }
}
