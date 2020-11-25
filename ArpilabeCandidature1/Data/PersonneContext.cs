using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace ArpilabeCandidature1.Models
{
    public class PersonneContext : DbContext
    {
        public PersonneContext (DbContextOptions<PersonneContext> options)
            : base(options)
        {
        }

        public DbSet<ArpilabeCandidature1.Models.Personne> Personne { get; set; }
    }
}
