using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Cine.Models;

namespace Cine.Data
{
    public class CineContext : DbContext
    {
        public CineContext (DbContextOptions<CineContext> options)
            : base(options)
        {
        }

        public DbSet<Cine.Models.Pelicula>? Pelicula { get; set; }

        public DbSet<Cine.Models.Cliente>? Cliente { get; set; }

        public DbSet<Cine.Models.Sala>? Sala { get; set; }
    }
}
