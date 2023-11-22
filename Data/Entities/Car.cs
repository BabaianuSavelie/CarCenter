namespace CarCenter.Data.Entities;

public class Car
{
    public Guid Id { get; set; }
    public Guid ModelId { get; set; }
    public BrandModel Model { get; set; }
    public Guid BrandId { get; set; }
    public Brand Brand { get; set; }
    public decimal Price { get; set; }
    public int DoorsNumber { get; set; }
}
