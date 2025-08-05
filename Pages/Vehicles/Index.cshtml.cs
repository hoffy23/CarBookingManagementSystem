using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using CarBookingManagementSystem.Data;
using CarBookingManagementSystem.Models;

namespace CarBookingManagementSystem.Pages.Vehicles
{
    public class IndexModel : PageModel
    {
        private readonly CarBookingManagementSystem.Data.CarBookingManagementSystemContext _context;

        public IndexModel(CarBookingManagementSystem.Data.CarBookingManagementSystemContext context)
        {
            _context = context;
        }

        public IList<Models.Vehicle> Vehicle { get; set; } = default!;

        public async Task OnGetAsync()
        {
            Vehicle = await _context.Vehicle.ToListAsync();
        }
    }
}
