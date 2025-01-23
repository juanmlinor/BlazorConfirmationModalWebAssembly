using BlazorConfirmationModalWebAssembly.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace BlazorConfirmationModalWebAssembly.Data
{
    public class ApplicationDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) => optionsBuilder.UseSqlServer(@"Data Source=(localdb)\\MSSQLLocalDB\DemoModal.db");
        public DbSet<Employee> employees { get; set; }
    }
}
