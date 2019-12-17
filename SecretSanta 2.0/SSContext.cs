using Microsoft.EntityFrameworkCore;
using SecretSanta_2._0.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace SecretSanta_2._0
{
    public class SSContext : DbContext
    {
        public DbSet<Person> FromList { get; set; }
        public DbSet<Person> ToList { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=DESKTOP-KN0EBQM;Database=SecretSanta;Integrated Security=True;");
        }
    }
}
