using Microsoft.EntityFrameworkCore;
using TaskGNIS.Models;

namespace TaskGNIS.Data
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext>options) : base(options)
        {

        }

        public DbSet<Products_Service_Tbl> Products { get; set; }
    }
}
