using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Bardan_Bianca_Lab2.Models;

namespace Bardan_Bianca_Lab2.Data
{
    public class Bardan_Bianca_Lab2Context : DbContext
    {
        public Bardan_Bianca_Lab2Context (DbContextOptions<Bardan_Bianca_Lab2Context> options)
            : base(options)
        {
        }

        public DbSet<Bardan_Bianca_Lab2.Models.Book> Book { get; set; } = default!;
    }
}
