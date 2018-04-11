using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using FreshMarqueSnails.Models;

namespace FreshMarqueSnails.Pages.CustomerOrder
{
    public class EditModel : PageModel
    {
        private readonly FreshMarqueSnails.Models.CustomerOrderContext _context;

        public EditModel(FreshMarqueSnails.Models.CustomerOrderContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Models.CustomerOrder CustomerOrder { get; set; }

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

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(CustomerOrder).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CustomerOrderExists(CustomerOrder.ID))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool CustomerOrderExists(int id)
        {
            return _context.CustomerOrder.Any(e => e.ID == id);
        }
    }
}
