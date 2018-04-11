using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using FreshMarqueSnails.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace FreshMarqueSnails.Pages.CustomerOrder
{
    public class IndexModel : PageModel
    {
        private readonly CustomerOrderContext _context;

        public IndexModel(CustomerOrderContext context)
        {
            _context = context;
        }

        public IList<Models.CustomerOrder> CustomerOrder { get;set; }

        public async Task OnGetAsync()
        {
//            var orders = from c in _context.CustomerOrder
//                select c;
            
            CustomerOrder = await _context.CustomerOrder.ToListAsync();
        }
    }
}
