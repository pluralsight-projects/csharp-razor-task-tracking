using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Tasker.Pages
{
    public class CreateTaskModel : PageModel
    {
        [BindProperty]
        public Task NewTask = new Task();

        public IActionResult OnPost()
        {
            return RedirectToPage("Index");
        }
        public void OnGet()
        {
            
        }
    }
}