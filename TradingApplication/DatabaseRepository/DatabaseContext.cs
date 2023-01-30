using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TradingApplication.Models;

namespace TradingApplication.DatabaseRepository
{
    public class DatabaseContext: DbContext
    {
        public DatabaseContext()
        {
        }

        public DatabaseContext(DbContextOptions<DatabaseContext> options)
            : base(options)
        {

        }

        public DbSet<UserData> UserDataClass { get; set; }

        
        
    }
}
