using Microsoft.EntityFrameworkCore;
using PieShopCore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PieShopCore.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<Pie> Pies { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
    }
}
