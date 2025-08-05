using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using CarBookingManagementSystem.Data;
using CarBookingManagementSystem.Models;

namespace CarBookingManagementSystem.Pages.Bookings
{
    public class CreateModel : PageModel
    {
        private readonly CarBookingManagementSystem.Data.CarBookingManagementSystemContext _context;

        public CreateModel(CarBookingManagementSystem.Data.CarBookingManagementSystemContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            ViewData["VehicleId"] = new SelectList(_context.Vehicle, "Id", "Make");
            ViewData["CustomerId"] = new SelectList(_context.Set<Customer>(), "Id", "Address");
            ViewData["LocationId"] = new SelectList(_context.Set<Location>(), "Id", "Address");
            return Page();
        }

        [BindProperty]
        public Booking Booking { get; set; } = default!;

        // For more information, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Booking.Add(Booking);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
