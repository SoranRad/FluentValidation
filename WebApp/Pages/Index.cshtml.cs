using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebApp.ViewModels;

namespace WebApp.Pages
{
    public class IndexModel : PageModel
    {
        [BindProperty]
        public FileValidationViewModel Form { get; set; }


        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
                return Page();

            return RedirectToPage();
        }
    }
}