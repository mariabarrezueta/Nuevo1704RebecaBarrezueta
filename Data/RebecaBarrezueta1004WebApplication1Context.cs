using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RebecaBarrezueta1004WebApplication1.Models;

namespace RebecaBarrezueta1004WebApplication1.Data
{
    public class RebecaBarrezueta1004WebApplication1Context : DbContext
    {
        public RebecaBarrezueta1004WebApplication1Context (DbContextOptions<RebecaBarrezueta1004WebApplication1Context> options)
            : base(options)
        {
        }

        public DbSet<RebecaBarrezueta1004WebApplication1.Models.Burguer> Burguer { get; set; } = default!;
        public DbSet<RebecaBarrezueta1004WebApplication1.Models.Promo> Promo { get; set; } = default!;

    }
}
