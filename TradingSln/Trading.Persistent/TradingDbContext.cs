using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using Trading.Core.Models;

namespace Trading.Persistent
{
    public class TradingDbContext : DbContext
    {
        //public DbSet<Bot> Bots { get; set; }

        public DbSet<Order> Orders { get; set; }


    }
}
