using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MovieCorp.Pages
{
    public class RentalModel : PageModel
    {
        private readonly ILogger<RentalModel> _logger;

        public RentalModel(ILogger<RentalModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {

        }
    }
}