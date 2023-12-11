using Microsoft.EntityFrameworkCore;
using ProjectPustok.Models;

namespace ProjectPustok.Data
{
    public class PustokDbContext : DbContext
    {

        public PustokDbContext(DbContextOptions<PustokDbContext> options) : base(options)
        {
        }

        public DbSet<Slider> Sliders { get; set; }

    }
}
