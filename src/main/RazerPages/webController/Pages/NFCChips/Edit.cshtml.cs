using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using webController.Data;
using webController.Models;

namespace webController.Pages.NFCChips
{
    public class EditModel : PageModel
    {
        private readonly webController.Data.webControllerContext _context;

        public EditModel(webController.Data.webControllerContext context)
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

            var nfcchips =  await _context.NFCChips.FirstOrDefaultAsync(m => m.Id == id);
            if (nfcchips == null)
            {
                return NotFound();
            }
            NFCChips = nfcchips;
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(NFCChips).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!NFCChipsExists(NFCChips.Id))
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

        private bool NFCChipsExists(int id)
        {
            return _context.NFCChips.Any(e => e.Id == id);
        }
    }
}
