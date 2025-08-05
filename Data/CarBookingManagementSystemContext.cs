using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CarBookingManagementSystem.Models;

namespace CarBookingManagementSystem.Data
{
    public class CarBookingManagementSystemContext : DbContext
    {
        public CarBookingManagementSystemContext(DbContextOptions<CarBookingManagementSystemContext> options)
            : base(options)
        {
        }

        public DbSet<CarBookingManagementSystem.Models.Vehicle> Vehicle { get; set; } = default!;
        public DbSet<CarBookingManagementSystem.Models.Booking> Booking { get; set; } = default!;
        public DbSet<CarBookingManagementSystem.Models.Customer> Customer { get; set; } = default!;
        public DbSet<CarBookingManagementSystem.Models.Location> Location { get; set; } = default!;
    }
}
