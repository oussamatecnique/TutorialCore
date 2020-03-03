using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using TutorialCore.Models;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace TutorialCore.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public DbSet<Make> Makes { get; set; }
        public DbSet<Models.Model> Models { get; set; }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
    }
}
