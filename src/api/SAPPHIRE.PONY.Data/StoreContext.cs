using Microsoft.EntityFrameworkCore;
using SAPPHIRE.PONY.Domain.Catalog;

namespace SAPPHIRE.PONY.Data;

public class StoreContext : DbContext
{
    public StoreContext(DbContextOptions<StoreContext> options) : base(options)
    {

    }
    public DbSet<Item> Items { get; set; }
}