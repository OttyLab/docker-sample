using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace Frontend.Pages.Onigiri
{
    public class EditModel : PageModel
    {
        private readonly Models.FrontendContext _context;

        public EditModel(Models.FrontendContext context)
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

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Onigiri).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!OnigiriExists(Onigiri.Id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool OnigiriExists(int id)
        {
            return _context.Onigiri.Any(e => e.Id == id);
        }
    }
}
