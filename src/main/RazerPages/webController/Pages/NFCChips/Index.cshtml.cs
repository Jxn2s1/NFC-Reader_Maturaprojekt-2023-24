using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using webController.Data;
using webController.Models;

namespace webController.Pages.NFCChips
{
    public class IndexModel : PageModel
    {
        private readonly webController.Data.webControllerContext _context;

        public IndexModel(webController.Data.webControllerContext context)
        {
            _context = context;
        }

        public IList<NFCChip> NFCChips { get;set; } = default!;

        public async Task OnGetAsync()
        {
            NFCChips = await _context.NFCChips.ToListAsync();
        }
    }
}
