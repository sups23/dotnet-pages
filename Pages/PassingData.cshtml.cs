using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace suprav21776.Pages
{
    public class PassingDataModel : PageModel
    {
        public void OnGet()
        {
            ViewData["message"] = "Eat meal";
            TempData["message"] = "Buy milk";
        }
    }
}
