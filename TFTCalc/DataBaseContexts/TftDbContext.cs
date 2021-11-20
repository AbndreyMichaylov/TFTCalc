using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TFTCalc.Models;

namespace TFTCalc.DataBaseContexts
{
    public class TftDbContext : DbContext
    {
        public DbSet<Hero> Hero { get; set; }
        public DbSet<HeroAttribute> HeroAttributes { get; set; }
        public DbSet<ComboItem> ComboItem { get; set; }
        public DbSet<Combo> Combo { get; set; }
        public TftDbContext(DbContextOptions<TftDbContext> options)
            : base(options)
        {
            Database.EnsureCreated();
        }
    }
}