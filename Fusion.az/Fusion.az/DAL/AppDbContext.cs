
using Fusion.az.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fusion.az.DAL
{
    public class AppDbContext:IdentityDbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options):base(options)
        {

        }
        public DbSet<Bio> Bios { get; set; }
        public DbSet<Feature> Features { get; set; }
        public DbSet<Header> Headers { get; set; }
        public DbSet<FunFact> FunFacts { get; set; }
        public DbSet<Course> Courses { get; set; }
    }
}
