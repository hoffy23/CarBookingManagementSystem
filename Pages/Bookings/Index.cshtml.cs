using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using CarBookingManagementSystem.Data;
using CarBookingManagementSystem.Models;

namespace CarBookingManagementSystem.Pages.Bookings
{
    public class IndexModel : PageModel
    {
        private readonly CarBookingManagementSystem.Data.CarBookingManagementSystemContext _context;

        public IndexModel(CarBookingManagementSystem.Data.CarBookingManagementSystemContext context)
        {
            _context = context;
        }

        public IList<Booking> Booking { get; set; } = default!;

        public async Task OnGetAsync()
        {
            Booking = await _context.Booking
                .Include(b => b.Vehicle)
                .Include(b => b.Customer)
                .Include(b => b.Location).ToListAsync();
        }
    }
}
