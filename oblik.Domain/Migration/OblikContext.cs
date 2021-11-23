using oblik.Domain.Models;
using System.Data.Entity;

namespace oblik.Domain.Migration
{
    class OblikContext : DbContext
    {
        public OblikContext() : base("DefaultConnection")
        { }
        public DbSet<MaterialValuesDTO> MaterialValue { get; set; }
    }
}
