using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace Frontend.Pages.Onigiri
{
    public class DetailsModel : PageModel
    {
        private readonly Models.FrontendContext _context;

        public DetailsModel(Models.FrontendContext context)
        {
            _context = context;
        }

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
    }
}
