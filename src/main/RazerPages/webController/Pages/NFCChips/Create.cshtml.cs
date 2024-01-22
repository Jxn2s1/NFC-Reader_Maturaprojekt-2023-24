using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using webController.Data;
using webController.Models;

namespace webController.Pages.NFCChips
{
    public class CreateModel : PageModel
    {
        private readonly webController.Data.webControllerContext _context;

        public CreateModel(webController.Data.webControllerContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public NFCChip NFCChips { get; set; } = default!;

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.NFCChips.Add(NFCChips);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
