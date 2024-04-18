using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Globalization;

namespace WebStarterApp.Pages
{
    public class IndexModel : PageModel
    {
        public string? CurrentDay { get; set; }

        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public IActionResult OnGet()
        {
            CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("en-US");
            CurrentDay = DateTime.Now.ToString("dddd");
            return Page();
        }
    }
}