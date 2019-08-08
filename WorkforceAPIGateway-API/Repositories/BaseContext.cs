using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using WorkforceAPIGateway_API.Entities;

namespace WorkforceAPIGateway_API.Repositories
{
    public class BaseContext : DbContext
    {

        public BaseContext(DbContextOptions<BaseContext> options)
            :base(options)
        {

        }

        #region DBSets

        public DbSet<User> Users { get; set; }

        #endregion


        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) => optionsBuilder.UseNpgsql("Host=localhost:5432;Database=workforcedb;Username=wfmuser;Password=Abc123!!");
    }
}
