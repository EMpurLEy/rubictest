using Microsoft.EntityFrameworkCore;
using rubictest.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace rubictest.Contexts
{
    public class UserContext : DbContext
    {
        public UserContext(DbContextOptions<UserContext> options)
            : base(options)
        {


        }
        public DbSet<User> Users { get; set; }
    }
}
