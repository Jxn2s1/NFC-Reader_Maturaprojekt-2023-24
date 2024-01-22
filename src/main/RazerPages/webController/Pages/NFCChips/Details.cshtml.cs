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
    public class DetailsModel : PageModel
    {
        private readonly webController.Data.webControllerContext _context;

        public DetailsModel(webController.Data.webControllerContext context)
        {
            _context = context;
        }

        public NFCChip NFCChips { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var nfcchips = await _context.NFCChips.FirstOrDefaultAsync(m => m.Id == id);
            if (nfcchips == null)
            {
                return NotFound();
            }
            else
            {
                NFCChips = nfcchips;
            }
            return Page();
        }
    }
}
