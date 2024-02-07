using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RainbowSchoolWebApp.Model;

namespace RainbowSchoolWebApp.Data
{
    public class SchoolDbContext : DbContext
    {
        public SchoolDbContext (DbContextOptions<SchoolDbContext> options)
            : base(options)
        {
        }

        public DbSet<RainbowSchoolWebApp.Model.Student> Student { get; set; } = default!;
    }
}
