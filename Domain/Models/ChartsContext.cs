using Microsoft.EntityFrameworkCore;
using ChartsAPI.Domain.Models;

namespace ChartsAPI.Domain.Models
{
    public class ChartsContext : DbContext
    {
        public ChartsContext(DbContextOptions<ChartsContext> options) : base(options)
        {

        }

        public DbSet<ChartDetails> ChartDetails { get; set; }
        public DbSet<ChartType> ChartTypes { get; set; }
    }
}
