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
    public class IndexModel : PageModel
    {
        private readonly FreshMarqueSnails.Models.CustomerOrderContext _context;

        public IndexModel(FreshMarqueSnails.Models.CustomerOrderContext context)
        {
            _context = context;
        }

        public IList<CustomerOrder> CustomerOrder { get;set; }

        public async Task OnGetAsync()
        {
            CustomerOrder = await _context.CustomerOrder.ToListAsync();
        }
    }
}
