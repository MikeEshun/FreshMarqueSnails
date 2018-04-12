using System.Threading.Tasks;
using FreshMarqueSnails.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace FreshMarqueSnails.Pages.CustomerOrder
{
    public class CreateModel : PageModel
    {
        private readonly CustomerOrderContext _context;

        public CreateModel(CustomerOrderContext context)
        {
            _context = context;
        }

        [BindProperty] public Models.CustomerOrder CustomerOrder { get; set; }

        public IActionResult OnGet()
        {
            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid) return Page();

            _context.CustomerOrder.Add(CustomerOrder);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}