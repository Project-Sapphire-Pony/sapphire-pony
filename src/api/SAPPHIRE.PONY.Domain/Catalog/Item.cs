
namespace SAPPHIRE.PONY.Domain.Catalog;

public class Item {
    public int Id { get; set; }
    public string? Name { get; set; }
    public string? Description { get; set; }
    public string? Brand { get; set; }
    public decimal Price { get; set; }
    public List<Rating> Ratings { get; set; } = new List<Rating>();

    public Item(string Name, string Description, string Brand, decimal price) {
        if (string.IsNullOrWhiteSpace(Name)) {
            throw new ArgumentException ("Name is required");
        }

        if (string.IsNullOrWhiteSpace(Description)) {
            throw new ArgumentException ("Description is required");
        }

        if (string.IsNullOrWhiteSpace(Brand)) {
            throw new ArgumentException ("Brand is required");
        }

        if (price <= 0) {
            throw new ArgumentException ("Price must be greater than zero");
        }
    }
    public void AddRating(Rating rating){
    Ratings.Add(rating);
}
}

public class Rating
{
    public int Stars { get; set; }
    public string? userName { get; set; }
    public string? Review {get; set;
    }
    public Rating(int stars, string userName, string review){
    if(stars < 1 || stars > 5){
        throw new ArgumentException("Stars must be between 1 and 5");
    }
    if(string.IsNullOrWhiteSpace(userName)){
        throw new ArgumentException("User name is required");
    }
}

}