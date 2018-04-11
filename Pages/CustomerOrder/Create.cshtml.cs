using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using FreshMarqueSnails.Models;

namespace FreshMarqueSnails.Pages.CustomerOrder
{
    public class CreateModel : PageModel
    {
        private readonly CustomerOrderContext _context;

        public CreateModel(CustomerOrderContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Models.CustomerOrder CustomerOrder { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.CustomerOrder.Add(CustomerOrder);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}