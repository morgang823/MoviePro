using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using MoviePro.Models;

namespace MoviePro.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<MoviePro.Models.movie> Movie { get; set; }

        public DbSet<MoviePro.Models.Cast> Cast { get; set; }

        public DbSet<MoviePro.Models.Crew> Crew { get; set; }
    }
}
