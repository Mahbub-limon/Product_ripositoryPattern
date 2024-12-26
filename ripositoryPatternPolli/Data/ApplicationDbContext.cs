using Microsoft.EntityFrameworkCore;
using ripositoryPatternPolli.Models;

namespace ripositoryPatternPolli.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext>options) : base(options)
        {
           //nothing returntype 
        }


        public DbSet<Product> Products { get; set; }



    }
}
