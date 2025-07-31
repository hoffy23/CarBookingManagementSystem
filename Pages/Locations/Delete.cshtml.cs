using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using HelloWorldRazor.Data;
using HelloWorldRazor.Models;

namespace HelloWorldRazor.Pages.Locations
{
    public class DeleteModel : PageModel
    {
        private readonly HelloWorldRazor.Data.HelloWorldRazorContext _context;

        public DeleteModel(HelloWorldRazor.Data.HelloWorldRazorContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Location Location { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var location = await _context.Location.FirstOrDefaultAsync(m => m.Id == id);

            if (location is not null)
            {
                Location = location;

                return Page();
            }

            return NotFound();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var location = await _context.Location.FindAsync(id);
            if (location != null)
            {
                Location = location;
                _context.Location.Remove(Location);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
