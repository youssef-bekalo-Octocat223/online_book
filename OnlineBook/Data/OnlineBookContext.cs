#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using OnlineBook.Models;

namespace OnlineBook.Data
{
    public class OnlineBookContext : DbContext
    {
        public OnlineBookContext (DbContextOptions<OnlineBookContext> options)
            : base(options)
        {
        }

        public DbSet<OnlineBook.Models.book> book { get; set; }

        public DbSet<OnlineBook.Models.usersaccounts> usersaccounts { get; set; }

        public DbSet<OnlineBook.Models.orders> orders { get; set; }
        public DbSet<OnlineBook.Models.report> report { get; set; }
    }
}
