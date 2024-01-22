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
    public class DeleteModel : PageModel
    {
        private readonly webController.Data.webControllerContext _context;

        public DeleteModel(webController.Data.webControllerContext context)
        {
            _context = context;
        }

        [BindProperty]
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

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var nfcchips = await _context.NFCChips.FindAsync(id);
            if (nfcchips != null)
            {
                NFCChips = nfcchips;
                _context.NFCChips.Remove(NFCChips);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
