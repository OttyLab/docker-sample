using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Frontend.Pages.Onigiri
{
    public class CreateModel : PageModel
    {
        private readonly Models.FrontendContext _context;

        public CreateModel(Models.FrontendContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Models.Onigiri Onigiri { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Onigiri.Add(Onigiri);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}