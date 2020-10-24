using Microsoft.EntityFrameworkCore;
using MidTermPracrice.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MidTermPracrice.Data
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Interpolate> Interpolates { get; set; }
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {

        }
    }
}
