using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using WorkforceAPIGateway_API.Entities;

namespace WorkforceAPIGateway_API.Repositories
{
    public class LoginContext : DbContext
    {
        public DbSet<User> Users { get; set; }


        // protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) => optionsBuilder.UseNpgsql("Host=my_host;Database=my_db;Username=my_user;Password=my_pw");
    }
}
