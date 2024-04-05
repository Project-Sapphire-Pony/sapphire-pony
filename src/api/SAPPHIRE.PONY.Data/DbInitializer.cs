using Microsoft.EntityFrameworkCore;
using SAPPHIRE.PONY.Domain.Catalog;

namespace SAPPHIRE.PONY.Data;
public static class DbInitializer{
    public static void Initialize(ModelBuilder builder)
    {
        builder.Entity<Item>().HasData(
            new Item(name: "Item 1", description: "Description 1", brand: "Brand 1", price: 100.00m) {Id = 1},
            new Item(name: "Item 2", description: "Description 2", brand: "Brand 2", price: 200.00m) {Id = 2},
            new Item(name: "Item 3", description: "Description 3", brand: "Brand 3", price: 300.00m) {Id = 3},
            new Item(name: "Item 4", description: "Description 4", brand: "Brand 4", price: 400.00m) {Id = 4}
        );
    }
}