using Abby.Models;
using Microsoft.EntityFrameworkCore;

namespace Abby.Data
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Category> Categories { get; set; }
    }
}
