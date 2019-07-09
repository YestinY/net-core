using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Demo.Models;
namespace Demo.DBContexts
{
    public class StudentContext : DbContext
    {
        private IConfiguration Configuration { get; }

        public StudentContext(IConfiguration configuration)
        {
            this.Configuration = configuration;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySql(Configuration.GetConnectionString("testdb"));
        }

        public DbSet<UserEntity> Users { get; set; }
    }
    
}
