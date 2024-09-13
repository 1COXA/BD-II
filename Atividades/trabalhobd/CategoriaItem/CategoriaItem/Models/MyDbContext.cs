using Microsoft.EntityFrameworkCore;

namespace CategoriaItem.Models
{
    public class MyDbContext : DbContext
    {
        public MyDbContext(DbContextOptions<MyDbContext> options): base(options) { }
        public DbSet<Item> Items { get; set; }
        public DbSet<Categoria> categorias { get; set; }
              
    }
}
