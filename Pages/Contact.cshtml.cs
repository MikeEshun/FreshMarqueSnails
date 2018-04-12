using Microsoft.AspNetCore.Mvc.RazorPages;

namespace FreshMarqueSnails.Pages
{
    public class ContactModel : PageModel
    {
        public string Message { get; set; }

        public void OnGet()
        {
            Message = "Contact us on FB and IG.";
        }
    }
}