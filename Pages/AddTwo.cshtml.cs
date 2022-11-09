using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorPagesAddTwo.Pages
{
    public class AddTwoModel : PageModel
    {
        public string TotalMessage = "";
        public int A;
        public int B;
        public void OnGet()
        {
        }

        public void OnPost(int a, int b)
        {
            A = a;
            B = b;
            TotalMessage = A + " + " + B + " = " + (A + B);
        }
    }
    
}
