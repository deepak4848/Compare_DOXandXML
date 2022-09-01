using Microsoft.EntityFrameworkCore;

namespace Compare_DOXandXML.Models
{
    public class DatabaseContext:DbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext>options):base(options)
        {

        }
        public DbSet<CompFile> CompFiles { get; set; }
    }
}
