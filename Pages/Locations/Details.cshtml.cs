using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using CarBookingManagementSystem.Data;
using CarBookingManagementSystem.Models;

namespace CarBookingManagementSystem.Pages.Locations
{
    public class DetailsModel : PageModel
    {
        private readonly CarBookingManagementSystem.Data.CarBookingManagementSystemContext _context;

        public DetailsModel(CarBookingManagementSystem.Data.CarBookingManagementSystemContext context)
        {
            _context = context;
        }

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
    }
}
