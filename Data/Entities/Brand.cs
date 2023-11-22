namespace CarCenter.Data.Entities;

public class Brand
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public int ReleaseYear { get; set; }
    public string PhoneNumber { get; set; }
    public IEnumerable<BrandModel> Models { get; set; } 
}
