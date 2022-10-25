using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Costea_Maria_Lab2.Models;

namespace Costea_Maria_Lab2.Data
{
    public class Costea_Maria_Lab2Context : DbContext
    {
        public Costea_Maria_Lab2Context (DbContextOptions<Costea_Maria_Lab2Context> options)
            : base(options)
        {
        }

        public DbSet<Costea_Maria_Lab2.Models.Book> Book { get; set; } = default!;
    }
}
