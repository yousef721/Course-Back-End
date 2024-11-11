namespace P01_SalesDatabase.Models;

public class Product
{
    public int ProductId { get; set; }
    public string Name { get; set; }
    public uint Quantity { get; set; }
    public decimal Price { get; set; }
    public decimal Sale { get; set; }
    public string Description { get; set; }

}