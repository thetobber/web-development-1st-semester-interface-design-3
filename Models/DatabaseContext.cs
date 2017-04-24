using Microsoft.EntityFrameworkCore;

namespace interface_design_3.Data
{
    public class DatabaseContext : DbContext
    {
        protected override void OnConfiguring (DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Filename=interface-design-3.db");
        }
    }
}