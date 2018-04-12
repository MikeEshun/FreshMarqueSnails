using Microsoft.AspNetCore.Mvc.RazorPages;

namespace FreshMarqueSnails.Pages
{
    public class AboutModel : PageModel
    {
        public string Message { get; set; }

        public void OnGet()
        {
            Message = "About Us. Is it relevant though?";
        }
    }
}