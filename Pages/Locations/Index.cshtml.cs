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
    public class IndexModel : PageModel
    {
        private readonly HelloWorldRazor.Data.HelloWorldRazorContext _context;

        public IndexModel(HelloWorldRazor.Data.HelloWorldRazorContext context)
        {
            _context = context;
        }

        public IList<Location> Location { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Location = await _context.Location.ToListAsync();
        }
    }
}
