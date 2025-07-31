using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using HelloWorldRazor.Data;
using HelloWorldRazor.Models;

namespace HelloWorldRazor.Pages.Bookings
{
    public class IndexModel : PageModel
    {
        private readonly HelloWorldRazor.Data.HelloWorldRazorContext _context;

        public IndexModel(HelloWorldRazor.Data.HelloWorldRazorContext context)
        {
            _context = context;
        }

        public IList<Booking> Booking { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Booking = await _context.Booking
                .Include(b => b.Asset)
                .Include(b => b.Customer)
                .Include(b => b.Location).ToListAsync();
        }
    }
}
