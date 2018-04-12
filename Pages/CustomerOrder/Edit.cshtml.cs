using System.Linq;
using System.Threading.Tasks;
using FreshMarqueSnails.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace FreshMarqueSnails.Pages.CustomerOrder
{
    public class EditModel : PageModel
    {
        private readonly CustomerOrderContext _context;

        public EditModel(CustomerOrderContext context)
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

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid) return Page();

            _context.Attach(CustomerOrder).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!_context.CustomerOrder.Any(e => e.ID == CustomerOrder.ID))
                    return NotFound();
                throw;
            }

            return RedirectToPage("./Index");
        }

        private bool CustomerOrderExists(int id)
        {
            return _context.CustomerOrder.Any(e => e.ID == id);
        }
    }
}