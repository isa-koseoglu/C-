using EchoposCRUD.Models;
using Microsoft.EntityFrameworkCore;

namespace EchoposCRUD.Context
{
    public class CrudContext:DbContext
    {
        public CrudContext(DbContextOptions<CrudContext> options):base(options)
        {
        }
        public DbSet<Product> Products { get; set; }
    }
}
