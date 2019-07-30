using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace Frontend.Pages.Onigiri
{
    public class IndexModel : PageModel
    {
        private readonly Models.FrontendContext _context;

        public IndexModel(Models.FrontendContext context)
        {
            _context = context;
        }

        public IList<Models.Onigiri> Onigiri { get;set; }

        public async Task OnGetAsync()
        {
            Onigiri = await _context.Onigiri.ToListAsync();
        }
    }
}
