using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace pin_projekt.Models
{
    public class Tablica_igracaContext : DbContext
    {
        public Tablica_igracaContext (DbContextOptions<Tablica_igracaContext> options)
            : base(options)
        {
        }

        public DbSet<pin_projekt.Models.Tablica_igraca> Tablica_igraca { get; set; }
    }
}
