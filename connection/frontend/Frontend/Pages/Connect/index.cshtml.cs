using System.Net.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Frontend.Pages.Connect
{
    public class IndexModel : PageModel
    {
        [HttpGet()]
        public IActionResult OnGet([FromQuery(Name = "target")] string target)
        {
            var client = new HttpClient();
            var result = client.GetStringAsync(target).Result;
            ViewData["result"] = result;
            return Page();
        }
    }
}