using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using LanchesMac.Models;

namespace LanchesMac.Data
{
    public class LanchesMacContext : DbContext
    {
        public LanchesMacContext (DbContextOptions<LanchesMacContext> options)
            : base(options)
        {
        }

        public DbSet<Lanches> Lanches { get; set; }
        public DbSet<Categoria> Categoria { get; set; }
    }
}
