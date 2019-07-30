using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace Frontend.Pages.Onigiri
{
    public class DeleteModel : PageModel
    {
        private readonly Models.FrontendContext _context;

        public DeleteModel(Models.FrontendContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Models.Onigiri Onigiri { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Onigiri = await _context.Onigiri.FirstOrDefaultAsync(m => m.Id == id);

            if (Onigiri == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Onigiri = await _context.Onigiri.FindAsync(id);

            if (Onigiri != null)
            {
                _context.Onigiri.Remove(Onigiri);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
