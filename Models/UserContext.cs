using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestTask5.Models
{
    public class UserContext : DbContext
    {
        public DbSet<User> User { get; set; }
        public DbSet<UserProfile> UserProfile { get; set; }
       
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=userstore;Trusted_Connection=True;");
        }

    }
}
