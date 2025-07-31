using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using HelloWorldRazor.Models;

namespace HelloWorldRazor.Data
{
    public class HelloWorldRazorContext : DbContext
    {
        public HelloWorldRazorContext (DbContextOptions<HelloWorldRazorContext> options)
            : base(options)
        {
        }

        public DbSet<HelloWorldRazor.Models.Asset> Asset { get; set; } = default!;
        public DbSet<HelloWorldRazor.Models.Booking> Booking { get; set; } = default!;
        public DbSet<HelloWorldRazor.Models.Customer> Customer { get; set; } = default!;
        public DbSet<HelloWorldRazor.Models.Location> Location { get; set; } = default!;
    }
}
