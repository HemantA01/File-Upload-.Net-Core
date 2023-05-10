using Microsoft.EntityFrameworkCore;

namespace TestApp1.Model
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options) { }
        
        public DbSet<TblFileUpload> tblFiles { get; set; }
    }
}
