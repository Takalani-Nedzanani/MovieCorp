using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MovieCorp.Pages
{
    public class CheckOutModel : PageModel
    {
        private readonly ILogger<CheckOutModel> _logger;

        public CheckOutModel(ILogger<CheckOutModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {

        }
    }
}