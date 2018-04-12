using System.Threading.Tasks;
using FreshMarqueSnails.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace FreshMarqueSnails.Pages.CustomerOrder
{
    public class DetailsModel : PageModel
    {
        private readonly CustomerOrderContext _context;

        public DetailsModel(CustomerOrderContext context)
        {
            _context = context;
        }

        public Models.CustomerOrder CustomerOrder { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null) return NotFound();

            CustomerOrder = await _context.CustomerOrder.SingleOrDefaultAsync(m => m.ID == id);

            if (CustomerOrder == null) return NotFound();
            return Page();
        }
    }
}