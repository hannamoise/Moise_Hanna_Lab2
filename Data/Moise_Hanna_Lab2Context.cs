using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Moise_Hanna_Lab2.Models;

namespace Moise_Hanna_Lab2.Data
{
    public class Moise_Hanna_Lab2Context : DbContext
    {
        public Moise_Hanna_Lab2Context (DbContextOptions<Moise_Hanna_Lab2Context> options)
            : base(options)
        {
        }

        public DbSet<Moise_Hanna_Lab2.Models.Book> Book { get; set; } = default!;
        public DbSet<Moise_Hanna_Lab2.Models.Publisher> Publisher { get; set; } = default!;
        public DbSet<Moise_Hanna_Lab2.Models.Author> Author { get; set; } = default!;
        public DbSet<Moise_Hanna_Lab2.Models.Category> Category { get; set; } = default!;
    }
}
