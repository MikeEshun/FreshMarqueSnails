using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using FreshMarqueSnails.Models;

namespace FreshMarqueSnails.Pages.CustomerOrder
{
    public class DeleteModel : PageModel
    {
        private readonly FreshMarqueSnails.Models.CustomerOrderContext _context;

        public DeleteModel(FreshMarqueSnails.Models.CustomerOrderContext context)
        {
            _context = context;
        }

        [BindProperty]
        public CustomerOrder CustomerOrder { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            CustomerOrder = await _context.CustomerOrder.SingleOrDefaultAsync(m => m.ID == id);

            if (CustomerOrder == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

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
