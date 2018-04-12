using System.Threading.Tasks;
using FreshMarqueSnails.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace FreshMarqueSnails.Pages.CustomerOrder
{
    public class DeleteModel : PageModel
    {
        private readonly CustomerOrderContext _context;

        public DeleteModel(CustomerOrderContext context)
        {
            _context = context;
        }

        [BindProperty] public Models.CustomerOrder CustomerOrder { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null) return NotFound();

            CustomerOrder = await _context.CustomerOrder.SingleOrDefaultAsync(m => m.ID == id);

            if (CustomerOrder == null) return NotFound();
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null) return NotFound();

            CustomerOrder = await _context.CustomerOrder.FindAsync(id);

            if (CustomerOrder != null)
            {
                _context.CustomerOrder.Remove(CustomerOrder);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}